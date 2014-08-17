using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;

namespace Captricity.API.Tests.Integration.Instance {
    [TestFixture]
    public class SheetTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_get_sheets_for_document() {
            var documents = _client.Documents.List();
            var sheets = _client.Sheets.List(documents[0].ID.ToString());

            sheets.Count.ShouldBeGreaterThan(0);
        }
    }
}