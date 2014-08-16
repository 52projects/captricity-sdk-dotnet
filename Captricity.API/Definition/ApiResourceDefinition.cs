using Captricity.API.Enum;

namespace Captricity.API.Definition {
    internal abstract class ApiResourceDefinition {
        public abstract ApiResourceActions[] AllowedMethods { get; }
        public abstract string ListUrl { get; }
        public abstract string SingleUrl { get; }
    }
}
