using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model;
using RestSharp;

namespace Captricity.API.Sets {
    public class JobSet : ApiSet<Job> {
        private const string LIST_URL = "/v1/job";
        private const string GET_URL = "/v1/job/{0}";
        private const string RESULTS_URL = "/v1/job/{0}/csv";

        public JobSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }

        /// <summary>
        /// Attempts to retrieve the job results. If successful the first item in the array is the header
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<List<string>> GetJobResults(int id) {
            var resultList = new List<List<string>>();
            var results = GetBySuffixUrl(string.Format(RESULTS_URL, id));

            if (!string.IsNullOrEmpty(results)) {
                var resultSplit = results.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                resultList.Add(resultSplit[0].Split(',').ToList());

                for (int i = 1; i < resultSplit.Length; i++) {
                    if (!string.IsNullOrEmpty(resultSplit[i])) {
                        List<string> splitterWord = new List<string>();
                        var rowFields = resultSplit[i];

                        int fieldStart = 0;
                        for (int j = 0; j < rowFields.Length; j++) {
                            if (rowFields[j] == ',') {
                                splitterWord.Add(rowFields.Substring(fieldStart, j - fieldStart).Trim());
                                fieldStart = j + 1;
                            }
                            if (rowFields[j] == '"')
                                for (j++; rowFields[j] != '"'; j++) { }
                        }

                        if (fieldStart < rowFields.Length) {
                            splitterWord.Add(rowFields.Substring(fieldStart));
                        }
                        resultList.Add(splitterWord);
                    }
                }
            }

            return resultList;
        }
    }
}
