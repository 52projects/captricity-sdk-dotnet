using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Captricity.Api.NetCore.Model {
    [DataContract(Name = "sheet")]
    public class Sheet {
        [DataMember(Name = "version_number")]
        public int VersionNumber { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime? CreatedDateTime { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? ModifiedDateTime { get; set; }

        [DataMember(Name = "page_number")]
        public int PageNumber { get; set; }

        [DataMember(Name = "image_file")]
        public string ImageFile { get; set; }

        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "document_id")]
        public int DocumentID { get; set; }

        [DataMember(Name = "fields")]
        public List<Field> Fields { get; set; }
    }
}
