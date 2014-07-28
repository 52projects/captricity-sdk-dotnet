using RestSharp;
using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captricity.API {
    public class Client {
        private const string _apiUrl = "https://shreddr.captricity.com/api";
        
        private readonly string _apiToken;
        private readonly string _userAgent;
        private readonly RestClient _client;

        public Client() {
            _apiToken = ConfigurationManager.AppSettings["Captricity.API.Token"];
            _userAgent = ConfigurationManager.AppSettings["Captricity.API.UserAgent"];
            _client = new RestClient(_apiUrl);
        }

        internal T Go<T>(string url, Method method, T data = null) where T : class, new() {
            var request = new RestRequest(url, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("User-Agent", _userAgent);
            request.AddHeader("Captricity-API-Token", _apiToken);

            if (data != null) {
                request.AddBody(data);
            }

            var response = _client.Execute<T>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                return response.Data;
            }

            throw new Exception(string.Format("Response from {0} {1} was {2}", method, url, response.Content));
        }

        public System.Collections.Generic.List<T> List<T>() where T : ApiResource, new() {
            var obj = new T();

            if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.List)) {
                throw new Exception("List actiom not allowed.");
            }

            return Go<System.Collections.Generic.List<T>>(obj.ResourceDefinition.ListUrl, Method.GET);
        }

        public T Post<T>(T data) where T : ApiResource, new() {
            var obj = new T();

            if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Post)) {
                throw new Exception("Post actiom not allowed.");
            }

            return Go<T>(data.ResourceDefinition.ListUrl, Method.POST);
        }

        public T Put<T>(T data) where T : ApiResource, new() {
            var obj = new T();

            if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Put)) {
                throw new Exception("Put actiom not allowed.");
            }

            return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, data.ID), Method.PUT);
        }

        public T Get<T>(int id) where T : ApiResource, new() {
            var obj = new T();

            if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Get)) {
                throw new Exception("Get actiom not allowed.");
            }

            return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, id), Method.GET);
        }

        public T Delete<T>(int id) where T : ApiResource, new() {
            var obj = new T();

            if (!obj.ResourceDefinition.AllowedMethods.Contains(ApiResourceActions.Delete)) {
                throw new Exception("Delete actiom not allowed.");
            }

            return Go<T>(string.Format(obj.ResourceDefinition.SingleUrl, id), Method.DELETE);
        }

        public abstract class ApiResource {
            internal abstract ApiResourceDefinition ResourceDefinition { get; }
            public int ID { get; set; }
        }

        public enum ApiResourceActions {
            List, Get, Post, Put, Delete
        }

        internal abstract class ApiResourceDefinition {
            public abstract ApiResourceActions[] AllowedMethods { get; }
            public abstract string ListUrl { get; }
            public abstract string SingleUrl { get; }
        }

        internal class BatchDefinition : ApiResourceDefinition {
            public override ApiResourceActions[] AllowedMethods { get { return new ApiResourceActions[] { ApiResourceActions.List, ApiResourceActions.Get, ApiResourceActions.Post, ApiResourceActions.Put, ApiResourceActions.Delete }; } }
            public override string ListUrl { get { return "/v1/batch"; } }
            public override string SingleUrl { get { return "/v1/batch/{0}"; } }
        }

        public class Batch : ApiResource {
            internal override ApiResourceDefinition ResourceDefinition { get { return new BatchDefinition(); } }
        }

        //get, post, put, delete
    }
}
