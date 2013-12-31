// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class UserResponse : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "BF"; } set {} }

            public string UserRequestID { get; set; }
            public string Username { get; set; }
            public int? UserStatus { get; set; }
            [XmlIgnore]
            public bool UserStatusSpecified { get { return UserStatus.HasValue; } }
            public string UserStatusText { get; set; }

        }
    }
}
