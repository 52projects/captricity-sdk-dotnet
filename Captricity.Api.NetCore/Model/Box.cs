using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.Api.NetCore.Model {
    [DataContract]
    public class Box : ApiResource {
        [DataMember(Name = "y")]
        public decimal Y { get; set; }

        [DataMember(Name = "x")]
        public decimal X { get; set; }

        [DataMember(Name = "w")]
        public decimal W { get; set; }

        [DataMember(Name = "h")]
        public decimal H { get; set; }
    }
}
