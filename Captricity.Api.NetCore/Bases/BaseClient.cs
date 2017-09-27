using System.Collections.Generic;

namespace Captricity.Api.NetCore {
    public class BaseClient {
        #region Properties
        public OAuthTicket Ticket { get; set; }
        public ContentType ContentType { get; set; }
        public string BaseUrl { get; set; }
        public IDictionary<string, string> RequestHeaders { get; set; }

        #endregion Properties

        #region Constructor
        public BaseClient(OAuthTicket ticket) {
        }

        public BaseClient(OAuthTicket ticket, string baseUrl) {
            this.Ticket = ticket;
            this.BaseUrl = baseUrl;
        }

        public BaseClient(IDictionary<string, string> requestHeaders, string baseUrl) {
            this.BaseUrl = BaseUrl;
            this.RequestHeaders = requestHeaders;
        }
        #endregion Constructor
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
