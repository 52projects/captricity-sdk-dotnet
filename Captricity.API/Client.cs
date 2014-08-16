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

        #region ApiSets
        public Captricity.API.Sets.BatchSet Batches { get; set; }
        #endregion ApiSets

        /// <summary>
        /// Returned a client for calling Captricity API resources
        /// </summary>
        /// <param name="apiToken">The API token provided by Captricity</param>
        /// <param name="userAgent">The Application user agent found https://shreddr.captricity.com/developer </param>
        public Client(string apiToken, string userAgent) {
            Dictionary<string, string> headers = new Dictionary<string,string>();
            headers.Add("User-Agent", userAgent);
            headers.Add("Captricity-API-Token", apiToken);

            Batches = new Sets.BatchSet(headers, _apiUrl);
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
