// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class RegistrationInstructions : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "o"; } set {} }

            public string RegistID { get; set; }
            public string RegistTransType { get; set; }
            public string RegistRefID { get; set; }
            public string ClOrdID { get; set; }
            [XmlArray("NoPartyIDs")]
            public PartyID[] NoPartyIDs { get; set; }
            public string Account { get; set; }
            public int? AcctIDSource { get; set; }
            [XmlIgnore]
            public bool AcctIDSourceSpecified { get { return AcctIDSource.HasValue; } }
            public string RegistAcctType { get; set; }
            public int? TaxAdvantageType { get; set; }
            [XmlIgnore]
            public bool TaxAdvantageTypeSpecified { get { return TaxAdvantageType.HasValue; } }
            public string OwnershipType { get; set; }
            [XmlArray("NoRegistDtls")]
            public RegistDtl[] NoRegistDtls { get; set; }
            [XmlArray("NoDistribInsts")]
            public DistribInst[] NoDistribInsts { get; set; }

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

            public partial class RegistDtl
            {
            
                public string RegistDtls { get; set; }
                public string RegistEmail { get; set; }
                public string MailingDtls { get; set; }
                public string MailingInst { get; set; }
                [XmlArray("NoNestedPartyIDs")]
                public NestedPartyID[] NoNestedPartyIDs { get; set; }
                public int? OwnerType { get; set; }
                [XmlIgnore]
                public bool OwnerTypeSpecified { get { return OwnerType.HasValue; } }
                public string DateOfBirth { get; set; }
                public string InvestorCountryOfResidence { get; set; }
            
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

            public partial class DistribInst
            {
            
                public int? DistribPaymentMethod { get; set; }
                [XmlIgnore]
                public bool DistribPaymentMethodSpecified { get { return DistribPaymentMethod.HasValue; } }
                public double? DistribPercentage { get; set; }
                [XmlIgnore]
                public bool DistribPercentageSpecified { get { return DistribPercentage.HasValue; } }
                public string CashDistribCurr { get; set; }
                public string CashDistribAgentName { get; set; }
                public string CashDistribAgentCode { get; set; }
                public string CashDistribAgentAcctNumber { get; set; }
                public string CashDistribPayRef { get; set; }
                public string CashDistribAgentAcctName { get; set; }
            
            }
        }
    }
}
