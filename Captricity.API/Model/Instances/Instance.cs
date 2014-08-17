using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Instances {
    [DataContract]
    public class Instance : ApiResource {
        [DataMember(Name = "alignment_succeeded")]
        public bool AlignmentSucceeded { get; set; }

        [DataMember(Name = "instance_set_id")]
        public int InstanceSetID { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "modified")]
        public DateTime Modified { get; set; }

        [DataMember(Name = "image_url")]
        public string ImageUrl { get; set; }

        [DataMember(Name = "page_number")]
        public int PageNumber { get; set; }

        [DataMember(Name = "image_file")]
        public string ImageFile { get; set; }

        [DataMember(Name = "sheet_id")]
        public int SheetID { get; set; }
    }
}
