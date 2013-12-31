// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class TradeCaptureReportAck : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "AR"; } set {} }

            public int? FirmNo { get; set; }
            [XmlIgnore]
            public bool FirmNoSpecified { get { return FirmNo.HasValue; } }
            public int? PricingNo { get; set; }
            [XmlIgnore]
            public bool PricingNoSpecified { get { return PricingNo.HasValue; } }
            public int? UUID { get; set; }
            [XmlIgnore]
            public bool UUIDSpecified { get { return UUID.HasValue; } }
            public string TradeReportID { get; set; }
            public int? TradeReportTransType { get; set; }
            [XmlIgnore]
            public bool TradeReportTransTypeSpecified { get { return TradeReportTransType.HasValue; } }
            public int? TradeReportType { get; set; }
            [XmlIgnore]
            public bool TradeReportTypeSpecified { get { return TradeReportType.HasValue; } }
            public int? TrdType { get; set; }
            [XmlIgnore]
            public bool TrdTypeSpecified { get { return TrdType.HasValue; } }
            public int? TrdSubType { get; set; }
            [XmlIgnore]
            public bool TrdSubTypeSpecified { get { return TrdSubType.HasValue; } }
            public int? SecondaryTrdType { get; set; }
            [XmlIgnore]
            public bool SecondaryTrdTypeSpecified { get { return SecondaryTrdType.HasValue; } }
            public string TransferReason { get; set; }
            public string ExecType { get; set; }
            public string TradeReportRefID { get; set; }
            public string SecondaryTradeReportRefID { get; set; }
            public int? TrdRptStatus { get; set; }
            [XmlIgnore]
            public bool TrdRptStatusSpecified { get { return TrdRptStatus.HasValue; } }
            public int? TradeReportRejectReason { get; set; }
            [XmlIgnore]
            public bool TradeReportRejectReasonSpecified { get { return TradeReportRejectReason.HasValue; } }
            public string SecondaryTradeReportID { get; set; }
            public string SubscriptionRequestType { get; set; }
            public string TradeLinkID { get; set; }
            public string TrdMatchID { get; set; }
            public string ExecID { get; set; }
            public string TradingSystemTicketNumber { get; set; }
            public string SecondaryExecID { get; set; }
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
            public string TransactTime { get; set; }
            [XmlArray("NoTrdRegTimestamps")]
            public TrdRegTimestamp[] NoTrdRegTimestamps { get; set; }
            public int? ResponseTransportType { get; set; }
            [XmlIgnore]
            public bool ResponseTransportTypeSpecified { get { return ResponseTransportType.HasValue; } }
            public string ResponseDestination { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            [XmlArray("NoLegs")]
            public Leg[] NoLegs { get; set; }
            public string ClearingFeeIndicator { get; set; }
            public string OrderCapacity { get; set; }
            public string OrderRestrictions { get; set; }
            public int? CustOrderCapacity { get; set; }
            [XmlIgnore]
            public bool CustOrderCapacitySpecified { get { return CustOrderCapacity.HasValue; } }
            public string Account { get; set; }
            public int? AcctIDSource { get; set; }
            [XmlIgnore]
            public bool AcctIDSourceSpecified { get { return AcctIDSource.HasValue; } }
            public int? AccountType { get; set; }
            [XmlIgnore]
            public bool AccountTypeSpecified { get { return AccountType.HasValue; } }
            public string PositionEffect { get; set; }
            public string PreallocMethod { get; set; }
            [XmlArray("NoAllocs")]
            public Alloc[] NoAllocs { get; set; }
            [XmlArray("NoTickets")]
            public Ticket[] NoTickets { get; set; }

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

            public partial class TrdRegTimestamp
            {
            
                [XmlElement("TrdRegTimestamp")]
                public string Id { get; set; }
                public int? TrdRegTimestampType { get; set; }
                [XmlIgnore]
                public bool TrdRegTimestampTypeSpecified { get { return TrdRegTimestampType.HasValue; } }
                public string TrdRegTimestampOrigin { get; set; }
            
            }

            public partial class Leg
            {
            
                public string LegSymbol { get; set; }
                public string LegSymbolSfx { get; set; }
                public string LegSecurityID { get; set; }
                public string LegSecurityIDSource { get; set; }
                [XmlArray("NoLegSecurityAltID")]
                public LegSecurityAltID[] NoLegSecurityAltID { get; set; }
                public int? LegProduct { get; set; }
                [XmlIgnore]
                public bool LegProductSpecified { get { return LegProduct.HasValue; } }
                public string LegCFICode { get; set; }
                public string LegSecurityType { get; set; }
                public string LegSecuritySubType { get; set; }
                public string LegMaturityMonthYear { get; set; }
                public string LegMaturityDate { get; set; }
                public string LegCouponPaymentDate { get; set; }
                public string LegIssueDate { get; set; }
                public int? LegRepoCollateralSecurityType { get; set; }
                [XmlIgnore]
                public bool LegRepoCollateralSecurityTypeSpecified { get { return LegRepoCollateralSecurityType.HasValue; } }
                public int? LegRepurchaseTerm { get; set; }
                [XmlIgnore]
                public bool LegRepurchaseTermSpecified { get { return LegRepurchaseTerm.HasValue; } }
                public double? LegRepurchaseRate { get; set; }
                [XmlIgnore]
                public bool LegRepurchaseRateSpecified { get { return LegRepurchaseRate.HasValue; } }
                public double? LegFactor { get; set; }
                [XmlIgnore]
                public bool LegFactorSpecified { get { return LegFactor.HasValue; } }
                public string LegCreditRating { get; set; }
                public string LegInstrRegistry { get; set; }
                public string LegCountryOfIssue { get; set; }
                public string LegStateOrProvinceOfIssue { get; set; }
                public string LegLocaleOfIssue { get; set; }
                public string LegRedemptionDate { get; set; }
                public double? LegStrikePrice { get; set; }
                [XmlIgnore]
                public bool LegStrikePriceSpecified { get { return LegStrikePrice.HasValue; } }
                public string LegStrikeCurrency { get; set; }
                public string LegOptAttribute { get; set; }
                public double? LegContractMultiplier { get; set; }
                [XmlIgnore]
                public bool LegContractMultiplierSpecified { get { return LegContractMultiplier.HasValue; } }
                public double? LegCouponRate { get; set; }
                [XmlIgnore]
                public bool LegCouponRateSpecified { get { return LegCouponRate.HasValue; } }
                public string LegSecurityExchange { get; set; }
                public string LegIssuer { get; set; }
                public uint? EncodedLegIssuerLen { get; set; }
                [XmlIgnore]
                public bool EncodedLegIssuerLenSpecified { get { return EncodedLegIssuerLen.HasValue; } }
                public string EncodedLegIssuer { get; set; }
                public string LegSecurityDesc { get; set; }
                public uint? EncodedLegSecurityDescLen { get; set; }
                [XmlIgnore]
                public bool EncodedLegSecurityDescLenSpecified { get { return EncodedLegSecurityDescLen.HasValue; } }
                public string EncodedLegSecurityDesc { get; set; }
                public double? LegRatioQty { get; set; }
                [XmlIgnore]
                public bool LegRatioQtySpecified { get { return LegRatioQty.HasValue; } }
                public string LegSide { get; set; }
                public string LegCurrency { get; set; }
                public string LegPool { get; set; }
                public string LegDatedDate { get; set; }
                public string LegContractSettlMonth { get; set; }
                public string LegInterestAccrualDate { get; set; }
                public double? LegQty { get; set; }
                [XmlIgnore]
                public bool LegQtySpecified { get { return LegQty.HasValue; } }
                public int? LegSwapType { get; set; }
                [XmlIgnore]
                public bool LegSwapTypeSpecified { get { return LegSwapType.HasValue; } }
                [XmlArray("NoLegStipulations")]
                public LegStipulation[] NoLegStipulations { get; set; }
                public string LegPositionEffect { get; set; }
                public int? LegCoveredOrUncovered { get; set; }
                [XmlIgnore]
                public bool LegCoveredOrUncoveredSpecified { get { return LegCoveredOrUncovered.HasValue; } }
                [XmlArray("NoNestedPartyIDs")]
                public NestedPartyID[] NoNestedPartyIDs { get; set; }
                public string LegRefID { get; set; }
                public double? LegPrice { get; set; }
                [XmlIgnore]
                public bool LegPriceSpecified { get { return LegPrice.HasValue; } }
                public string LegSettlType { get; set; }
                public string LegSettlDate { get; set; }
                public double? LegLastPx { get; set; }
                [XmlIgnore]
                public bool LegLastPxSpecified { get { return LegLastPx.HasValue; } }
            
                public partial class LegSecurityAltID
                {
                
                    [XmlElement("LegSecurityAltID")]
                    public string Id { get; set; }
                    public string LegSecurityAltIDSource { get; set; }
                
                }

                public partial class LegStipulation
                {
                
                    public string LegStipulationType { get; set; }
                    public string LegStipulationValue { get; set; }
                
                }

                public partial class NestedPartyID
                {
                
                    [XmlElement("NestedPartyID")]
                    public string Id { get; set; }
                    public string NestedPartyIDSource { get; set; }
                    public int? NestedPartyRole { get; set; }
                    [XmlIgnore]
                    public bool NestedPartyRoleSpecified { get { return NestedPartyRole.HasValue; } }
                    [XmlArray("NoNestedPartySubIDs")]
                    public NestedPartySubID[] NoNestedPartySubIDs { get; set; }
                
                    public partial class NestedPartySubID
                    {
                    
                        [XmlElement("NestedPartySubID")]
                        public string Id { get; set; }
                        public int? NestedPartySubIDType { get; set; }
                        [XmlIgnore]
                        public bool NestedPartySubIDTypeSpecified { get { return NestedPartySubIDType.HasValue; } }
                    
                    }
                }
            }

            public partial class Alloc
            {
            
                public string AllocAccount { get; set; }
                public int? AllocAcctIDSource { get; set; }
                [XmlIgnore]
                public bool AllocAcctIDSourceSpecified { get { return AllocAcctIDSource.HasValue; } }
                public string AllocSettlCurrency { get; set; }
                public string IndividualAllocID { get; set; }
                [XmlArray("NoNested2PartyIDs")]
                public Nested2PartyID[] NoNested2PartyIDs { get; set; }
                public double? AllocQty { get; set; }
                [XmlIgnore]
                public bool AllocQtySpecified { get { return AllocQty.HasValue; } }
            
                public partial class Nested2PartyID
                {
                
                    [XmlElement("Nested2PartyID")]
                    public string Id { get; set; }
                    public string Nested2PartyIDSource { get; set; }
                    public int? Nested2PartyRole { get; set; }
                    [XmlIgnore]
                    public bool Nested2PartyRoleSpecified { get { return Nested2PartyRole.HasValue; } }
                    [XmlArray("NoNested2PartySubIDs")]
                    public Nested2PartySubID[] NoNested2PartySubIDs { get; set; }
                
                    public partial class Nested2PartySubID
                    {
                    
                        [XmlElement("Nested2PartySubID")]
                        public string Id { get; set; }
                        public int? Nested2PartySubIDType { get; set; }
                        [XmlIgnore]
                        public bool Nested2PartySubIDTypeSpecified { get { return Nested2PartySubIDType.HasValue; } }
                    
                    }
                }
            }

            public partial class Ticket
            {
            
                public string RepeatingTicketNo { get; set; }
            
            }
        }
    }
}
