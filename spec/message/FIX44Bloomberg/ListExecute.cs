// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ListExecute : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "L"; } set {} }

            public string ListID { get; set; }
            public string ClientBidID { get; set; }
            public string BidID { get; set; }
            public string TransactTime { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
