// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class Logon : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "A"; } set {} }

            public int? EncryptMethod { get; set; }
            [XmlIgnore]
            public bool EncryptMethodSpecified { get { return EncryptMethod.HasValue; } }
            public int? HeartBtInt { get; set; }
            [XmlIgnore]
            public bool HeartBtIntSpecified { get { return HeartBtInt.HasValue; } }
            public uint? RawDataLength { get; set; }
            [XmlIgnore]
            public bool RawDataLengthSpecified { get { return RawDataLength.HasValue; } }
            public string RawData { get; set; }
            public string ResetSeqNumFlag { get; set; }
            public uint? NextExpectedMsgSeqNum { get; set; }
            [XmlIgnore]
            public bool NextExpectedMsgSeqNumSpecified { get { return NextExpectedMsgSeqNum.HasValue; } }
            public uint? MaxMessageSize { get; set; }
            [XmlIgnore]
            public bool MaxMessageSizeSpecified { get { return MaxMessageSize.HasValue; } }
            [XmlArray("NoMsgTypes")]
            public MsgType[] NoMsgTypes { get; set; }
            public string TestMessageIndicator { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public partial class MsgType
            {
            
                public string RefMsgType { get; set; }
                public string MsgDirection { get; set; }
            
            }
        }
    }
}
