using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captricity.API.Model;
using RestSharp;
using Captricity.API.Exceptions;

namespace Captricity.API.Sets {
    public class BatchSet : ApiSet<Batch> {
        private const string LIST_URL = "/v1/batch";
        private const string GET_URL = "/v1/batch/{0}";
        private const string SUBMIT_URL = "/v1/batch/{0}/submit";
        private const string PRICE_URL = "/v1/batch/{0}/price";
        private const string READINESS_URL = "/v1/batch/{0}/readiness";
        private const string CREATE_URL = "/v1/batch/";

        public BatchSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }

        public Batch Get(int id, bool includePrice = false) {
            var batch = base.Get(id.ToString());

            if (includePrice) {
                batch.Price = base.GetBySuffixUrl<Price>(string.Format(PRICE_URL, batch.ID));
            }

            return batch;
        }

        public Readiness GetBatchReadiness(string id) {
            try {
                return base.GetBySuffixUrl<Readiness>(string.Format(READINESS_URL, id));
            }
            catch (ApiAccessException e) {
                if (e.StatusDescription == "NOT FOUND") {
                    return null;
                }
            }
            catch (Exception e) {
                throw;
            }

            return null;
        }

        public object SubmitBatch(int id) {
            var response = base.Post(string.Format(SUBMIT_URL, id));

            var batch = Newtonsoft.Json.JsonConvert.DeserializeObject<Batch>(response.Content);

            if (batch.RelatedJobID > 0) {
                return batch;
            }
            else {
                var readiness = Newtonsoft.Json.JsonConvert.DeserializeObject<Readiness>(response.Content);
                return readiness;
            }
        }
    }
}