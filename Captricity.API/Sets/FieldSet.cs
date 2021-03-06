﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captricity.API.Model;
using RestSharp;

namespace Captricity.API.Sets {
    public class FieldSet : ApiSet<Field> {
        private const string GET_URL = "/v1/field/{0}";
        private const string CHILD_LIST_URL = "/v1/sheet/{0}/field";
        private const string CHILD_GET_URL = "/v1/sheet/{0}/field/{1}";
        private const string CREATE_URL = "/v1/sheet/{0}/field/";

        public FieldSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
        protected override string GetChildUrl { get { return CHILD_GET_URL; } }
        protected override string EditUrl { get { return GET_URL; } }

        public Field Create(int sheetID, Field entity) {
            entity.SheetID = sheetID;
            return this.Create(entity, url: string.Format(CREATE_URL, sheetID));
        }
    }
}