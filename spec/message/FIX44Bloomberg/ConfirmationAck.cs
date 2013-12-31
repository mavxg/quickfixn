// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ConfirmationAck : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "AU"; } set {} }

            public string ConfirmID { get; set; }
            public string TradeDate { get; set; }
            public string TransactTime { get; set; }
            public int? AffirmStatus { get; set; }
            [XmlIgnore]
            public bool AffirmStatusSpecified { get { return AffirmStatus.HasValue; } }
            public int? ConfirmRejReason { get; set; }
            [XmlIgnore]
            public bool ConfirmRejReasonSpecified { get { return ConfirmRejReason.HasValue; } }
            public string MatchStatus { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
