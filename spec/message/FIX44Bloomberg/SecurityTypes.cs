// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class SecurityTypes : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "w"; } set {} }

            public string SecurityReqID { get; set; }
            public string SecurityResponseID { get; set; }
            public int? SecurityResponseType { get; set; }
            [XmlIgnore]
            public bool SecurityResponseTypeSpecified { get { return SecurityResponseType.HasValue; } }
            public int? TotNoSecurityTypes { get; set; }
            [XmlIgnore]
            public bool TotNoSecurityTypesSpecified { get { return TotNoSecurityTypes.HasValue; } }
            public string LastFragment { get; set; }
            [XmlArray("NoSecurityTypes")]
            public SecurityType[] NoSecurityTypes { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            public string TradingSessionID { get; set; }
            public string TradingSessionSubID { get; set; }
            public string SubscriptionRequestType { get; set; }

            public partial class SecurityType
            {
            
                [XmlElement("SecurityType")]
                public string Id { get; set; }
                public string SecuritySubType { get; set; }
                public int? Product { get; set; }
                [XmlIgnore]
                public bool ProductSpecified { get { return Product.HasValue; } }
                public string CFICode { get; set; }
            
            }
        }
    }
}
