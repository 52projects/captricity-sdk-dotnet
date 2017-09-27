using System.Collections.Generic;
using Captricity.Api.NetCore.Model;

namespace Captricity.Api.NetCore.Sets {
    public class BoxSet : ApiSet<Box> {
        private const string LIST_URL = "/v1/box";
        private const string GET_URL = "/v1/box/{0}";

        public BoxSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }
        protected override string EditUrl { get { return GET_URL; } }
    }
}
