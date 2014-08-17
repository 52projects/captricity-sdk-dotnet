using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model.Job;
using RestSharp;

namespace Captricity.API.Sets {
    public class JobSet : ApiSet<Job> {
        private const string LIST_URL = "/v1/job";
        private const string GET_URL = "/v1/job/{0}";
        private const string RESULTS_URL = "/v1/job/{0}/csv";

        public JobSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }

        public string GetJobResults(int id) {
            var reuslts = GetBySuffixUrl(string.Format(RESULTS_URL, id));
            return reuslts;
        }
    }
}
