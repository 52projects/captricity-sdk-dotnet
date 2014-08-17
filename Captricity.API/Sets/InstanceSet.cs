using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model.Instances;
using RestSharp;

namespace Captricity.API.Sets {
    public class InstanceSet : ApiSet<Instance> {
        private const string CHILD_LIST_URL = "/v1/job/{0}/instance-set";
        private const string LIST_URL = "/v1/job/{0}/instance-set";
        private const string GET_URL = "/v1/batch/{0}";
        private const string SUBMIT_URL = "/v1/batch/{0}/submit";
        private const string PRICE_URL = "/v1/batch/{0}/price";
        private const string READINESS_URL = "/v1/batch/{0}/readiness";

        public InstanceSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
    }
}
