using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Captricity.API.Model {
    [DataContract(Name = "version")]
    public class Version {
        [DataMember(Name = "document_name")]
        public string DocumentName { get; set; }

        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "document_id")]
        public int DocumentID { get; set; }

        [DataMember(Name = "number")]
        public int Number { get; set; }
    }
}
