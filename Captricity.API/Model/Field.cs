using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract]
    public class Field : ApiResource {
        [DataMember(Name = "box")]
        public Box Box { get; set; }

        [DataMember(Name = "phone_constraint")]
        public bool PhoneConstraint { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "data_type")]
        public string DataType { get; set; }

        [DataMember(Name = "awaiting_rerun")]
        public bool AwaitingRerun { get; set; }

        [DataMember(Name = "range_constraint")]
        public string RangeConstraint { get; set; }

        [DataMember(Name = "friendly_name")]
        public string FriendlyName { get; set; }

        [DataMember(Name = "column_id")]
        public int ColumnID { get; set; }

        [DataMember(Name = "widget_type")]
        public string WidgetType { get; set; }

        [DataMember(Name = "constraint_characters")]
        public List<string> ConstraintCharacters { get; set; }

        [DataMember(Name = "formatting_type")]
        public string FormattingType { get; set; }
        [DataMember(Name = "shred_height")]
        public decimal ShredHeight { get; set; }
        [DataMember(Name = "is_redacted")]
        public bool IsRedacted { get; set; }
        [DataMember(Name = "maximum_length")]
        public string MaximumLength { get; set; }
        [DataMember(Name = "shred_width")]
        public string ShredWidth { get; set; }
        [DataMember(Name = "rerun_description")]
        public string RerunDescription { get; set; }
        [DataMember(Name = "instructions")]
        public string Instructions { get; set; }
        [DataMember(Name = "categorical_constraint")]
        public string CategoricalConstraint { get; set; }
        [DataMember(Name = "email_constraint")]
        public bool EmailConstraint { get; set; }
        [DataMember(Name = "constraints")]
        public List<Constraint> Constraints { get; set; }
    }
}
