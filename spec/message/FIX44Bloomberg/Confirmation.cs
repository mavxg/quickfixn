// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class Confirmation : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "AK"; } set {} }

            public string ConfirmID { get; set; }
            public string ConfirmRefID { get; set; }
            public string ConfirmReqID { get; set; }
            public int? ConfirmTransType { get; set; }
            [XmlIgnore]
            public bool ConfirmTransTypeSpecified { get { return ConfirmTransType.HasValue; } }
            public int? ConfirmType { get; set; }
            [XmlIgnore]
            public bool ConfirmTypeSpecified { get { return ConfirmType.HasValue; } }
            public string CopyMsgIndicator { get; set; }
            public string LegalConfirm { get; set; }
            public int? ConfirmStatus { get; set; }
            [XmlIgnore]
            public bool ConfirmStatusSpecified { get { return ConfirmStatus.HasValue; } }
            [XmlArray("NoPartyIDs")]
            public PartyID[] NoPartyIDs { get; set; }
            [XmlArray("NoOrders")]
            public Order[] NoOrders { get; set; }
            public string AllocID { get; set; }
            public string SecondaryAllocID { get; set; }
            public string IndividualAllocID { get; set; }
            public string TransactTime { get; set; }
            public string TradeDate { get; set; }
            [XmlArray("NoTrdRegTimestamps")]
            public TrdRegTimestamp[] NoTrdRegTimestamps { get; set; }
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
            public int? DeliveryForm { get; set; }
            [XmlIgnore]
            public bool DeliveryFormSpecified { get { return DeliveryForm.HasValue; } }
            public double? PctAtRisk { get; set; }
            [XmlIgnore]
            public bool PctAtRiskSpecified { get { return PctAtRisk.HasValue; } }
            [XmlArray("NoInstrAttrib")]
            public InstrAttrib[] NoInstrAttrib { get; set; }
            public string AgreementDesc { get; set; }
            public string AgreementID { get; set; }
            public string AgreementDate { get; set; }
            public string AgreementCurrency { get; set; }
            public int? TerminationType { get; set; }
            [XmlIgnore]
            public bool TerminationTypeSpecified { get { return TerminationType.HasValue; } }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int? DeliveryType { get; set; }
            [XmlIgnore]
            public bool DeliveryTypeSpecified { get { return DeliveryType.HasValue; } }
            public double? MarginRatio { get; set; }
            [XmlIgnore]
            public bool MarginRatioSpecified { get { return MarginRatio.HasValue; } }
            [XmlArray("NoUnderlyings")]
            public Underlying[] NoUnderlyings { get; set; }
            [XmlArray("NoLegs")]
            public Leg[] NoLegs { get; set; }
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
            public double? AllocQty { get; set; }
            [XmlIgnore]
            public bool AllocQtySpecified { get { return AllocQty.HasValue; } }
            public int? QtyType { get; set; }
            [XmlIgnore]
            public bool QtyTypeSpecified { get { return QtyType.HasValue; } }
            public string Side { get; set; }
            public string Currency { get; set; }
            public string LastMkt { get; set; }
            [XmlArray("NoCapacities")]
            public Capacitie[] NoCapacities { get; set; }
            public string AllocAccount { get; set; }
            public int? AllocAcctIDSource { get; set; }
            [XmlIgnore]
            public bool AllocAcctIDSourceSpecified { get { return AllocAcctIDSource.HasValue; } }
            public int? AllocAccountType { get; set; }
            [XmlIgnore]
            public bool AllocAccountTypeSpecified { get { return AllocAccountType.HasValue; } }
            public double? AvgPx { get; set; }
            [XmlIgnore]
            public bool AvgPxSpecified { get { return AvgPx.HasValue; } }
            public int? AvgPxPrecision { get; set; }
            [XmlIgnore]
            public bool AvgPxPrecisionSpecified { get { return AvgPxPrecision.HasValue; } }
            public int? PriceType { get; set; }
            [XmlIgnore]
            public bool PriceTypeSpecified { get { return PriceType.HasValue; } }
            public double? AvgParPx { get; set; }
            [XmlIgnore]
            public bool AvgParPxSpecified { get { return AvgParPx.HasValue; } }
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
            public double? ReportedPx { get; set; }
            [XmlIgnore]
            public bool ReportedPxSpecified { get { return ReportedPx.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            public string ProcessCode { get; set; }
            public double? GrossTradeAmt { get; set; }
            [XmlIgnore]
            public bool GrossTradeAmtSpecified { get { return GrossTradeAmt.HasValue; } }
            public int? NumDaysInterest { get; set; }
            [XmlIgnore]
            public bool NumDaysInterestSpecified { get { return NumDaysInterest.HasValue; } }
            public string ExDate { get; set; }
            public double? AccruedInterestRate { get; set; }
            [XmlIgnore]
            public bool AccruedInterestRateSpecified { get { return AccruedInterestRate.HasValue; } }
            public double? AccruedInterestAmt { get; set; }
            [XmlIgnore]
            public bool AccruedInterestAmtSpecified { get { return AccruedInterestAmt.HasValue; } }
            public double? InterestAtMaturity { get; set; }
            [XmlIgnore]
            public bool InterestAtMaturitySpecified { get { return InterestAtMaturity.HasValue; } }
            public double? EndAccruedInterestAmt { get; set; }
            [XmlIgnore]
            public bool EndAccruedInterestAmtSpecified { get { return EndAccruedInterestAmt.HasValue; } }
            public double? StartCash { get; set; }
            [XmlIgnore]
            public bool StartCashSpecified { get { return StartCash.HasValue; } }
            public double? EndCash { get; set; }
            [XmlIgnore]
            public bool EndCashSpecified { get { return EndCash.HasValue; } }
            public double? Concession { get; set; }
            [XmlIgnore]
            public bool ConcessionSpecified { get { return Concession.HasValue; } }
            public double? TotalTakedown { get; set; }
            [XmlIgnore]
            public bool TotalTakedownSpecified { get { return TotalTakedown.HasValue; } }
            public double? NetMoney { get; set; }
            [XmlIgnore]
            public bool NetMoneySpecified { get { return NetMoney.HasValue; } }
            public double? MaturityNetMoney { get; set; }
            [XmlIgnore]
            public bool MaturityNetMoneySpecified { get { return MaturityNetMoney.HasValue; } }
            public double? SettlCurrAmt { get; set; }
            [XmlIgnore]
            public bool SettlCurrAmtSpecified { get { return SettlCurrAmt.HasValue; } }
            public string SettlCurrency { get; set; }
            public double? SettlCurrFxRate { get; set; }
            [XmlIgnore]
            public bool SettlCurrFxRateSpecified { get { return SettlCurrFxRate.HasValue; } }
            public string SettlCurrFxRateCalc { get; set; }
            public string SettlType { get; set; }
            public string SettlDate { get; set; }
            public int? SettlDeliveryType { get; set; }
            [XmlIgnore]
            public bool SettlDeliveryTypeSpecified { get { return SettlDeliveryType.HasValue; } }
            public int? StandInstDbType { get; set; }
            [XmlIgnore]
            public bool StandInstDbTypeSpecified { get { return StandInstDbType.HasValue; } }
            public string StandInstDbName { get; set; }
            public string StandInstDbID { get; set; }
            [XmlArray("NoDlvyInst")]
            public DlvyInst[] NoDlvyInst { get; set; }
            public double? Commission { get; set; }
            [XmlIgnore]
            public bool CommissionSpecified { get { return Commission.HasValue; } }
            public string CommType { get; set; }
            public string CommCurrency { get; set; }
            public string FundRenewWaiv { get; set; }
            public double? SharedCommission { get; set; }
            [XmlIgnore]
            public bool SharedCommissionSpecified { get { return SharedCommission.HasValue; } }
            [XmlArray("NoStipulations")]
            public Stipulation[] NoStipulations { get; set; }
            [XmlArray("NoMiscFees")]
            public MiscFee[] NoMiscFees { get; set; }

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

            public partial class Order
            {
            
                public string ClOrdID { get; set; }
                public string OrderID { get; set; }
                public string SecondaryOrderID { get; set; }
                public string SecondaryClOrdID { get; set; }
                public string ListID { get; set; }
                [XmlArray("NoNested2PartyIDs")]
                public Nested2PartyID[] NoNested2PartyIDs { get; set; }
                public double? OrderQty { get; set; }
                [XmlIgnore]
                public bool OrderQtySpecified { get { return OrderQty.HasValue; } }
                public double? OrderAvgPx { get; set; }
                [XmlIgnore]
                public bool OrderAvgPxSpecified { get { return OrderAvgPx.HasValue; } }
                public double? OrderBookingQty { get; set; }
                [XmlIgnore]
                public bool OrderBookingQtySpecified { get { return OrderBookingQty.HasValue; } }
            
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

            public partial class TrdRegTimestamp
            {
            
                [XmlElement("TrdRegTimestamp")]
                public string Id { get; set; }
                public int? TrdRegTimestampType { get; set; }
                [XmlIgnore]
                public bool TrdRegTimestampTypeSpecified { get { return TrdRegTimestampType.HasValue; } }
                public string TrdRegTimestampOrigin { get; set; }
            
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

            public partial class InstrAttrib
            {
            
                public int? InstrAttribType { get; set; }
                [XmlIgnore]
                public bool InstrAttribTypeSpecified { get { return InstrAttribType.HasValue; } }
                public string InstrAttribValue { get; set; }
            
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

            public partial class Capacitie
            {
            
                public string OrderCapacity { get; set; }
                public string OrderRestrictions { get; set; }
                public double? OrderCapacityQty { get; set; }
                [XmlIgnore]
                public bool OrderCapacityQtySpecified { get { return OrderCapacityQty.HasValue; } }
            
            }

            public partial class DlvyInst
            {
            
                public string SettlInstSource { get; set; }
                public string DlvyInstType { get; set; }
                [XmlArray("NoSettlPartyIDs")]
                public SettlPartyID[] NoSettlPartyIDs { get; set; }
            
                public partial class SettlPartyID
                {
                
                    [XmlElement("SettlPartyID")]
                    public string Id { get; set; }
                    public string SettlPartyIDSource { get; set; }
                    public int? SettlPartyRole { get; set; }
                    [XmlIgnore]
                    public bool SettlPartyRoleSpecified { get { return SettlPartyRole.HasValue; } }
                    [XmlArray("NoSettlPartySubIDs")]
                    public SettlPartySubID[] NoSettlPartySubIDs { get; set; }
                
                    public partial class SettlPartySubID
                    {
                    
                        [XmlElement("SettlPartySubID")]
                        public string Id { get; set; }
                        public int? SettlPartySubIDType { get; set; }
                        [XmlIgnore]
                        public bool SettlPartySubIDTypeSpecified { get { return SettlPartySubIDType.HasValue; } }
                    
                    }
                }
            }

            public partial class Stipulation
            {
            
                public string StipulationType { get; set; }
                public string StipulationValue { get; set; }
            
            }

            public partial class MiscFee
            {
            
                public double? MiscFeeAmt { get; set; }
                [XmlIgnore]
                public bool MiscFeeAmtSpecified { get { return MiscFeeAmt.HasValue; } }
                public string MiscFeeCurr { get; set; }
                public string MiscFeeType { get; set; }
                public int? MiscFeeBasis { get; set; }
                [XmlIgnore]
                public bool MiscFeeBasisSpecified { get { return MiscFeeBasis.HasValue; } }
            
            }
        }
    }
}
