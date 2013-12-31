// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class SettlementInstructions : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "T"; } set {} }

            public string SettlInstMsgID { get; set; }
            public string SettlInstReqID { get; set; }
            public string SettlInstMode { get; set; }
            public int? SettlInstReqRejCode { get; set; }
            [XmlIgnore]
            public bool SettlInstReqRejCodeSpecified { get { return SettlInstReqRejCode.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            public string SettlInstSource { get; set; }
            public string ClOrdID { get; set; }
            public string TransactTime { get; set; }
            [XmlArray("NoSettlInst")]
            public SettlInst[] NoSettlInst { get; set; }

            public partial class SettlInst
            {
            
                public string SettlInstID { get; set; }
                public string SettlInstTransType { get; set; }
                public string SettlInstRefID { get; set; }
                [XmlArray("NoPartyIDs")]
                public PartyID[] NoPartyIDs { get; set; }
                public string Side { get; set; }
                public int? Product { get; set; }
                [XmlIgnore]
                public bool ProductSpecified { get { return Product.HasValue; } }
                public string SecurityType { get; set; }
                public string CFICode { get; set; }
                public string EffectiveTime { get; set; }
                public string ExpireTime { get; set; }
                public string LastUpdateTime { get; set; }
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
                public int? PaymentMethod { get; set; }
                [XmlIgnore]
                public bool PaymentMethodSpecified { get { return PaymentMethod.HasValue; } }
                public string PaymentRef { get; set; }
                public string CardHolderName { get; set; }
                public string CardNumber { get; set; }
                public string CardStartDate { get; set; }
                public string CardExpDate { get; set; }
                public string CardIssNum { get; set; }
                public string PaymentDate { get; set; }
                public string PaymentRemitterID { get; set; }
            
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
            }
        }
    }
}
