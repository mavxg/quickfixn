// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class SettlementInstructionRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "AV"; } set {} }

            public string SettlInstReqID { get; set; }
            public string TransactTime { get; set; }
            [XmlArray("NoPartyIDs")]
            public PartyID[] NoPartyIDs { get; set; }
            public string AllocAccount { get; set; }
            public int? AllocAcctIDSource { get; set; }
            [XmlIgnore]
            public bool AllocAcctIDSourceSpecified { get { return AllocAcctIDSource.HasValue; } }
            public string Side { get; set; }
            public int? Product { get; set; }
            [XmlIgnore]
            public bool ProductSpecified { get { return Product.HasValue; } }
            public string SecurityType { get; set; }
            public string CFICode { get; set; }
            public string EffectiveTime { get; set; }
            public string ExpireTime { get; set; }
            public string LastUpdateTime { get; set; }
            public int? StandInstDbType { get; set; }
            [XmlIgnore]
            public bool StandInstDbTypeSpecified { get { return StandInstDbType.HasValue; } }
            public string StandInstDbName { get; set; }
            public string StandInstDbID { get; set; }

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
        }
    }
}
