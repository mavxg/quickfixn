// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class UserRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "BE"; } set {} }

            public string UserRequestID { get; set; }
            public int? UserRequestType { get; set; }
            [XmlIgnore]
            public bool UserRequestTypeSpecified { get { return UserRequestType.HasValue; } }
            public string Username { get; set; }
            public string Password { get; set; }
            public string NewPassword { get; set; }
            public uint? RawDataLength { get; set; }
            [XmlIgnore]
            public bool RawDataLengthSpecified { get { return RawDataLength.HasValue; } }
            public string RawData { get; set; }

        }
    }
}
