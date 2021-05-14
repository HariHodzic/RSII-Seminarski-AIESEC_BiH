using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class FileModel:BaseEntity
    {
        public byte[] Data { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public virtual Report Report { get; set; }
    }
}
