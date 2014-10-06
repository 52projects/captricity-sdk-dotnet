using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;
using System.IO;
using Captricity.API.Model;

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
            var sheets = _client.Sheets.List("32789");

            sheets.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_sheets_upload_file() {
            var documents = _client.Documents.List();
            var sheetFile = new SheetFileUpload();

            using (FileStream fileStream = new FileStream(@"D:\dev\captricity-api-wrapper\Captricity.API.Tests\image.jpg", FileMode.Open, FileAccess.Read)) {
                using (var memory = new MemoryStream()) {
                    fileStream.CopyTo(memory);
                    sheetFile.UploadedFile = memory.ToArray();
                    sheetFile.DocumentID = documents[0].ID;
                    sheetFile.FileName = Guid.NewGuid().ToString();

                    var sheet = _client.Sheets.Create(sheetFile);
                    sheet.ID.ShouldBeGreaterThan(0);
                }
            }
        }
    }
}