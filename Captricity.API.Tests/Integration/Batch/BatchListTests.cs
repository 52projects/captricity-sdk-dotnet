using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;

namespace Captricity.API.Tests.Integration.Batch {
    [TestFixture]
    public class BatchListTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client();
        }

        [Test]
        public void integration_batches_list_batches() {
            var batches = _client.List<Captricity.API.Model.Batch>();

            batches.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_batches_get_batch() {
            var batches = _client.List<Captricity.API.Model.Batch>();

            var batch = _client.Get<Captricity.API.Model.Batch>(batches[0].ID);

            batch.Name.ShouldBe(batches[0].Name);
        }
    }
}
