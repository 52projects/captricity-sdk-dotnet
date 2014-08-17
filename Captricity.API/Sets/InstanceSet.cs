﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model;
using RestSharp;

namespace Captricity.API.Sets {
    public class InstanceSet : ApiSet<Captricity.API.Model.InstanceSet> {
        private const string CHILD_LIST_URL = "/v1/job/{0}/instance-set";
        private const string GET_URL = "/v1/instance-set/{0}";
        private const string CHILD_URL = "/v1/instance-set/{0}/instance";
        private const string INSTANCE_URL = "/v1/instance/{0}";

        public InstanceSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }

        public List<Instance> GetInstancesetInstances(int id) {
            return base.ListBySuffixUrl<Instance>(string.Format(CHILD_URL, id));
        }

        public Instance GetInstance(int id) {
            return base.GetBySuffixUrl<Instance>(string.Format(INSTANCE_URL, id));
        }
    }
}
