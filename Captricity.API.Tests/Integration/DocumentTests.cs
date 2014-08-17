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
    public class DocumentTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_documents_get_all_documents() {
            var documents = _client.Documents.List();
            documents.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_documents_get_single_document() {
            var documents = _client.Documents.List();
            var document = _client.Documents.Get(documents[0].ID.ToString());
            document.ShouldNotBe(null);
        }

        [Test]
        public void integration_documents_get_single_document_deep() {
            var documents = _client.Documents.List();
            var document = _client.Documents.Get(documents[0].ID);
            document.ShouldNotBe(null);
        }
    }
}
