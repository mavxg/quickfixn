// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class OrderMassCancelRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "q"; } set {} }

            public string ClOrdID { get; set; }
            public string SecondaryClOrdID { get; set; }
            public string MassCancelRequestType { get; set; }
            public string TradingSessionID { get; set; }
            public string TradingSessionSubID { get; set; }
            public string Symbol { get; set; }
            public string SymbolSfx { get; set; }
            public string SecurityID { get; set; }
            public string SecurityIDSource { get; set; }
            [XmlArray("NoSecurityAltID")]
            public SecurityAltID[] NoSecurityAltID { get; set; }
            public int? Product { get; set; }
            [XmlIgnore]
            public bool ProductSpecified { get { return Product.HasValue; } }
            public int? FixedIncomeFlag { get; set; }
            [XmlIgnore]
            public bool FixedIncomeFlagSpecified { get { return FixedIncomeFlag.HasValue; } }
            public int? FixedIncomeSubFlag { get; set; }
            [XmlIgnore]
            public bool FixedIncomeSubFlagSpecified { get { return FixedIncomeSubFlag.HasValue; } }
            public string CFICode { get; set; }
            public string SecurityType { get; set; }
            public string SecuritySubType { get; set; }
            public string MaturityMonthYear { get; set; }
            public string MaturityDate { get; set; }
            public int? PutOrCall { get; set; }
            [XmlIgnore]
            public bool PutOrCallSpecified { get { return PutOrCall.HasValue; } }
            public string CouponPaymentDate { get; set; }
            public string IssueDate { get; set; }
            public int? RepoCollateralSecurityType { get; set; }
            [XmlIgnore]
            public bool RepoCollateralSecurityTypeSpecified { get { return RepoCollateralSecurityType.HasValue; } }
            public int? RepurchaseTerm { get; set; }
            [XmlIgnore]
            public bool RepurchaseTermSpecified { get { return RepurchaseTerm.HasValue; } }
            public double? RepurchaseRate { get; set; }
            [XmlIgnore]
            public bool RepurchaseRateSpecified { get { return RepurchaseRate.HasValue; } }
            public double? Factor { get; set; }
            [XmlIgnore]
            public bool FactorSpecified { get { return Factor.HasValue; } }
            public string CreditRating { get; set; }
            public string InstrRegistry { get; set; }
            public string CountryOfIssue { get; set; }
            public string StateOrProvinceOfIssue { get; set; }
            public string LocaleOfIssue { get; set; }
            public string RedemptionDate { get; set; }
            public double? StrikePrice { get; set; }
            [XmlIgnore]
            public bool StrikePriceSpecified { get { return StrikePrice.HasValue; } }
            public string StrikeCurrency { get; set; }
            public string OptAttribute { get; set; }
            public double? ContractMultiplier { get; set; }
            [XmlIgnore]
            public bool ContractMultiplierSpecified { get { return ContractMultiplier.HasValue; } }
            public double? CouponRate { get; set; }
            [XmlIgnore]
            public bool CouponRateSpecified { get { return CouponRate.HasValue; } }
            public string SecurityExchange { get; set; }
            public string Issuer { get; set; }
            public uint? EncodedIssuerLen { get; set; }
            [XmlIgnore]
            public bool EncodedIssuerLenSpecified { get { return EncodedIssuerLen.HasValue; } }
            public string EncodedIssuer { get; set; }
            public string SecurityDesc { get; set; }
            public uint? EncodedSecurityDescLen { get; set; }
            [XmlIgnore]
            public bool EncodedSecurityDescLenSpecified { get { return EncodedSecurityDescLen.HasValue; } }
            public string EncodedSecurityDesc { get; set; }
            public string Pool { get; set; }
            public string ContractSettlMonth { get; set; }
            public int? CPProgram { get; set; }
            [XmlIgnore]
            public bool CPProgramSpecified { get { return CPProgram.HasValue; } }
            public string CPRegType { get; set; }
            [XmlArray("NoEvents")]
            public Event[] NoEvents { get; set; }
            public double? AssumedCoupon { get; set; }
            [XmlIgnore]
            public bool AssumedCouponSpecified { get { return AssumedCoupon.HasValue; } }
            public string PrepaymentSpeed { get; set; }
            public string DatedDate { get; set; }
            public string InterestAccrualDate { get; set; }
            public string UnderlyingSymbol { get; set; }
            public string UnderlyingSymbolSfx { get; set; }
            public string UnderlyingSecurityID { get; set; }
            public string UnderlyingSecurityIDSource { get; set; }
            [XmlArray("NoUnderlyingSecurityAltID")]
            public UnderlyingSecurityAltID[] NoUnderlyingSecurityAltID { get; set; }
            public int? UnderlyingProduct { get; set; }
            [XmlIgnore]
            public bool UnderlyingProductSpecified { get { return UnderlyingProduct.HasValue; } }
            public string UnderlyingCFICode { get; set; }
            public string UnderlyingSecurityType { get; set; }
            public string UnderlyingSecuritySubType { get; set; }
            public string UnderlyingMaturityMonthYear { get; set; }
            public string UnderlyingMaturityDate { get; set; }
            public int? UnderlyingPutOrCall { get; set; }
            [XmlIgnore]
            public bool UnderlyingPutOrCallSpecified { get { return UnderlyingPutOrCall.HasValue; } }
            public string UnderlyingCouponPaymentDate { get; set; }
            public string UnderlyingIssueDate { get; set; }
            public int? UnderlyingRepoCollateralSecurityType { get; set; }
            [XmlIgnore]
            public bool UnderlyingRepoCollateralSecurityTypeSpecified { get { return UnderlyingRepoCollateralSecurityType.HasValue; } }
            public int? UnderlyingRepurchaseTerm { get; set; }
            [XmlIgnore]
            public bool UnderlyingRepurchaseTermSpecified { get { return UnderlyingRepurchaseTerm.HasValue; } }
            public double? UnderlyingRepurchaseRate { get; set; }
            [XmlIgnore]
            public bool UnderlyingRepurchaseRateSpecified { get { return UnderlyingRepurchaseRate.HasValue; } }
            public double? UnderlyingFactor { get; set; }
            [XmlIgnore]
            public bool UnderlyingFactorSpecified { get { return UnderlyingFactor.HasValue; } }
            public string UnderlyingCreditRating { get; set; }
            public string UnderlyingInstrRegistry { get; set; }
            public string UnderlyingCountryOfIssue { get; set; }
            public string UnderlyingStateOrProvinceOfIssue { get; set; }
            public string UnderlyingLocaleOfIssue { get; set; }
            public string UnderlyingRedemptionDate { get; set; }
            public double? UnderlyingStrikePrice { get; set; }
            [XmlIgnore]
            public bool UnderlyingStrikePriceSpecified { get { return UnderlyingStrikePrice.HasValue; } }
            public string UnderlyingStrikeCurrency { get; set; }
            public string UnderlyingOptAttribute { get; set; }
            public double? UnderlyingContractMultiplier { get; set; }
            [XmlIgnore]
            public bool UnderlyingContractMultiplierSpecified { get { return UnderlyingContractMultiplier.HasValue; } }
            public double? UnderlyingCouponRate { get; set; }
            [XmlIgnore]
            public bool UnderlyingCouponRateSpecified { get { return UnderlyingCouponRate.HasValue; } }
            public string UnderlyingSecurityExchange { get; set; }
            public string UnderlyingIssuer { get; set; }
            public uint? EncodedUnderlyingIssuerLen { get; set; }
            [XmlIgnore]
            public bool EncodedUnderlyingIssuerLenSpecified { get { return EncodedUnderlyingIssuerLen.HasValue; } }
            public string EncodedUnderlyingIssuer { get; set; }
            public string UnderlyingSecurityDesc { get; set; }
            public uint? EncodedUnderlyingSecurityDescLen { get; set; }
            [XmlIgnore]
            public bool EncodedUnderlyingSecurityDescLenSpecified { get { return EncodedUnderlyingSecurityDescLen.HasValue; } }
            public string EncodedUnderlyingSecurityDesc { get; set; }
            public string UnderlyingCPProgram { get; set; }
            public string UnderlyingCPRegType { get; set; }
            public string UnderlyingCurrency { get; set; }
            public double? UnderlyingQty { get; set; }
            [XmlIgnore]
            public bool UnderlyingQtySpecified { get { return UnderlyingQty.HasValue; } }
            public double? UnderlyingPx { get; set; }
            [XmlIgnore]
            public bool UnderlyingPxSpecified { get { return UnderlyingPx.HasValue; } }
            public double? UnderlyingDirtyPrice { get; set; }
            [XmlIgnore]
            public bool UnderlyingDirtyPriceSpecified { get { return UnderlyingDirtyPrice.HasValue; } }
            public double? UnderlyingEndPrice { get; set; }
            [XmlIgnore]
            public bool UnderlyingEndPriceSpecified { get { return UnderlyingEndPrice.HasValue; } }
            public double? UnderlyingStartValue { get; set; }
            [XmlIgnore]
            public bool UnderlyingStartValueSpecified { get { return UnderlyingStartValue.HasValue; } }
            public double? UnderlyingCurrentValue { get; set; }
            [XmlIgnore]
            public bool UnderlyingCurrentValueSpecified { get { return UnderlyingCurrentValue.HasValue; } }
            public double? UnderlyingEndValue { get; set; }
            [XmlIgnore]
            public bool UnderlyingEndValueSpecified { get { return UnderlyingEndValue.HasValue; } }
            [XmlArray("NoUnderlyingStips")]
            public UnderlyingStip[] NoUnderlyingStips { get; set; }
            public string Side { get; set; }
            public string TransactTime { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

            public partial class SecurityAltID
            {
            
                [XmlElement("SecurityAltID")]
                public string Id { get; set; }
                public string SecurityAltIDSource { get; set; }
            
            }

            public partial class Event
            {
            
                public int? EventType { get; set; }
                [XmlIgnore]
                public bool EventTypeSpecified { get { return EventType.HasValue; } }
                public string EventDate { get; set; }
                public double? EventPx { get; set; }
                [XmlIgnore]
                public bool EventPxSpecified { get { return EventPx.HasValue; } }
                public string EventText { get; set; }
            
            }

            public partial class UnderlyingSecurityAltID
            {
            
                [XmlElement("UnderlyingSecurityAltID")]
                public string Id { get; set; }
                public string UnderlyingSecurityAltIDSource { get; set; }
            
            }

            public partial class UnderlyingStip
            {
            
                public string UnderlyingStipType { get; set; }
                public string UnderlyingStipValue { get; set; }
            
            }
        }
    }
}
