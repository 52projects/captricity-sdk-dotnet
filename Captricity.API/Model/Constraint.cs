using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract]
    public class Constraint : ApiResource {
        [DataMember(Name = "data_type")]
        public string DataType { get; set; }

        [DataMember(Name = "field_id")]
        public int FieldID { get; set; }

        [DataMember(Name = "maximum")]
        public string Maximum { get; set; }

        [DataMember(Name = "minimum")]
        public string Minimum { get; set; }

        [DataMember(Name = "characters")]
        public string characters { get; set; }

        [DataMember(Name = "maximum_length")]
        public string MaximumLength { get; set; }

        [DataMember(Name = "categories")]
        public string Categories { get; set; }
    }
}
