using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model.Batch;

namespace Captricity.API.Sets {
    public class BatchSet : ApiSet<Batch> {
        private const string LIST_URL = "/v1/batch";
        private const string GET_URL = "/v1/batch/{0}";
        private const string SUBMIT_URL = "/v1/batch/{0}/submit";
        private const string PRICE_URL = "/v1/batch/{0}/price";
        private const string READINESS_URL = "/v1/batch/{0}/readiness";

        public BatchSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }

        public Batch Get(int id, bool includePrice = false) {
            var batch = base.Get(id.ToString());

            if (includePrice) {
                batch.Price = base.GetBySuffixUrl<Price>(string.Format(PRICE_URL, batch.ID));
            }

            return batch;
        }

        public Readiness GetBatchReadiness(int id) {
            return base.GetBySuffixUrl<Readiness>(string.Format(READINESS_URL, id.ToString()));
        }
    }
}