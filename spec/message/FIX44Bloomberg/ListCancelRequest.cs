// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ListCancelRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "K"; } set {} }

            public string ListID { get; set; }
            public string TransactTime { get; set; }
            public string TradeOriginationDate { get; set; }
            public string TradeDate { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
