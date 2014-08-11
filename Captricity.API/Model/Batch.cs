using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract]
    public class Batch : ApiResource {
        public Batch() {
            this.Documents = new List<Document>();
        }

        internal override ApiResourceDefinition ResourceDefinition { get { return new BatchDefinition(); } }

        #region Properties
        public string status { get; set; }
        [DataMember(Name = "children_id")]
        public List<int> ChildrenIDs { get; set; }

        [DataMember(Name = "documents")]
        public List<Document> Documents { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "last_emailed_by")]
        public string LastEmailedBy { get; set; }

        [DataMember(Name = "created_by")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "actionable")]
        public bool Actionable { get; set; }

        [DataMember(Name = "related_job_id")]
        public int RelatedJobID { get; set; }

        [DataMember(Name = "emailed_by")]
        public string EmailedBy { get; set; }

        [DataMember(Name = "file_count")]
        public int FileCount { get; set; }

        [DataMember(Name = "parent_id")]
        public int ParentID { get; set; }

        [DataMember(Name = "created_with")]
        public string CreatedWith { get; set; }

        [DataMember(Name = "last_uploaded_with")]
        public string LastUploadedWith { get; set; }

        [DataMember(Name = "sorting_enabled")]
        public bool SortingEnabled { get; set; }

        [DataMember(Name = "last_upload_date")]
        public DateTime LastUploadDate { get; set; }

        [DataMember(Name = "last_uploader")]
        public string LastUploader { get; set; }

        [DataMember(Name = "reject_reasons")]
        public List<string> RejectReasons { get; set; }

        #endregion Properties
    }
}
