using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captricity.Api.NetCore.Model;

namespace Captricity.Api.NetCore {
    public abstract class ApiSet<T> : BaseApiSet<T> where T : new() {
        public ApiSet(string baseUrl, ContentType contentType)
            : base(baseUrl, contentType) {
        }

        public ApiSet(IDictionary<string, string> requestHeaders, string baseUrl, ContentType contentType)
            : base(requestHeaders, baseUrl, contentType) {
        }
    }
}