using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.Api.NetCore.Model {
    /// <summary>
    /// Defines a document definition from Captricity
    /// </summary>
    [DataContract(Name = "document")]
    public class Document {
        public Document() {
            this.Versions = new List<Version>();
        }

        [DataMember(Name = "read_only")]
        public bool ReadOnly { get; set; }

        [DataMember(Name = "user_id")]
        public int UserID { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime? Created {
            get;
            set;
        }

        [DataMember(Name = "extra_pages_settings")]
        public string ExtraPagesSettings { get; set; }

        [DataMember(Name = "user_visible")]
        public bool UserVisible { get; set; }

        [DataMember(Name = "sheet_count")]
        public int SheetCount { get; set; }

        [DataMember(Name = "modified")]
        public DateTime Modified { get; set; }

        [DataMember(Name = "versions")]
        public List<Version> Versions { get; set; }

        [DataMember(Name = "conversion_status")]
        public string ConversionStatus { get; set; }

        [DataMember(Name = "is_versioned")]
        public bool IsVersioned { get; set; }

        [DataMember(Name = "sheets")]
        public List<Sheet> Sheets { get; set; }

        [DataMember(Name = "active")]
        public bool Active { get; set; }

        [DataMember(Name = "self_entry")]
        public bool SelfEntry { get; set; }

        [DataMember(Name = "rerunnable")]
        public bool Rerunnable { get; set; }

        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "has_fields")]
        public bool HasFields { get; set; }
    }
}
