using System.Runtime.Serialization;

namespace Captricity.Api.NetCore.Model {
    public abstract class ApiResource {
        [DataMember(Name = "id")]
        public int ID { get; set; }
    }
}
