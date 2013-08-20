

class SchemaMessageGen
  def self.generate messages, dir, fixver, beginstring
    destdir = File.join(dir, fixver)
    Dir.mkdir(destdir) unless File.exists? destdir

    basemsgstr = gen_basemsg(fixver,destdir, beginstring)
    basemsg_path = File.join(destdir, "Message.cs")
    puts 'generate ' + basemsg_path
    File.open(basemsg_path, 'w') {|f| f.puts(basemsgstr) }

    messages.each do |msg| 
      msgstr = gen_msg(msg, fixver)
      msg_path = File.join(destdir, msg[:name] + '.cs')
      puts 'generate ' + msg_path
      File.open(msg_path, 'w') {|f| f.puts(msgstr) }
    end
  end

  def self.lower rawstr
    str = rawstr.clone
    str.slice(0,1).downcase + str.slice(1,rawstr.length)
  end

  def self.gen_basemsg fixver, destdir, beginstring 
<<HERE
// This is a generated file.  Don't edit it directly!
using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace #{fixver}
    {
        public abstract class Message
        {
            [XmlAttribute("beginString")]
            public string BeginString { get { return "#{beginstring}"; } set {} }
        }
    }
}
HERE
  end

  def self.gen_msg msg, fixver 
<<HERE
// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace #{fixver} 
    {
        public class #{msg[:name]} : Message
        {
#{msgtype(msg)}
#{gen_msg_fields(msg[:fields], 12)}
#{gen_msg_groups(msg[:groups], 12)}
        }
    }
}
HERE
  end

  def self.msgtype msg
<<HERE
            [XmlAttribute("msgType")]
            public string MsgType { get { return "#{msg[:msgtype]}"; } set {} }
HERE
  end

  def self.gen_msg_fields fields, prepend_spaces
    fields.map { |fld| msg_field(fld,prepend_spaces) }.join("\n")
  end

  def self.gen_msg_groups groups, prepend_spaces
    groups.map { |grp| msg_grp(grp, prepend_spaces) }.join("\n")
  end

  TYPES = {
    'AMT' => 'double?',
    'QTY' => 'double?',
    'PRICE' => 'double?',
    'FLOAT' => 'double?',
    'PRICEOFFSET' => 'double?',
    'PERCENTAGE' => 'double?',
    'INT' => 'int?',
    'SEQNUM' => 'uint?',
    'LENGTH' => 'uint?',
    'STRING' => 'string',
  }
  TYPES.default = 'string'


  def self.required_fields msg
    msg[:fields].select {|f| f[:required] == true and f[:group] == false }
  end

  def self.msg_field fld, prepend_spaces, name=nil
    str = []
    if (name.nil?)
       name = fld[:name]
    end
    if (fld[:group])
      t = fld[:name].sub(/^No/,'').sub(/s$/,'') + '[]'
      str << "[XmlArray(\"#{fld[:name]}\")]"
    else 
      t = TYPES[fld[:fldtype]]
    end
    if (name=="Id") 
      str << "[XmlElement(\"#{fld[:name]}\")]"
    end
    str << "public #{t} #{name} { get; set; }"
    if (t[-1] == '?')
    str << "[XmlIgnore]"
    str << "public bool #{name}Specified { get { return #{name}.HasValue; } }"
    end
    str.map! {|s| ' '*prepend_spaces + s}
    str.join("\n")
  end

  def self.gen_msg_fields_g fields, prepend_spaces, gname
    "\n" + fields.map { |fld| 
	msg_field(fld,prepend_spaces,(fld[:name] == gname) ? "Id" : fld[:name]) 
    }.join("\n")
  end


  def self.msg_grp grp, prepend_spaces
    name = grp[:name].sub(/^No/,'').sub(/s$/,'') 
    str = []
    str << "public partial class #{name}"
    str << "{"
    str << gen_msg_fields_g(grp[:fields], prepend_spaces+4, name)
    str << gen_msg_groups(grp[:groups], prepend_spaces+4)
    str << "}"
    "\n" + str.map {|s| ' '*prepend_spaces + s}.join("\n")
  end

  def self.grp_field_order fields
    field_order = fields.map {|f| "Tags.#{f[:name]}"}
    field_order << "0"  ## um, because qf and qfj do it
    field_order.join(", ")
  end
end
