// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class RegistrationInstructionsResponse : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "p"; } set {} }

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
            public string RegistStatus { get; set; }
            public int? RegistRejReasonCode { get; set; }
            [XmlIgnore]
            public bool RegistRejReasonCodeSpecified { get { return RegistRejReasonCode.HasValue; } }
            public string RegistRejReasonText { get; set; }

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
