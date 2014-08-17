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
        private const string GET_URL = "/v1/instance-set/{0}";
        private const string CHILD_URL = "/v1/instance-set/{0}/instance";
        private const string SHRED_URL = "/v1/instance-set/{0}/shred";

        public InstanceSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }

        public List<Page> GetInstancePages(int id) {
            return base.ListBySuffixUrl<Page>(string.Format(CHILD_URL, id));
        }

    }
}
