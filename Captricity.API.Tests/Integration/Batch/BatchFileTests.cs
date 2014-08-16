﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;

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
        public void integration_batches_get_batch() {
            var batches = _client.Batches.List();
            var batch = _client.Batches.Get(batches[0].ID.ToString());

            batch.Name.ShouldBe(batches[0].Name);
        }

        [Test]
        public void integration_batches_get_batch_price() {
            var batches = _client.Batches.List();
            var batch = _client.Batches.Get(batches[0].ID, true);

            batch.Price.TotalBatchCostInFields.ShouldBe(80);
            batch.Price.UserSubscriptionFieldsPerMonth.ShouldBe(200);
        }

        [Test]
        public void integration_batches_submit_batch() {

        }

        [Test]
        public void integration_bateches_get_readiness() {
            var batches = _client.Batches.List();
            var readiness = _client.Batches.GetBatchReadiness(batches[0].ID);

            readiness.ShouldNotBe(null);
        }
    }
}
