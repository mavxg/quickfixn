// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class ConfirmationRequest : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "BH"; } set {} }

            public string ConfirmReqID { get; set; }
            public int? ConfirmType { get; set; }
            [XmlIgnore]
            public bool ConfirmTypeSpecified { get { return ConfirmType.HasValue; } }
            [XmlArray("NoOrders")]
            public Order[] NoOrders { get; set; }
            public string AllocID { get; set; }
            public string SecondaryAllocID { get; set; }
            public string IndividualAllocID { get; set; }
            public string TransactTime { get; set; }
            public string AllocAccount { get; set; }
            public int? AllocAcctIDSource { get; set; }
            [XmlIgnore]
            public bool AllocAcctIDSourceSpecified { get { return AllocAcctIDSource.HasValue; } }
            public int? AllocAccountType { get; set; }
            [XmlIgnore]
            public bool AllocAccountTypeSpecified { get { return AllocAccountType.HasValue; } }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }

            public partial class Order
            {
            
                public string ClOrdID { get; set; }
                public string OrderID { get; set; }
                public string SecondaryOrderID { get; set; }
                public string SecondaryClOrdID { get; set; }
                public string ListID { get; set; }
                [XmlArray("NoNested2PartyIDs")]
                public Nested2PartyID[] NoNested2PartyIDs { get; set; }
                public double? OrderQty { get; set; }
                [XmlIgnore]
                public bool OrderQtySpecified { get { return OrderQty.HasValue; } }
                public double? OrderAvgPx { get; set; }
                [XmlIgnore]
                public bool OrderAvgPxSpecified { get { return OrderAvgPx.HasValue; } }
                public double? OrderBookingQty { get; set; }
                [XmlIgnore]
                public bool OrderBookingQtySpecified { get { return OrderBookingQty.HasValue; } }
            
                public partial class Nested2PartyID
                {
                
                    [XmlElement("Nested2PartyID")]
                    public string Id { get; set; }
                    public string Nested2PartyIDSource { get; set; }
                    public int? Nested2PartyRole { get; set; }
                    [XmlIgnore]
                    public bool Nested2PartyRoleSpecified { get { return Nested2PartyRole.HasValue; } }
                    [XmlArray("NoNested2PartySubIDs")]
                    public Nested2PartySubID[] NoNested2PartySubIDs { get; set; }
                
                    public partial class Nested2PartySubID
                    {
                    
                        [XmlElement("Nested2PartySubID")]
                        public string Id { get; set; }
                        public int? Nested2PartySubIDType { get; set; }
                        [XmlIgnore]
                        public bool Nested2PartySubIDTypeSpecified { get { return Nested2PartySubIDType.HasValue; } }
                    
                    }
                }
            }
        }
    }
}
