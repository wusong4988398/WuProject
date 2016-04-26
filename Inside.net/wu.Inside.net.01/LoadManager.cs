using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wu.Inside.net._01
{
    class LoadManager
    {
        private IList<Files> files=new List<Files>();

        public IList<Files> Files
        {
            get { return files; }
        }

        public void LoadFiles(Files file)
        {
            files.Add(file);
        }

        public void OpenAllFiles()
        {
            foreach (var file in Files)
            {
                file.Open();
            }
        }
        /// <summary>
        /// 打开单个资料
        /// </summary>
        /// <param name="file"></param>
        public void OpenFile(IFileOpen file)
        {
            file.Open();
        }
        //获取文件类型
        public FileType GetFileType(string filename)
        {
            FileInfo fi=new FileInfo(filename);
            return (FileType) Enum.Parse(typeof (FileType), fi.Extension);
        }
    }
}
