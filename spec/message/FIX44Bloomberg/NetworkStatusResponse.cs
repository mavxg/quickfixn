// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class NetworkStatusResponse : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "BD"; } set {} }

            public int? NetworkStatusResponseType { get; set; }
            [XmlIgnore]
            public bool NetworkStatusResponseTypeSpecified { get { return NetworkStatusResponseType.HasValue; } }
            public string NetworkRequestID { get; set; }
            public string NetworkResponseID { get; set; }
            public string LastNetworkResponseID { get; set; }
            [XmlArray("NoCompIDs")]
            public CompID[] NoCompIDs { get; set; }

            public partial class CompID
            {
            
                public string RefCompID { get; set; }
                public string RefSubID { get; set; }
                public string LocationID { get; set; }
                public string DeskID { get; set; }
                public int? StatusValue { get; set; }
                [XmlIgnore]
                public bool StatusValueSpecified { get { return StatusValue.HasValue; } }
                public string StatusText { get; set; }
            
            }
        }
    }
}
