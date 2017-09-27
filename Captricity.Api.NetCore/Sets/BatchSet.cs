using System;
using System.Collections.Generic;
using Captricity.Api.NetCore.Model;
using Captricity.Api.NetCore.Exceptions;
using System.Threading.Tasks;
using System.Net.Http;

namespace Captricity.Api.NetCore.Sets {
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

        public async Task<Batch> GetAsync(int id, bool includePrice = false) {
            var batch = await GetAsync(id.ToString());

            if (includePrice) {
                batch.Price = await GetBySuffixUrlAsync<Price>(string.Format(PRICE_URL, batch.ID));
            }

            return batch;
        }

        public Task<Readiness> GetBatchReadinessAsync(string id) {
            try {
                return GetBySuffixUrlAsync<Readiness>(string.Format(READINESS_URL, id));
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

        public async Task<object> SubmitBatchAsync(int id, int? sla = null) {
            HttpResponseMessage response = null;

            if (sla.HasValue) {
                response = await PostAsync(string.Format(SUBMIT_URL, id), "{\"sla_in_seconds\": " + sla.Value + "}");
            }
            else {
                response = await PostAsync(string.Format(SUBMIT_URL, id));
            }

            var stringResults = await response.Content.ReadAsStringAsync();
            var batch = Newtonsoft.Json.JsonConvert.DeserializeObject<Batch>(stringResults);

            if (batch.RelatedJobID > 0) {
                return batch;
            }
            else {
                var readiness = Newtonsoft.Json.JsonConvert.DeserializeObject<Readiness>(stringResults);
                return readiness;
            }
        }
    }
}