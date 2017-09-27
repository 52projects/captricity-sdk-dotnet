using System.Collections.Generic;
using Captricity.Api.NetCore.Model;
using System.Threading.Tasks;

namespace Captricity.Api.NetCore.Sets {
    public class BatchFileSet : ApiSet<BatchFile> {
        private const string GET_CHILD_LIST_URL = "/v1/batch/{0}/batch-file/";
        private const string GET_URL = "/v1/batch-file/{0}";
        private const string UPLOAD_BATCH_FILE_URL = "/v1/batch/{0}/batch-file/";
        private const string EDIT_URL = "/v1/batch-file/{0}";

        public BatchFileSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return GET_CHILD_LIST_URL; } }
        protected override string EditUrl {  get { return EDIT_URL;  } }

        public Task<BatchFile> CreateAsync(BatchFileUpload batchFile) {
            var batchFileUrl = string.Format("{0}{1}", base.BaseUrl, string.Format(UPLOAD_BATCH_FILE_URL, batchFile.BatchID));
            return CreateAsync(batchFile.UploadedFile, batchFileUrl, "uploaded_file", batchFile.FileName);
        }
    }
}
