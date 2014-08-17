using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Shreds {
    [DataContract]
    public class Shred : ApiResource {
        [DataMember(Name = "instance_set_id")]
        public int InstanceSetID { get; set; }

        [DataMember(Name = "ignored_in_error_display")]
        public bool IgnoredInErrorDisplay { get; set; }

        [DataMember(Name = "uuid")]
        public string UUID { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "modified")]
        public DateTime Modified { get; set; }

        [DataMember(Name = "instance_id")]
        public int InstanceID { get; set; }

        [DataMember(Name = "field")]
        public Field Field { get; set; }

        [DataMember(Name = "salesforce_export_error")]
        public string SalesforceExportError { get; set; }

        [DataMember(Name = "best_estimate")]
        public string BestEstimate { get; set; }

        [DataMember(Name = "salesforce_export_error_reason")]
        public string SalesforceExportErrorReason { get; set; }

        [DataMember(Name = "instance_set_name")]
        public string InstanceSetName { get; set; }
    }
}
