using RestSharp;
using System;
using System.Configuration;
using System.Linq;
using Captricity.API.Model;
using Captricity.API.Enum;
using System.Collections.Generic;

namespace Captricity.API {
    public class Client {
        private const string _apiUrl = "https://shreddr.captricity.com/api";
        private Dictionary<string, string> _headers;

        #region ApiSets
        private Captricity.API.Sets.BatchSet _batches = null;
        public Captricity.API.Sets.BatchSet Batches {
            get {
                if (_batches == null) {
                    _batches = new Sets.BatchSet(_headers, _apiUrl);
                }

                return _batches;
            }
        }

        private Captricity.API.Sets.BatchFileSet _batchFiles = null;
        public Captricity.API.Sets.BatchFileSet BatchFiles {
            get {
                if (_batchFiles == null) {
                    _batchFiles = new Sets.BatchFileSet(_headers, _apiUrl);
                }

                return _batchFiles;
            }
        }

        private Captricity.API.Sets.JobSet _jobs = null;
        public Captricity.API.Sets.JobSet Jobs {
            get {
                if (_jobs == null) {
                    _jobs = new Sets.JobSet(_headers, _apiUrl);
                }

                return _jobs;
            }
        }

        private Captricity.API.Sets.InstanceSet _instances = null;
        public Captricity.API.Sets.InstanceSet InstanceSets {
            get {
                if (_instances == null) {
                    _instances = new Sets.InstanceSet(_headers, _apiUrl);
                }

                return _instances;
            }
        }

        private Captricity.API.Sets.ShredSet _shreds = null;
        public Captricity.API.Sets.ShredSet Shreds {
            get {
                if (_shreds == null) {
                    _shreds = new Sets.ShredSet(_headers, _apiUrl);
                }

                return _shreds;
            }
        }


        private Captricity.API.Sets.DocumentSet _documents = null;
        public Captricity.API.Sets.DocumentSet Documents {
            get {
                if (_documents == null) {
                    _documents = new Sets.DocumentSet(_headers, _apiUrl);
                }

                return _documents;
            }
        }

        private Captricity.API.Sets.SheetSet _sheets = null;
        public Captricity.API.Sets.SheetSet Sheets {
            get {
                if (_sheets == null) {
                    _sheets = new Sets.SheetSet(_headers, _apiUrl);
                }

                return _sheets;
            }
        }


        private Captricity.API.Sets.FieldSet _fields = null;
        public Captricity.API.Sets.FieldSet Fields {
            get {
                if (_fields == null) {
                    _fields = new Sets.FieldSet(_headers, _apiUrl);
                }

                return _fields;
            }
        }


        private Captricity.API.Sets.BoxSet _boxes = null;
        public Captricity.API.Sets.BoxSet Boxes {
            get {
                if (_boxes == null) {
                    _boxes = new Sets.BoxSet(_headers, _apiUrl);
                }

                return _boxes;
            }
        }
        #endregion ApiSets

        /// <summary>
        /// Returned a client for calling Captricity API resources
        /// </summary>
        /// <param name="apiToken">The API token provided by Captricity</param>
        /// <param name="userAgent">The Application user agent found https://shreddr.captricity.com/developer </param>
        public Client(string apiToken, string userAgent) {
            _headers = new Dictionary<string,string>();
            _headers.Add("User-Agent", userAgent);
            _headers.Add("Captricity-API-Token", apiToken);
        }

        #region Commented Methods
        //internal T Go<T>(string url, Method method, T data = null) where T : class, new() {
        //    var request = new RestRequest(url, method);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("User-Agent", _userAgent);
        //    request.AddHeader("Captricity-API-Token", _apiToken);

        //    if (data != null) {
        //        request.AddBody(data);
        //    }

        //    var response = _client.Execute<T>(request);

        //    if (response.StatusCode == System.Net.HttpStatusCode.OK) {
        //        return response.Data;
        //    }

        //    throw new Exception(string.Format("Response from {0} {1} was {2}", method, url, response.Content));
        //}

        //internal string Post<T>(string url, Method method, T data = null) where T : class, new() {
        //    var request = new RestRequest(url, method);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("User-Agent", _userAgent);
        //    request.AddHeader("Captricity-API-Token", _apiToken);

        //    if (data != null) {
        //        request.AddBody(data);
        //    }

        //    var response = _client.Execute<T>(request);

        //    if (response.StatusCode == System.Net.HttpStatusCode.OK) {
        //        return response.Content;
        //    }

        //    throw new Exception(string.Format("Response from {0} {1} was {2}", method, url, response.Content));
        //}

        //public System.Collections.Generic.List<T> List<T>() where T : ApiResource, new() {
        //    var obj = new T();

        //    if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.List)) {
        //        throw new Exception("List actiom not allowed.");
        //    }

        //    return Go<System.Collections.Generic.List<T>>(obj.ResourceDefinition.ListUrl, Method.GET);
        //}

        //public T Post<T>(T data) where T : ApiResource, new() {
        //    var obj = new T();

        //    if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Post)) {
        //        throw new Exception("Post actiom not allowed.");
        //    }

        //    return Go<T>(data.ResourceDefinition.ListUrl, Method.POST);
        //}

        //public string Post<T>(string url, T data = null) where T : class, new() {
        //    return Post<T>(url, Method.POST, data);
        //}

        //public T Put<T>(T data) where T : ApiResource, new() {
        //    var obj = new T();

        //    if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Put)) {
        //        throw new Exception("Put actiom not allowed.");
        //    }

        //    return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, data.ID), Method.PUT);
        //}

        //public T Get<T>(int id) where T : ApiResource, new() {
        //    var obj = new T();

        //    if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Get)) {
        //        throw new Exception("Get actiom not allowed.");
        //    }

        //    return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, id), Method.GET);
        //}

        //public T Delete<T>(int id) where T : ApiResource, new() {
        //    var obj = new T();

        //    if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Delete)) {
        //        throw new Exception("Delete actiom not allowed.");
        //    }

        //    return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, id), Method.DELETE);
        //}
        #endregion CommentedMethods
    }
}
