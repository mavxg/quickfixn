// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ListStatus : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "N"; } set {} }

            public string ListID { get; set; }
            public int? ListStatusType { get; set; }
            [XmlIgnore]
            public bool ListStatusTypeSpecified { get { return ListStatusType.HasValue; } }
            public string NoRpts { get; set; }
            public int? ListOrderStatus { get; set; }
            [XmlIgnore]
            public bool ListOrderStatusSpecified { get { return ListOrderStatus.HasValue; } }
            public int? RptSeq { get; set; }
            [XmlIgnore]
            public bool RptSeqSpecified { get { return RptSeq.HasValue; } }
            public string ListStatusText { get; set; }
            public uint? EncodedListStatusTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedListStatusTextLenSpecified { get { return EncodedListStatusTextLen.HasValue; } }
            public string EncodedListStatusText { get; set; }
            public string TransactTime { get; set; }
            public int? TotNoOrders { get; set; }
            [XmlIgnore]
            public bool TotNoOrdersSpecified { get { return TotNoOrders.HasValue; } }
            public string LastFragment { get; set; }
            [XmlArray("NoOrders")]
            public Order[] NoOrders { get; set; }

            public partial class Order
            {
            
                public string ClOrdID { get; set; }
                public string SecondaryClOrdID { get; set; }
                public double? CumQty { get; set; }
                [XmlIgnore]
                public bool CumQtySpecified { get { return CumQty.HasValue; } }
                public string OrdStatus { get; set; }
                public string WorkingIndicator { get; set; }
                public double? LeavesQty { get; set; }
                [XmlIgnore]
                public bool LeavesQtySpecified { get { return LeavesQty.HasValue; } }
                public double? CxlQty { get; set; }
                [XmlIgnore]
                public bool CxlQtySpecified { get { return CxlQty.HasValue; } }
                public double? AvgPx { get; set; }
                [XmlIgnore]
                public bool AvgPxSpecified { get { return AvgPx.HasValue; } }
                public int? OrdRejReason { get; set; }
                [XmlIgnore]
                public bool OrdRejReasonSpecified { get { return OrdRejReason.HasValue; } }
                public string Text { get; set; }
                public uint? EncodedTextLen { get; set; }
                [XmlIgnore]
                public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
                public string EncodedText { get; set; }
            
            }
        }
    }
}
