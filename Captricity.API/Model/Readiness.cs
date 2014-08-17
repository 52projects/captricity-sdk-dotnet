using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract]
    public class Readiness {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "has_sheets")]
        public bool HasSheets { get; set; }

        [DataMember(Name = "errors")]
        public List<string> Errors { get; set; }

        [DataMember(Name = "has_empty_documents")]
        public bool HasEmptyDocuments { get; set; }

        [DataMember(Name = "warnings")]
        public List<string> Warnings { get; set; }

        [DataMember(Name = "is_downloading_from_third_party")]
        public bool IsDownloadingFromThirdParty { get; set; }

        [DataMember(Name = "has_sufficient_funds")]
        public bool HasSufficientFunds { get; set; }

        [DataMember(Name = "valid_page_count")]
        public bool ValidPageCount { get; set; }

        [DataMember(Name = "has_document")]
        public bool HasDocument { get; set; }

        [DataMember(Name = "has_sorting")]
        public bool HasSorting { get; set; }

        [DataMember(Name = "has_files")]
        public bool HasFiles { get; set; }
    }
}
