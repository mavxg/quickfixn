// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class BusinessMessageReject : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "j"; } set {} }

            public uint? RefSeqNum { get; set; }
            [XmlIgnore]
            public bool RefSeqNumSpecified { get { return RefSeqNum.HasValue; } }
            public string RefMsgType { get; set; }
            public string BusinessRejectRefID { get; set; }
            public int? BusinessRejectReason { get; set; }
            [XmlIgnore]
            public bool BusinessRejectReasonSpecified { get { return BusinessRejectReason.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
