using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model;
using System.IO;

namespace Captricity.API.Sets {
    public class BatchFileSet : ApiSet<BatchFile> {
        private const string GET_CHILD_LIST_URL = "/v1/batch/{0}/batch-file";
        private const string GET_URL = "/v1/batch-file/{0}";

        public BatchFileSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return GET_CHILD_LIST_URL; } }

        public bool Create(int batchID, Stream file, string fileName) {
            return base.Create(file,  string.Format("{0}{1}", base.BaseUrl, string.Format(GET_CHILD_LIST_URL, batchID)), "uploaded_file", fileName);
        }
    }
}
