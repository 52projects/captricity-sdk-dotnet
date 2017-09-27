using System.Collections.Generic;
using Captricity.Api.NetCore.Model;
using System.Threading.Tasks;


namespace Captricity.Api.NetCore.Sets {
    public class ShredSet : ApiSet<Shred> {
        private const string CHILD_LIST_URL = "/v1/instance-set/{0}/shred/";
        private const string GET_URL = "/v1/shred/{0}";
        private const string IMAGE_URL = "/v1/shred/{0}/image";

        public ShredSet(IDictionary<string, string> headers, string baseURl) : base(headers, baseURl, ContentType.JSON) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL;}}

        public async Task<List<Shred>> ListAsync(int instanceSetID) {
            return await ListBySuffixUrlAsync<Shred>(string.Format(CHILD_LIST_URL, instanceSetID));
        }

        public  byte[] GetShredImage(int id) {
            return base.GetByteArray(string.Format(IMAGE_URL, id));
        }
    }
}