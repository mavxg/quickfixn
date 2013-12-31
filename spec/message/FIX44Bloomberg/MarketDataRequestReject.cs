// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class MarketDataRequestReject : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "Y"; } set {} }

            public string MDReqID { get; set; }
            public string MDReqRejReason { get; set; }
            [XmlArray("NoAltMDSource")]
            public AltMDSource[] NoAltMDSource { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

            public partial class AltMDSource
            {
            
                public string AltMDSourceID { get; set; }
            
            }
        }
    }
}
