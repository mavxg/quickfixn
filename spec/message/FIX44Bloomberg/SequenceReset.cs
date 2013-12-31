// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class SequenceReset : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "4"; } set {} }

            public string GapFillFlag { get; set; }
            public uint? NewSeqNo { get; set; }
            [XmlIgnore]
            public bool NewSeqNoSpecified { get { return NewSeqNo.HasValue; } }

        }
    }
}
