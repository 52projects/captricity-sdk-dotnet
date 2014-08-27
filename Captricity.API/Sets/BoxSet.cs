using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model;
using RestSharp;
namespace Captricity.API.Sets {
   public  class BoxSet : ApiSet<Box> {
               private const string LIST_URL = "/v1/box";
        private const string GET_URL = "/v1/box/{0}";
        private const string SUBMIT_URL = "/v1/batch/{0}/submit";
        private const string PRICE_URL = "/v1/batch/{0}/price";
        private const string READINESS_URL = "/v1/batch/{0}/readiness";

        public BoxSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }
    }
}
