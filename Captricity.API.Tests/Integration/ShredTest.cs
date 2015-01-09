using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;

namespace Captricity.API.Tests.Integration.Shred {
    [TestFixture]
    public class ShredTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_shred_list_shreds_for_instance() {
            var jobs = _client.Jobs.List();
            var job = _client.Jobs.Get(jobs[0].ID.ToString());

            var instanceSets = _client.InstanceSets.List(job.ID.ToString());

            var shreds = _client.Shreds.List(instanceSets[0].ID.ToString());

            shreds.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_shred_get_shred_image() {
            var jobs = _client.Jobs.List();
            var job = _client.Jobs.Get(jobs[0].ID.ToString());

            var instanceSets = _client.InstanceSets.List(job.ID.ToString());

            var shreds = _client.Shreds.List(instanceSets[0].ID.ToString());

            var shhredImage = _client.Shreds.GetShredImage(shreds[0].ID);
        }
    }
}