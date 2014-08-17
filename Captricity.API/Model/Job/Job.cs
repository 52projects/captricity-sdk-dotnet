using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Job {
    [DataContract]
    public class Job : ApiResource {

        [DataMember(Name = "reviewed")]
        public bool Reviewed { get; set; }

        [DataMember(Name = "is_example")]
        public bool IsExample { get; set; }

        [DataMember(Name = "modified")]
        public DateTime Modified { get; set; }

        [DataMember(Name = "instanceSetCount")]
        public int InstanceSetCount { get; set; }

        [DataMember(Name = "has_fields_awaiting_rerun")]
        public bool HasFieldsAwaitingRerun { get; set; }

        [DataMember(Name = "user_id")]
        public int UserID { get; set; }

        [DataMember(Name = "finished_callback")]
        public string FinishedCallback { get; set; }

        [DataMember(Name = "row_count")]
        public int RowCount { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "started")]
        public DateTime Started { get; set; }

        [DataMember(Name = "document_rerunnable")]
        public bool DocumentRerunnable { get; set; }

        [DataMember(Name = "sheet_count")]
        public int SheetCount { get; set; }

        [DataMember(Name = "percent_completed")]
        public int PercentCompleted { get; set; }

        [DataMember(Name = "thumbnail_sheet_id")]
        public int ID { get; set; }

        [DataMember(Name = "document_id")]
        public int DocumentID { get; set; }

        [DataMember(Name = "document_active")]
        public bool DocumentActive { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "finished")]
        public DateTime Finished { get; set; }

        [DataMember(Name = "rerunnable")]
        public bool Rerunnable { get; set; }

        [DataMember(Name = "source_inbox_job")]
        public string SourceInboxJob { get; set; }

    }
}
