using System.Runtime.Serialization;
using Captricity.API.Definition;

namespace Captricity.API.Model {
    public abstract class ApiResource {
        internal abstract ApiResourceDefinition ResourceDefinition { get; }
        [DataMember(Name = "id")]
        public int ID { get; set; }
    }
}
