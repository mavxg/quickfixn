// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class TestRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "1"; } set {} }

            public string TestReqID { get; set; }

        }
    }
}
