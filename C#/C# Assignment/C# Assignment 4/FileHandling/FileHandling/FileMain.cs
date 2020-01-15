using System;
using System.IO;
using System.Linq;

namespace FileHandling {

    class FileMain {

        // this main fuction perform all the operation of file system
        static void Main(string[] args) {
            string dirName;
            FileCreation fileInut = new FileCreation();
            dirName=fileInut.GetData();
            FileTest fileDemo = new FileTest();
            
            fileDemo.TxtFiles(dirName);
            fileDemo.CountExtension(dirName);
            fileDemo.TopFiveFiles(dirName);
            fileDemo.MaxLength(dirName);
        }
    }
}