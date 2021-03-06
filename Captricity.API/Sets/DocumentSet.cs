﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captricity.API.Model;
using RestSharp;

namespace Captricity.API.Sets {
    public class DocumentSet : ApiSet<Document> {
        private const string LIST_URL = "/v1/document";
        private const string GET_URL = "/v1/document/{0}";
        private const string GET_DETAILS_URL = "/v1/document/{0}/deep/";
        private const string CREATE_URL = "/v1/document/";
        private const string EDIT_URL = "/v1/document/{0}";

        public DocumentSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get {return LIST_URL;  } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }

        public Document Get(int id, bool includeDetails = true) {
            var url = string.Format(includeDetails ? GET_DETAILS_URL : GET_URL, id);
            return base.GetBySuffixUrl<Document>(url);
        }
    }
}
