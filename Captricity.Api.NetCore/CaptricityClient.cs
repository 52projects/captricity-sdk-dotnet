using System.Collections.Generic;

namespace Captricity.Api.NetCore {
    public class CaptricityClient {
        private const string _apiUrl = "https://shreddr.captricity.com/api";
        private Dictionary<string, string> _headers;

        #region ApiSets
        private Captricity.Api.NetCore.Sets.BatchSet _batches = null;
        public Captricity.Api.NetCore.Sets.BatchSet Batches {
            get {
                if (_batches == null) {
                    _batches = new Sets.BatchSet(_headers, _apiUrl);
                }

                return _batches;
            }
        }

        private Captricity.Api.NetCore.Sets.BatchFileSet _batchFiles = null;
        public Captricity.Api.NetCore.Sets.BatchFileSet BatchFiles {
            get {
                if (_batchFiles == null) {
                    _batchFiles = new Sets.BatchFileSet(_headers, _apiUrl);
                }

                return _batchFiles;
            }
        }

        private Captricity.Api.NetCore.Sets.JobSet _jobs = null;
        public Captricity.Api.NetCore.Sets.JobSet Jobs {
            get {
                if (_jobs == null) {
                    _jobs = new Sets.JobSet(_headers, _apiUrl);
                }

                return _jobs;
            }
        }

        private Captricity.Api.NetCore.Sets.InstanceSet _instances = null;
        public Captricity.Api.NetCore.Sets.InstanceSet InstanceSets {
            get {
                if (_instances == null) {
                    _instances = new Sets.InstanceSet(_headers, _apiUrl);
                }

                return _instances;
            }
        }

        private Captricity.Api.NetCore.Sets.ShredSet _shreds = null;
        public Captricity.Api.NetCore.Sets.ShredSet Shreds {
            get {
                if (_shreds == null) {
                    _shreds = new Sets.ShredSet(_headers, _apiUrl);
                }

                return _shreds;
            }
        }


        private Captricity.Api.NetCore.Sets.DocumentSet _documents = null;
        public Captricity.Api.NetCore.Sets.DocumentSet Documents {
            get {
                if (_documents == null) {
                    _documents = new Sets.DocumentSet(_headers, _apiUrl);
                }

                return _documents;
            }
        }

        private Captricity.Api.NetCore.Sets.SheetSet _sheets = null;
        public Captricity.Api.NetCore.Sets.SheetSet Sheets {
            get {
                if (_sheets == null) {
                    _sheets = new Sets.SheetSet(_headers, _apiUrl);
                }

                return _sheets;
            }
        }


        private Captricity.Api.NetCore.Sets.FieldSet _fields = null;
        public Captricity.Api.NetCore.Sets.FieldSet Fields {
            get {
                if (_fields == null) {
                    _fields = new Sets.FieldSet(_headers, _apiUrl);
                }

                return _fields;
            }
        }


        private Captricity.Api.NetCore.Sets.BoxSet _boxes = null;
        public Captricity.Api.NetCore.Sets.BoxSet Boxes {
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
        public CaptricityClient(string apiToken, string userAgent) {
            _headers = new Dictionary<string,string>();
            _headers.Add("User-Agent", userAgent);
            _headers.Add("Captricity-API-Token", apiToken);
        }
    }
}
