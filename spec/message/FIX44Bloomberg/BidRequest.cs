// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class BidRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "k"; } set {} }

            public string BidID { get; set; }
            public string ClientBidID { get; set; }
            public string BidRequestTransType { get; set; }
            public string ListName { get; set; }
            public int? TotNoRelatedSym { get; set; }
            [XmlIgnore]
            public bool TotNoRelatedSymSpecified { get { return TotNoRelatedSym.HasValue; } }
            public int? BidType { get; set; }
            [XmlIgnore]
            public bool BidTypeSpecified { get { return BidType.HasValue; } }
            public int? NumTickets { get; set; }
            [XmlIgnore]
            public bool NumTicketsSpecified { get { return NumTickets.HasValue; } }
            public string Currency { get; set; }
            public double? SideValue1 { get; set; }
            [XmlIgnore]
            public bool SideValue1Specified { get { return SideValue1.HasValue; } }
            public double? SideValue2 { get; set; }
            [XmlIgnore]
            public bool SideValue2Specified { get { return SideValue2.HasValue; } }
            [XmlArray("NoBidDescriptors")]
            public BidDescriptor[] NoBidDescriptors { get; set; }
            [XmlArray("NoBidComponents")]
            public BidComponent[] NoBidComponents { get; set; }
            public int? LiquidityIndType { get; set; }
            [XmlIgnore]
            public bool LiquidityIndTypeSpecified { get { return LiquidityIndType.HasValue; } }
            public double? WtAverageLiquidity { get; set; }
            [XmlIgnore]
            public bool WtAverageLiquiditySpecified { get { return WtAverageLiquidity.HasValue; } }
            public string ExchangeForPhysical { get; set; }
            public double? OutMainCntryUIndex { get; set; }
            [XmlIgnore]
            public bool OutMainCntryUIndexSpecified { get { return OutMainCntryUIndex.HasValue; } }
            public double? CrossPercent { get; set; }
            [XmlIgnore]
            public bool CrossPercentSpecified { get { return CrossPercent.HasValue; } }
            public int? ProgRptReqs { get; set; }
            [XmlIgnore]
            public bool ProgRptReqsSpecified { get { return ProgRptReqs.HasValue; } }
            public int? ProgPeriodInterval { get; set; }
            [XmlIgnore]
            public bool ProgPeriodIntervalSpecified { get { return ProgPeriodInterval.HasValue; } }
            public int? IncTaxInd { get; set; }
            [XmlIgnore]
            public bool IncTaxIndSpecified { get { return IncTaxInd.HasValue; } }
            public string ForexReq { get; set; }
            public int? NumBidders { get; set; }
            [XmlIgnore]
            public bool NumBiddersSpecified { get { return NumBidders.HasValue; } }
            public string TradeDate { get; set; }
            public string BidTradeType { get; set; }
            public string BasisPxType { get; set; }
            public string StrikeTime { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

            public partial class BidDescriptor
            {
            
                public int? BidDescriptorType { get; set; }
                [XmlIgnore]
                public bool BidDescriptorTypeSpecified { get { return BidDescriptorType.HasValue; } }
                [XmlElement("BidDescriptor")]
                public string Id { get; set; }
                public int? SideValueInd { get; set; }
                [XmlIgnore]
                public bool SideValueIndSpecified { get { return SideValueInd.HasValue; } }
                public double? LiquidityValue { get; set; }
                [XmlIgnore]
                public bool LiquidityValueSpecified { get { return LiquidityValue.HasValue; } }
                public int? LiquidityNumSecurities { get; set; }
                [XmlIgnore]
                public bool LiquidityNumSecuritiesSpecified { get { return LiquidityNumSecurities.HasValue; } }
                public double? LiquidityPctLow { get; set; }
                [XmlIgnore]
                public bool LiquidityPctLowSpecified { get { return LiquidityPctLow.HasValue; } }
                public double? LiquidityPctHigh { get; set; }
                [XmlIgnore]
                public bool LiquidityPctHighSpecified { get { return LiquidityPctHigh.HasValue; } }
                public double? EFPTrackingError { get; set; }
                [XmlIgnore]
                public bool EFPTrackingErrorSpecified { get { return EFPTrackingError.HasValue; } }
                public double? FairValue { get; set; }
                [XmlIgnore]
                public bool FairValueSpecified { get { return FairValue.HasValue; } }
                public double? OutsideIndexPct { get; set; }
                [XmlIgnore]
                public bool OutsideIndexPctSpecified { get { return OutsideIndexPct.HasValue; } }
                public double? ValueOfFutures { get; set; }
                [XmlIgnore]
                public bool ValueOfFuturesSpecified { get { return ValueOfFutures.HasValue; } }
            
            }

            public partial class BidComponent
            {
            
                public string ListID { get; set; }
                public string Side { get; set; }
                public string TradingSessionID { get; set; }
                public string TradingSessionSubID { get; set; }
                public int? NetGrossInd { get; set; }
                [XmlIgnore]
                public bool NetGrossIndSpecified { get { return NetGrossInd.HasValue; } }
                public string SettlType { get; set; }
                public string SettlDate { get; set; }
                public string Account { get; set; }
                public int? AcctIDSource { get; set; }
                [XmlIgnore]
                public bool AcctIDSourceSpecified { get { return AcctIDSource.HasValue; } }
            
            }
        }
    }
}
