using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Batch {
    /// <summary>
    /// Defines a batch from Captricity
    /// </summary>
    [DataContract]
    public class Batch : ApiResource {
        public Batch() {
            this.Documents = new List<Document>();
        }

        #region Properties
        /// <summary>
        /// The current status of this batch. Possible values: 
        /// "setup" (batch is being set up), 
        /// "processing" (batch has been submitted for processing.), 
        /// "converting-to-job" (batch is being converted to a job), 
        /// "sorting" (batch is being sorted), 
        /// "processed" (batch has been processed), 
        /// "rejected" (batch has been rejected), 
        /// "magic-inbox-setup" (Magic Inbox is being setup), 
        /// "magic-inbox-submitted" (Magic Inbox has been submitted), 
        /// "magic-inbox-processing" (Magic Inbox is being processed)
        /// </summary>
        [DataMember(Name = "status" )]
        public string status { get; set; }

        /// <summary>
        /// Return all of the IDs of the child batches.
        /// </summary>
        [DataMember(Name = "children_id")]
        public List<int> ChildrenIDs { get; set; }

        /// <summary>
        /// The documents that this batch can match against.
        /// </summary>
        [DataMember(Name = "documents")]
        public List<Document> Documents { get; set; }

        /// <summary>
        /// The name of this batch (editable via PUT)
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Automatic timestamp of resource creation.
        /// </summary>
        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The email from where the last uploaded file in this batch came from.
        /// </summary>
        [DataMember(Name = "last_emailed_by")]
        public string LastEmailedBy { get; set; }

        /// <summary>
        /// The full name of the user who created this batch.
        /// </summary>
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

        public Price Price { get; set; }

        #endregion Properties
    }
}
