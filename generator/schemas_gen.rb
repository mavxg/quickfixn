require 'builder'

class SchemaGen
  def self.generate messages, dir, fixver
    destdir = File.join(dir, fixver)
    Dir.mkdir(destdir) unless File.exists? destdir

    messages.each do |msg| 
      msgstr = gen_msg(msg, fixver)
      msg_path = File.join(destdir, msg[:name] + '.xsd')
      puts 'generate ' + msg_path
      File.open(msg_path, 'w') {|f| f.puts(msgstr) }
    end
  end

  def self.lower rawstr
    str = rawstr.clone
    str.slice(0,1).downcase + str.slice(1,rawstr.length)
  end

  def self.gen_msg msg, fixver
    xml = Builder::XmlMarkup.new(:indent=>2)
    xml.xs :schema, "xmlns:xs"=>"http://www.w3.org/2001/XMLSchema" do
      xml.xs :element, "name"=>msg[:name] do
        xml.xs :complexType do
          #xml.comment!("header")
          #xml.xs :sequence, 'minOccurs'=>"0" do
          #  gen_msg_fields msg[:header][:fields], xml
          #end
          xml.comment!("body")
          xml.xs :all do
            gen_msg_fields msg[:fields], xml
          end
          #xml.comment!("footer")
          #xml.xs :sequence, 'minOccurs'=>"0" do
          #  gen_msg_fields msg[:footer][:fields], xml
          #end
        end
      end
      gen_msg_groups msg[:groups], xml
    end
  end

  TYPES = {
    'AMT' => 'xs:float',
    'QTY' => 'xs:float',
    'PRICE' => 'xs:float',
    'FLOAT' => 'xs:float',
    'PRICEOFFSET' => 'xs:float',
    'PERCENTAGE' => 'xs:float',
    'INT' => 'xs:integer',
    'SEQNUM' => 'xs:nonNegativeInteger',
    'LENGTH' => 'xs:nonNegativeInteger',
    'STRING' => 'xs:string',
  }
  TYPES.default = 'xs:string'

  def self.gen_msg_fields fields, xml
    fields.each { |f| msg_field(f, xml) }
  end

  def self.msg_field f, xml
    attribs = {}
    attribs[:name] = f[:name]
    if f[:required] != true then attribs[:minOccurs]="0" end
    if f[:values] and not f[:group] then
      xml.xs :element, attribs do
        xml.xs :simpleType do
          xml.xs :restriction, :base=>TYPES[f[:fldtype]] do
            f[:values].each { |v|
              xml.xs :enumeration, :value=>v[:enum]
            }
          end
        end
      end
    else
      attribs[:type] = f[:group] ? f[:name] : TYPES[f[:fldtype]]
      xml.xs :element, attribs
    end
  end

  def self.gen_msg_groups groups, xml
    groups.each { |g| msg_group(g, xml) }
  end

  def self.msg_group g, xml
     xml.xs :complexType, "name"=>g[:name] do
       xml.xs :sequence, "minOccurs"=>"0", "maxOccurs"=>"unbounded" do
         gen_msg_fields g[:fields], xml
      end
      xml.xs :attribute, "name"=>"count", 'type'=>'xs:nonNegativeInteger'
    end
    gen_msg_groups(g[:groups], xml)
  end

end
