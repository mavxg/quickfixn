// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class Heartbeat : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "0"; } set {} }

            public string TestReqID { get; set; }

        }
    }
}
