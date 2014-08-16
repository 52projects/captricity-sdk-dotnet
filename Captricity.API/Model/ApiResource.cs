using System.Runtime.Serialization;

namespace Captricity.API.Model {
    public abstract class ApiResource {
        [DataMember(Name = "id")]
        public int ID { get; set; }
    }
}
