﻿using System.Collections.Generic;
using Captricity.Api.NetCore.Model;
using System.Threading.Tasks;

namespace Captricity.Api.NetCore.Sets {
    public class SheetSet : ApiSet<Sheet> {
        private const string GET_URL = "/v1/sheet/{0}";
        private const string CHILD_LIST_URL = "/v1/document/{0}/sheet";
        private const string CHILD_GET_URL = "/v1/document/{0}/sheet/{1}";
        private const string UPLOAD_SHEET_URL = "/v1/document/{0}/sheet/";

        public SheetSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
        protected override string GetChildUrl { get { return CHILD_GET_URL; } }

        public Task<Sheet> CreateAsync(SheetFileUpload sheetImage) {
            var sheetUrl = string.Format("{0}{1}", base.BaseUrl, string.Format(UPLOAD_SHEET_URL, sheetImage.DocumentID));
            return CreateAsync(sheetImage.UploadedFile, sheetUrl, "image_file", sheetImage.FileName);
        }
    }
}