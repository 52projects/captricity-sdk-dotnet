using Captricity.API.Enum;

namespace Captricity.API.Definition {
    internal class BatchDefinition : ApiResourceDefinition {
        public override ApiResourceActions[] AllowedMethods { get { return new ApiResourceActions[] { ApiResourceActions.List, ApiResourceActions.Get, ApiResourceActions.Post, ApiResourceActions.Put, ApiResourceActions.Delete }; } }
        public override string ListUrl { get { return "/v1/batch"; } }
        public override string SingleUrl { get { return "/v1/batch/{0}"; } }
        public string SubmitUrl { get { return "/v1/batch/{0}/submit"; } }
    }
}
