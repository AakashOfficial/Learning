using System;
using System.IO;
using System.Linq;

namespace FileHandling {

    class FileTest {

        // this class calculate txt files ,no of files per extinsion and size
        string filename;
        int txtFileCount;
        public delegate void fileing();

        //method to calculate no of txt files
        public void TxtFiles(string dirName) {
            txtFileCount = Directory.GetFiles(Path.Combine(dirName), "*.txt").Length;
            Console.WriteLine("\nNo Of txt Files are :  " + txtFileCount);
        }

        //methd to check no of file per extension 
        public void CountExtension(string dirName) {
            string[] s = Directory.GetFiles(Path.Combine(dirName), "*.*");
            
            var egrp = s.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                       .GroupBy(x => x, (ext, extCnt) => new
                       {
                           Extension = ext,
                           Count = extCnt.Count()
                       });
            foreach (var v in egrp)
                Console.WriteLine("\n{0} File(s) with {1} Extension ",v.Count, v.Extension);
        }

        //fetch top five file on size
        public void TopFiveFiles(string dirName) {
            
            fileing f = delegate () {
               var files= Directory.EnumerateFiles(dirName, "*", SearchOption.TopDirectoryOnly).Select(x => new FileInfo(x))
                          .OrderByDescending(x => x.Length).Take(5).ToList();
                foreach (var temp in files)
                    Console.WriteLine("\n" + temp + "  " + temp.Length);
            };
        }

        //find max length of file
        public void MaxLength(string dirName) {

            string[] s = Directory.GetFiles(Path.Combine(dirName), "*.*");
            int check = 0;
            
            foreach (string name in s) {
                if (check < name.Length) {
                    check = name.Length;
                    filename = name;
                    Console.WriteLine(check);
                }
            }
            Console.WriteLine("\nmax lenfth file is " + filename + " with length " + check);
        }
    }
}