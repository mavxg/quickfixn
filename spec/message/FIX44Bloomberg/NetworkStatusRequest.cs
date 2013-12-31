// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class NetworkStatusRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "BC"; } set {} }

            public int? NetworkRequestType { get; set; }
            [XmlIgnore]
            public bool NetworkRequestTypeSpecified { get { return NetworkRequestType.HasValue; } }
            public string NetworkRequestID { get; set; }
            [XmlArray("NoCompIDs")]
            public CompID[] NoCompIDs { get; set; }

            public partial class CompID
            {
            
                public string RefCompID { get; set; }
                public string RefSubID { get; set; }
                public string LocationID { get; set; }
                public string DeskID { get; set; }
            
            }
        }
    }
}
