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
    public class InstanceTest {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_instances_get_instances_for_job() {
            var jobs = _client.Jobs.List();
            var job = _client.Jobs.Get(jobs[0].ID.ToString());

            var instances = _client.Instances.List(job.ID.ToString());
            instances.ShouldNotBe(null);
        }
    }
}
