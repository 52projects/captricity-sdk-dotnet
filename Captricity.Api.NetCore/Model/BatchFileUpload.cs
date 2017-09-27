using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Captricity.Api.NetCore.Model {
    [DataContract]
    public class BatchFileUpload {
        [DataMember(Name = "uploaded_file")]
        public byte[] UploadedFile { get; set; }
        public string FileName { get; set; }
        public string BatchID { get; set; }
    }
}
