// This is a generated file.  Don't edit it directly!

using System.Xml.Serialization;

namespace Oath.Domain.Schema
{
    namespace FIX44Bloomberg 
    {
        public class AllocationReportAck : Message
        {
            [XmlAttribute("msgType")]
            public string MsgType { get { return "AT"; } set {} }

            public string AllocReportID { get; set; }
            public string AllocID { get; set; }
            [XmlArray("NoPartyIDs")]
            public PartyID[] NoPartyIDs { get; set; }
            public string SecondaryAllocID { get; set; }
            public string TradeDate { get; set; }
            public string TransactTime { get; set; }
            public int? AllocStatus { get; set; }
            [XmlIgnore]
            public bool AllocStatusSpecified { get { return AllocStatus.HasValue; } }
            public int? AllocRejCode { get; set; }
            [XmlIgnore]
            public bool AllocRejCodeSpecified { get { return AllocRejCode.HasValue; } }
            public int? AllocReportType { get; set; }
            [XmlIgnore]
            public bool AllocReportTypeSpecified { get { return AllocReportType.HasValue; } }
            public int? AllocIntermedReqType { get; set; }
            [XmlIgnore]
            public bool AllocIntermedReqTypeSpecified { get { return AllocIntermedReqType.HasValue; } }
            public string MatchStatus { get; set; }
            public int? Product { get; set; }
            [XmlIgnore]
            public bool ProductSpecified { get { return Product.HasValue; } }
            public string SecurityType { get; set; }
            public string Text { get; set; }
            public uint? EncodedTextLen { get; set; }
            [XmlIgnore]
            public bool EncodedTextLenSpecified { get { return EncodedTextLen.HasValue; } }
            public string EncodedText { get; set; }
            [XmlArray("NoAllocs")]
            public Alloc[] NoAllocs { get; set; }

            public partial class PartyID
            {
            
                [XmlElement("PartyID")]
                public string Id { get; set; }
                public string PartyIDSource { get; set; }
                public int? PartyRole { get; set; }
                [XmlIgnore]
                public bool PartyRoleSpecified { get { return PartyRole.HasValue; } }
                [XmlArray("NoPartySubIDs")]
                public PartySubID[] NoPartySubIDs { get; set; }
            
                public partial class PartySubID
                {
                
                    [XmlElement("PartySubID")]
                    public string Id { get; set; }
                    public int? PartySubIDType { get; set; }
                    [XmlIgnore]
                    public bool PartySubIDTypeSpecified { get { return PartySubIDType.HasValue; } }
                
                }
            }

            public partial class Alloc
            {
            
                public string AllocAccount { get; set; }
                public int? AllocAcctIDSource { get; set; }
                [XmlIgnore]
                public bool AllocAcctIDSourceSpecified { get { return AllocAcctIDSource.HasValue; } }
                public double? AllocPrice { get; set; }
                [XmlIgnore]
                public bool AllocPriceSpecified { get { return AllocPrice.HasValue; } }
                public string IndividualAllocID { get; set; }
                public int? IndividualAllocRejCode { get; set; }
                [XmlIgnore]
                public bool IndividualAllocRejCodeSpecified { get { return IndividualAllocRejCode.HasValue; } }
                public string AllocText { get; set; }
                public uint? EncodedAllocTextLen { get; set; }
                [XmlIgnore]
                public bool EncodedAllocTextLenSpecified { get { return EncodedAllocTextLen.HasValue; } }
                public string EncodedAllocText { get; set; }
            
            }
        }
    }
}
