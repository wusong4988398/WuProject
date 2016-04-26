using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wu.Inside.net._01
{
    abstract class Files:IFileOpen
    {
        private  FileType fileType=FileType.Doc;

        public FileType FileType
        {
            get { return fileType; }
        }

        public abstract void Open();
    }
}
