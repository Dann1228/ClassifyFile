using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassfyFile
{
    public class FileSetting
    {
        public string DirectoryPath { get; set; }

        public string FilePath { get; set; }

        public string Extension { get; set; }

        public string ToListShow()
        {
            return  this.Extension + "\t" + this.DirectoryPath;
        }
    }
}
