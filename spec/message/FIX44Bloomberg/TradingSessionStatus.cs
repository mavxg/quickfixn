// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class TradingSessionStatus : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "h"; } set {} }

            public string TradSesReqID { get; set; }
            public string TradingSessionID { get; set; }
            public string TradingSessionSubID { get; set; }
            public int? TradSesMethod { get; set; }
            [XmlIgnore]
            public bool TradSesMethodSpecified { get { return TradSesMethod.HasValue; } }
            public int? TradSesMode { get; set; }
            [XmlIgnore]
            public bool TradSesModeSpecified { get { return TradSesMode.HasValue; } }
            public string UnsolicitedIndicator { get; set; }
            public int? TradSesStatus { get; set; }
            [XmlIgnore]
            public bool TradSesStatusSpecified { get { return TradSesStatus.HasValue; } }
            public int? TradSesStatusRejReason { get; set; }
            [XmlIgnore]
            public bool TradSesStatusRejReasonSpecified { get { return TradSesStatusRejReason.HasValue; } }
            public string TradSesStartTime { get; set; }
            public string TradSesOpenTime { get; set; }
            public string TradSesPreCloseTime { get; set; }
            public string TradSesCloseTime { get; set; }
            public string TradSesEndTime { get; set; }
            public double? TotalVolumeTraded { get; set; }
            [XmlIgnore]
            public bool TotalVolumeTradedSpecified { get { return TotalVolumeTraded.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

        }
    }
}
