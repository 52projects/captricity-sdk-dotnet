using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;
using Captricity.API.Model;
using System.IO;

namespace Captricity.API.Tests.Integration {
    [TestFixture]
    public class BoxTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_boxes_get_box() {
            var documents = _client.Documents.List();
            var document = _client.Documents.Get(documents[0].ID, true);

            var box = _client.Boxes.Get(document.Sheets[0].Fields[0].Box.ID.ToString());
            box.ShouldNotBe(null);
        }
    }
}
