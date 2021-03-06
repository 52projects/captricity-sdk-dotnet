﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captricity.API.Model;
using RestSharp;


namespace Captricity.API.Sets {
   public class ShredSet : ApiSet<Shred> {
        private const string CHILD_LIST_URL = "/v1/instance-set/{0}/shred/";
        private const string GET_URL = "/v1/shred/{0}";
        private const string IMAGE_URL = "/v1/shred/{0}/image";

        public ShredSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL;}}

        public List<Shred> List(int instanceSetID) {
            return base.ListBySuffixUrl<Shred>(string.Format(CHILD_LIST_URL, instanceSetID));
        }

        public  byte[] GetShredImage(int id) {
            return base.GetByteArray(string.Format(IMAGE_URL, id));
        }
    }
}