// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class TradingSessionStatusRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "g"; } set {} }

            public string TradSesReqID { get; set; }
            public string TradingSessionID { get; set; }
            public string TradingSessionSubID { get; set; }
            public int? TradSesMethod { get; set; }
            [XmlIgnore]
            public bool TradSesMethodSpecified { get { return TradSesMethod.HasValue; } }
            public int? TradSesMode { get; set; }
            [XmlIgnore]
            public bool TradSesModeSpecified { get { return TradSesMode.HasValue; } }
            public string SubscriptionRequestType { get; set; }

        }
    }
}
