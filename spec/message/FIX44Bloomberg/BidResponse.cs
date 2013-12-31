// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class BidResponse : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "l"; } set {} }

            public string BidID { get; set; }
            public string ClientBidID { get; set; }
            [XmlArray("NoBidComponents")]
            public BidComponent[] NoBidComponents { get; set; }

            public partial class BidComponent
            {
            
                public double? Commission { get; set; }
                [XmlIgnore]
                public bool CommissionSpecified { get { return Commission.HasValue; } }
                public string CommType { get; set; }
                public string CommCurrency { get; set; }
                public string FundRenewWaiv { get; set; }
                public string ListID { get; set; }
                public string Country { get; set; }
                public string Side { get; set; }
                public double? Price { get; set; }
                [XmlIgnore]
                public bool PriceSpecified { get { return Price.HasValue; } }
                public int? PriceType { get; set; }
                [XmlIgnore]
                public bool PriceTypeSpecified { get { return PriceType.HasValue; } }
                public double? FairValue { get; set; }
                [XmlIgnore]
                public bool FairValueSpecified { get { return FairValue.HasValue; } }
                public int? NetGrossInd { get; set; }
                [XmlIgnore]
                public bool NetGrossIndSpecified { get { return NetGrossInd.HasValue; } }
                public string SettlType { get; set; }
                public string SettlDate { get; set; }
                public string TradingSessionID { get; set; }
                public string TradingSessionSubID { get; set; }
                public string Text { get; set; }
                public uint? EncodedTextLen { get; set; }
                [XmlIgnore]
                public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
                public string EncodedText { get; set; }
            
            }
        }
    }
}
