// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class OrderCancelReject : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "9"; } set {} }

            public string OrderID { get; set; }
            public string SecondaryOrderID { get; set; }
            public string SecondaryClOrdID { get; set; }
            public string ClOrdID { get; set; }
            public string ClOrdLinkID { get; set; }
            public string OrigClOrdID { get; set; }
            public string OrdStatus { get; set; }
            public string WorkingIndicator { get; set; }
            public string OrigOrdModTime { get; set; }
            public string ListID { get; set; }
            public string Account { get; set; }
            public int? AcctIDSource { get; set; }
            [XmlIgnore]
            public bool AcctIDSourceSpecified { get { return AcctIDSource.HasValue; } }
            public int? AccountType { get; set; }
            [XmlIgnore]
            public bool AccountTypeSpecified { get { return AccountType.HasValue; } }
            public string TradeOriginationDate { get; set; }
            public string TradeDate { get; set; }
            public string TransactTime { get; set; }
            public string CxlRejResponseTo { get; set; }
            public int? CxlRejReason { get; set; }
            [XmlIgnore]
            public bool CxlRejReasonSpecified { get { return CxlRejReason.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
