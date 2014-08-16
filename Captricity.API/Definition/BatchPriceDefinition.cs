using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captricity.API.Enum;

namespace Captricity.API.Definition {
    internal class BatchPriceDefinition : ApiResourceDefinition {
        public override ApiResourceActions[] AllowedMethods { get { return new ApiResourceActions[] { ApiResourceActions.Get }; } }
        public override string SingleUrl { get { return "/v1/batch/{0}/price"; } }
        public override string ListUrl { get { throw new NotImplementedException(); } }
    }
    
}
