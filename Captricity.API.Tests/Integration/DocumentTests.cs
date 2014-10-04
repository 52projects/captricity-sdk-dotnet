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

        [Test]
        public void integration_documents_create_blank_document() {
            var document = new Model.Document();
            document.Name = DateTime.UtcNow.Year.ToString() + DateTime.UtcNow.Month.ToString() + DateTime.UtcNow.Day.ToString() + DateTime.UtcNow.Hour.ToString() + DateTime.UtcNow.Minute.ToString() + DateTime.UtcNow.Second.ToString() + DateTime.UtcNow.Millisecond.ToString();
            document.UserVisible = true;

            var newDocument = _client.Documents.Create(document);

            newDocument.ID.ShouldBeGreaterThan(0);
        }

        //[Test]
        //public void integration_documents_update_blank_document_name() {
        //    var document = new Model.Document();
        //    document.Name = "test" + DateTime.UtcNow.Year.ToString() + DateTime.UtcNow.Month.ToString() + DateTime.UtcNow.Day.ToString() + DateTime.UtcNow.Hour.ToString() + DateTime.UtcNow.Minute.ToString() + DateTime.UtcNow.Second.ToString() + DateTime.UtcNow.Millisecond.ToString();
        //    document.UserVisible = true;

        //    var newDocument = _client.Documents.Create(document);
        //    newDocument.Name = document.Name;

        //    var updatedDocument = _client.Documents.Update(newDocument, newDocument.ID.ToString());
        //    updatedDocument.Name.ShouldBe(document.Name);
        //}
    }
}
