// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class NewOrderCross : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "s"; } set {} }

            public string CrossID { get; set; }
            public int? CrossType { get; set; }
            [XmlIgnore]
            public bool CrossTypeSpecified { get { return CrossType.HasValue; } }
            public int? CrossPrioritization { get; set; }
            [XmlIgnore]
            public bool CrossPrioritizationSpecified { get { return CrossPrioritization.HasValue; } }
            [XmlArray("NoSides")]
            public Side[] NoSides { get; set; }
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
            [XmlArray("NoUnderlyings")]
            public Underlying[] NoUnderlyings { get; set; }
            [XmlArray("NoLegs")]
            public Leg[] NoLegs { get; set; }
            public string SettlType { get; set; }
            public string SettlDate { get; set; }
            public string HandlInst { get; set; }
            public string ExecInst { get; set; }
            public double? MinQty { get; set; }
            [XmlIgnore]
            public bool MinQtySpecified { get { return MinQty.HasValue; } }
            public double? MaxFloor { get; set; }
            [XmlIgnore]
            public bool MaxFloorSpecified { get { return MaxFloor.HasValue; } }
            public string ExDestination { get; set; }
            [XmlArray("NoTradingSessions")]
            public TradingSession[] NoTradingSessions { get; set; }
            public string ProcessCode { get; set; }
            public double? PrevClosePx { get; set; }
            [XmlIgnore]
            public bool PrevClosePxSpecified { get { return PrevClosePx.HasValue; } }
            public string LocateReqd { get; set; }
            public string TransactTime { get; set; }
            [XmlArray("NoStipulations")]
            public Stipulation[] NoStipulations { get; set; }
            public string OrdType { get; set; }
            public int? PriceType { get; set; }
            [XmlIgnore]
            public bool PriceTypeSpecified { get { return PriceType.HasValue; } }
            public double? Price { get; set; }
            [XmlIgnore]
            public bool PriceSpecified { get { return Price.HasValue; } }
            public double? StopPx { get; set; }
            [XmlIgnore]
            public bool StopPxSpecified { get { return StopPx.HasValue; } }
            public double? Spread { get; set; }
            [XmlIgnore]
            public bool SpreadSpecified { get { return Spread.HasValue; } }
            public string BenchmarkCurveCurrency { get; set; }
            public string BenchmarkCurveName { get; set; }
            public string BenchmarkCurvePoint { get; set; }
            public double? BenchmarkPrice { get; set; }
            [XmlIgnore]
            public bool BenchmarkPriceSpecified { get { return BenchmarkPrice.HasValue; } }
            public int? BenchmarkPriceType { get; set; }
            [XmlIgnore]
            public bool BenchmarkPriceTypeSpecified { get { return BenchmarkPriceType.HasValue; } }
            public string BenchmarkSecurityID { get; set; }
            public string BenchmarkSecurityIDSource { get; set; }
            public string YieldType { get; set; }
            public double? Yield { get; set; }
            [XmlIgnore]
            public bool YieldSpecified { get { return Yield.HasValue; } }
            public string YieldCalcDate { get; set; }
            public string YieldRedemptionDate { get; set; }
            public double? YieldRedemptionPrice { get; set; }
            [XmlIgnore]
            public bool YieldRedemptionPriceSpecified { get { return YieldRedemptionPrice.HasValue; } }
            public int? YieldRedemptionPriceType { get; set; }
            [XmlIgnore]
            public bool YieldRedemptionPriceTypeSpecified { get { return YieldRedemptionPriceType.HasValue; } }
            public string Currency { get; set; }
            public string ComplianceID { get; set; }
            public string IOIid { get; set; }
            public string QuoteID { get; set; }
            public string TimeInForce { get; set; }
            public string EffectiveTime { get; set; }
            public string ExpireDate { get; set; }
            public string ExpireTime { get; set; }
            public int? GTBookingInst { get; set; }
            [XmlIgnore]
            public bool GTBookingInstSpecified { get { return GTBookingInst.HasValue; } }
            public double? MaxShow { get; set; }
            [XmlIgnore]
            public bool MaxShowSpecified { get { return MaxShow.HasValue; } }
            public double? PegOffsetValue { get; set; }
            [XmlIgnore]
            public bool PegOffsetValueSpecified { get { return PegOffsetValue.HasValue; } }
            public int? PegMoveType { get; set; }
            [XmlIgnore]
            public bool PegMoveTypeSpecified { get { return PegMoveType.HasValue; } }
            public int? PegOffsetType { get; set; }
            [XmlIgnore]
            public bool PegOffsetTypeSpecified { get { return PegOffsetType.HasValue; } }
            public int? PegLimitType { get; set; }
            [XmlIgnore]
            public bool PegLimitTypeSpecified { get { return PegLimitType.HasValue; } }
            public int? PegRoundDirection { get; set; }
            [XmlIgnore]
            public bool PegRoundDirectionSpecified { get { return PegRoundDirection.HasValue; } }
            public int? PegScope { get; set; }
            [XmlIgnore]
            public bool PegScopeSpecified { get { return PegScope.HasValue; } }
            public string DiscretionInst { get; set; }
            public double? DiscretionOffsetValue { get; set; }
            [XmlIgnore]
            public bool DiscretionOffsetValueSpecified { get { return DiscretionOffsetValue.HasValue; } }
            public int? DiscretionMoveType { get; set; }
            [XmlIgnore]
            public bool DiscretionMoveTypeSpecified { get { return DiscretionMoveType.HasValue; } }
            public int? DiscretionOffsetType { get; set; }
            [XmlIgnore]
            public bool DiscretionOffsetTypeSpecified { get { return DiscretionOffsetType.HasValue; } }
            public int? DiscretionLimitType { get; set; }
            [XmlIgnore]
            public bool DiscretionLimitTypeSpecified { get { return DiscretionLimitType.HasValue; } }
            public int? DiscretionRoundDirection { get; set; }
            [XmlIgnore]
            public bool DiscretionRoundDirectionSpecified { get { return DiscretionRoundDirection.HasValue; } }
            public int? DiscretionScope { get; set; }
            [XmlIgnore]
            public bool DiscretionScopeSpecified { get { return DiscretionScope.HasValue; } }
            public int? TargetStrategy { get; set; }
            [XmlIgnore]
            public bool TargetStrategySpecified { get { return TargetStrategy.HasValue; } }
            public string TargetStrategyParameters { get; set; }
            public double? ParticipationRate { get; set; }
            [XmlIgnore]
            public bool ParticipationRateSpecified { get { return ParticipationRate.HasValue; } }
            public string CancellationRights { get; set; }
            public string MoneyLaunderingStatus { get; set; }
            public string RegistID { get; set; }
            public string Designation { get; set; }

            public partial class Side
            {
            
                [XmlElement("Side")]
                public string Id { get; set; }
                public string ClOrdID { get; set; }
                public string SecondaryClOrdID { get; set; }
                public string ClOrdLinkID { get; set; }
                [XmlArray("NoPartyIDs")]
                public PartyID[] NoPartyIDs { get; set; }
                public string TradeOriginationDate { get; set; }
                public string TradeDate { get; set; }
                public string Account { get; set; }
                public int? AcctIDSource { get; set; }
                [XmlIgnore]
                public bool AcctIDSourceSpecified { get { return AcctIDSource.HasValue; } }
                public int? AccountType { get; set; }
                [XmlIgnore]
                public bool AccountTypeSpecified { get { return AccountType.HasValue; } }
                public string DayBookingInst { get; set; }
                public string BookingUnit { get; set; }
                public string PreallocMethod { get; set; }
                public string AllocID { get; set; }
                [XmlArray("NoAllocs")]
                public Alloc[] NoAllocs { get; set; }
                public int? QtyType { get; set; }
                [XmlIgnore]
                public bool QtyTypeSpecified { get { return QtyType.HasValue; } }
                public double? OrderQty { get; set; }
                [XmlIgnore]
                public bool OrderQtySpecified { get { return OrderQty.HasValue; } }
                public double? CashOrderQty { get; set; }
                [XmlIgnore]
                public bool CashOrderQtySpecified { get { return CashOrderQty.HasValue; } }
                public double? OrderPercent { get; set; }
                [XmlIgnore]
                public bool OrderPercentSpecified { get { return OrderPercent.HasValue; } }
                public string RoundingDirection { get; set; }
                public double? RoundingModulus { get; set; }
                [XmlIgnore]
                public bool RoundingModulusSpecified { get { return RoundingModulus.HasValue; } }
                public double? Commission { get; set; }
                [XmlIgnore]
                public bool CommissionSpecified { get { return Commission.HasValue; } }
                public string CommType { get; set; }
                public string CommCurrency { get; set; }
                public string FundRenewWaiv { get; set; }
                public string OrderCapacity { get; set; }
                public string OrderRestrictions { get; set; }
                public int? CustOrderCapacity { get; set; }
                [XmlIgnore]
                public bool CustOrderCapacitySpecified { get { return CustOrderCapacity.HasValue; } }
                public string ForexReq { get; set; }
                public string SettlCurrency { get; set; }
                public int? BookingType { get; set; }
                [XmlIgnore]
                public bool BookingTypeSpecified { get { return BookingType.HasValue; } }
                public string Text { get; set; }
                public uint? EncodedTextLen { get; set; }
                [XmlIgnore]
                public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
                public string EncodedText { get; set; }
                public string PositionEffect { get; set; }
                public int? CoveredOrUncovered { get; set; }
                [XmlIgnore]
                public bool CoveredOrUncoveredSpecified { get { return CoveredOrUncovered.HasValue; } }
                public string CashMargin { get; set; }
                public string ClearingFeeIndicator { get; set; }
                public string SolicitedFlag { get; set; }
                public string SideComplianceID { get; set; }
            
                public partial class PartyID
                {
                
                    [XmlElement("PartyID")]
                    public string Id { get; set; }
                    public string PartyIDSource { get; set; }
                    public int? PartyRole { get; set; }
                    [XmlIgnore]
                    public bool PartyRoleSpecified { get { return PartyRole.HasValue; } }
                    [XmlArray("NoPartySubIDs")]
                    public PartySubID[] NoPartySubIDs { get; set; }
                
                    public partial class PartySubID
                    {
                    
                        [XmlElement("PartySubID")]
                        public string Id { get; set; }
                        public int? PartySubIDType { get; set; }
                        [XmlIgnore]
                        public bool PartySubIDTypeSpecified { get { return PartySubIDType.HasValue; } }
                    
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
                    [XmlArray("NoNestedPartyIDs")]
                    public NestedPartyID[] NoNestedPartyIDs { get; set; }
                    public double? AllocQty { get; set; }
                    [XmlIgnore]
                    public bool AllocQtySpecified { get { return AllocQty.HasValue; } }
                
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
            }

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

            public partial class Underlying
            {
            
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
            
                public partial class LegSecurityAltID
                {
                
                    [XmlElement("LegSecurityAltID")]
                    public string Id { get; set; }
                    public string LegSecurityAltIDSource { get; set; }
                
                }
            }

            public partial class TradingSession
            {
            
                public string TradingSessionID { get; set; }
                public string TradingSessionSubID { get; set; }
            
            }

            public partial class Stipulation
            {
            
                public string StipulationType { get; set; }
                public string StipulationValue { get; set; }
            
            }
        }
    }
}
