// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class DerivativeSecurityListRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "z"; } set {} }

            public string SecurityReqID { get; set; }
            public int? SecurityListRequestType { get; set; }
            [XmlIgnore]
            public bool SecurityListRequestTypeSpecified { get { return SecurityListRequestType.HasValue; } }
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
            public string SecuritySubType { get; set; }
            public string Currency { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            public string TradingSessionID { get; set; }
            public string TradingSessionSubID { get; set; }
            public string SubscriptionRequestType { get; set; }

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
