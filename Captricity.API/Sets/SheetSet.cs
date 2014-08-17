﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;
using Captricity.API.Model;
using RestSharp;

namespace Captricity.API.Sets {
    public class SheetSet : ApiSet<Document> {
        private const string GET_URL = "/v1/sheet/{0}";
        private const string CHILD_LIST_URL = "/v1/document/{0}/sheet";
        private const string CHILD_GET_URL = "/v1/document/{0}/sheet/{1}";

        public SheetSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
        protected override string GetChildUrl { get { return CHILD_GET_URL; } }
    }
}