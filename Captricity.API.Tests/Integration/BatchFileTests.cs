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

namespace Captricity.API.Tests.Integration.Batch {
    [TestFixture]
    public class BatchFileTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_batch_files_list_files() {
            var batches = _client.Batches.List();
            var batchFiles = _client.BatchFiles.List(batches[0].ID.ToString());
        }

        [Test]
        public void integration_batch_files_upload_file() {
            var batches = _client.Batches.List();
            var batchFile = new BatchFileUpload();

            using (FileStream fileStream = new FileStream(@"D:\dev\captricity-api-wrapper\Captricity.API.Tests\testfile.pdf", FileMode.Open, FileAccess.Read)) {
                using (var memory = new MemoryStream()) {
                    fileStream.CopyTo(memory);
                    batchFile.UploadedFile = memory.ToArray();

                    _client.BatchFiles.Create(batches[0].ID, memory, "testcard.pdf");
                }
            }
        }
    }
}
