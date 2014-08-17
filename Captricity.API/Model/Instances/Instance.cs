using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Instances {
    [DataContract]
    public class Instance : ApiResource {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "extra_pages_settings")]
        public string ExtraPagesSettings { get; set; }

        [DataMember(Name = "modified")]
        public DateTime Modified { get; set; }

        [DataMember(Name = "instance_count")]
        public int InstanceCount { get; set; }

        [DataMember(Name = "sheet_count")]
        public int SheetCount { get; set; }

        [DataMember(Name = "multipage_file")]
        public string MultipageFile { get; set; }
    }
}
