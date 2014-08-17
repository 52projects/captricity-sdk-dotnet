using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.API.Model.Batch {
    [DataContract]
    public class BatchFileUpload {
        [DataMember(Name = "uploaded_file")]
        public byte[] UploadedFile { get; set; }
        public string FileName { get; set; }
    }
}
