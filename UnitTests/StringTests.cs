using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using System.IO;
using System.Xml;

namespace UnitTests
{
    [TestFixture]
    public class StringTests
    {
        private QuickFix.IMessageFactory _defaultMsgFactory = new QuickFix.DefaultMessageFactory();

        public QuickFix.FIX44.TradeCaptureReport GenTradeCaptureReport()
        {
            var tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(new LastPx(9.9M));
            var sidesGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            sidesGrp.Side = new Side(Side.BUY);
            sidesGrp.Account = new Account("Piola");
            sidesGrp.OrderID = new OrderID("09011900");
            var partyIdsGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
            var xg = new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup();
            xg.LegCurrency = new LegCurrency("USD");
            partyIdsGrp.PartyID = new PartyID("Nesta13");
            partyIdsGrp.PartyRole = new PartyRole(PartyRole.EXECUTION_VENUE);
            sidesGrp.AddGroup(partyIdsGrp);
            tcr.AddGroup(xg);
            tcr.AddGroup(sidesGrp);
            return tcr;
        }

        private string TcrXml = "<TradeCaptureReport beginString=\"FIX.4.4\" msgType=\"AE\">\r\n  <LastPx>9.9</LastPx>\r\n  <NoLegs>\r\n    <Leg>\r\n      <LegCurrency>USD</LegCurrency>\r\n    </Leg>\r\n  </NoLegs>\r\n  <NoSides>\r\n    <Side>\r\n      <Side>1</Side>\r\n      <OrderID>09011900</OrderID>\r\n      <NoPartyIDs>\r\n        <PartyID>\r\n          <PartyID>Nesta13</PartyID>\r\n          <PartyRole>73</PartyRole>\r\n        </PartyID>\r\n      </NoPartyIDs>\r\n      <Account>Piola</Account>\r\n    </Side>\r\n  </NoSides>\r\n</TradeCaptureReport>";
        private string TcrXml2 = "<TradeCaptureReport beginString=\"FIX.4.4\" msgType=\"AE\"><LastPx>9.9</LastPx><NoLegs><Leg><LegCurrency>USD</LegCurrency></Leg></NoLegs><NoSides><Side><Side>1</Side><OrderID>09011900</OrderID><NoPartyIDs><PartyID><PartyID>Nesta13</PartyID><PartyRole>73</PartyRole></PartyID>\r\n      </NoPartyIDs>\r\n      <Account>Piola</Account>\r\n    </Side>\r\n  </NoSides>\r\n</TradeCaptureReport>";

        [Test]
        public void FieldOrderOutputTest()
        {
            var rest = GenTradeCaptureReport();
            var s = rest.ToString();
        }

        [Test]
        public void XmlSerializeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd44 = new QuickFix.DataDictionary.DataDictionary();
            dd44.Load("../../../spec/fix/FIX44Bloomberg.xml");

            var rest = GenTradeCaptureReport();
            var xset = new XmlWriterSettings() {
                OmitXmlDeclaration = true,
                Indent = true,
            };
            var sb = new StringBuilder();
            using (var xw = XmlWriter.Create(sb, xset)) {
                rest.Write(xw, dd44);
            }
            string s = sb.ToString();
            Assert.That(s, Is.EqualTo(TcrXml));
        }

        [Test]
        public void XmlDeserializeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd44 = new QuickFix.DataDictionary.DataDictionary();
            dd44.Load("../../../spec/fix/FIX44Bloomberg.xml");
            QuickFix.Message m = null;
            using (var sr = new StringReader(TcrXml2))
            using (var r = XmlReader.Create(sr)) {
                if (r.MoveToContent() == XmlNodeType.Element) {
                    Console.WriteLine(r.Name);
                    m = _defaultMsgFactory.Create(r["beginString"], r["msgType"]);
                    m.Read(r, dd44, _defaultMsgFactory);
                }
            }
            var rest = GenTradeCaptureReport();
            Assert.AreEqual(rest.ToString(), m.ToString());

        }
    }
}
