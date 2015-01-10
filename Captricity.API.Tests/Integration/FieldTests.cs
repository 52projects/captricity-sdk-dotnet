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
    public class FieldTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_fields_get_fields_for_sheet() {
            var fields = _client.Fields.List("75851");

            fields.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_fields_get_field_for_sheet() {
            var documents = _client.Documents.List();
            var sheets = _client.Sheets.List(documents[0].ID.ToString());
            var fields = _client.Fields.List(sheets[0].ID.ToString());
            var field = _client.Fields.Get(sheets[0].ID.ToString(), fields[0].ID.ToString());

            field.ShouldNotBe(null);
        }

        [Test]
        public void integration_fields_create_field_for_sheet() {
            var sheets = _client.Sheets.List("32789");
            var sheet = sheets[0];

            var field = new Captricity.API.Model.Field() {
                FriendlyName = "Short text",
                WidgetType = "Textfield",
                DataType = "String",
                Name = "Untitled1",
                SheetID = sheet.ID
            };
            field.Box = new Box {
                H = .05674m,
                W = .5667865m,
                X = .02765m,
                Y = .5762m
            };

            field = _client.Fields.Create(sheet.ID, field);
            field.ID.ShouldBeGreaterThan(0);
        }
    }
}
