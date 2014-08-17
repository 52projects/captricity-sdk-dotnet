using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract]
    public class BatchFile : ApiResource {
        [DataMember(Name = "reject_reason")]
        public string RejectReason { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "file_name")]
        public string FileName { get; set; }

        [DataMember(Name = "page_count")]
        public int PageCount { get; set; }

        [DataMember(Name = "batch")]
        public string Batch { get; set; }

        [DataMember(Name = "uploaded_with")]
        public string UploadedWith { get; set; }

        [DataMember(Name = "emailed_by")]
        public string EmailedBy { get; set; }

        [DataMember(Name = "uploaded_by")]
        public string UplaodedBy { get; set; }
    }
}
