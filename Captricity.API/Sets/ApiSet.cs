using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captricity.API.Model;

namespace Captricity.API {
    public abstract class ApiSet<T> : BaseApiSet<T> where T : new() {
        public ApiSet(string baseUrl, ContentType contentType)
            : base(baseUrl, contentType) {
        }

        public ApiSet(OAuthTicket ticket, string baseUrl, ContentType contentType)
            : base(ticket, baseUrl, contentType) {
        }

        public ApiSet(IDictionary<string, string> requestHeaders, string baseUrl, ContentType contentType)
            : base(requestHeaders, baseUrl, contentType) {
        }
    }
}