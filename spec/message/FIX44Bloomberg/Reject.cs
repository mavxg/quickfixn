// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class Reject : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "3"; } set {} }

            public uint? RefSeqNum { get; set; }
            [XmlIgnore]
            public bool RefSeqNumSpecified { get { return RefSeqNum.HasValue; } }
            public int? RefTagID { get; set; }
            [XmlIgnore]
            public bool RefTagIDSpecified { get { return RefTagID.HasValue; } }
            public string RefMsgType { get; set; }
            public int? SessionRejectReason { get; set; }
            [XmlIgnore]
            public bool SessionRejectReasonSpecified { get { return SessionRejectReason.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
