using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using Captricity.API;
using System.Configuration;
using System.Linq;

namespace Captricity.API.Tests.Integration.Batch {
    [TestFixture]
    public class JobTests {
        private Captricity.API.Client _client;

        [TestFixtureSetUp]
        public void Setup() {
            _client = new Client(ConfigurationManager.AppSettings["Captricity.API.Token"], ConfigurationManager.AppSettings["Captricity.API.UserAgent"]);
        }

        [Test]
        public void integration_job_list_jobs() {
            var jobs = _client.Jobs.List();
            jobs.ShouldNotBe(null);
        }

        [Test]
        public void integration_job_get_job() {
            var job = _client.Jobs.Get("69702");
            job.ShouldNotBe(null);
        }

        [Test]
        public void integration_job_get_csv() {
            var results = _client.Jobs.GetJobResults(60460);
            results.Count.ShouldBe(5);
        }
    }
}
