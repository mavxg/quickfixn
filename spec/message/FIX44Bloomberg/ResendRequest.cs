// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ResendRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "2"; } set {} }

            public uint? BeginSeqNo { get; set; }
            [XmlIgnore]
            public bool BeginSeqNoSpecified { get { return BeginSeqNo.HasValue; } }
            public uint? EndSeqNo { get; set; }
            [XmlIgnore]
            public bool EndSeqNoSpecified { get { return EndSeqNo.HasValue; } }

        }
    }
}
