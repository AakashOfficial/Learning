using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileHandling {

    class FileCreation {

        int numberOfFiles;
        string fileText,  dirName;

        public string GetData() { 

            Console.WriteLine("Enter the name of directory");
            dirName = Console.ReadLine();
            // Checking if string is empty or not 
            if (dirName != String.Empty) {
                // Creating the Directory 
                Directory.CreateDirectory(dirName);
                // Checking Directory is created 
                // Successfully or not 
                if (Directory.Exists(dirName)) {
                    Console.WriteLine("The directory was created!");
                    Console.WriteLine("Please enter a Number of files you want to insert in the current Directory:");
                    numberOfFiles = Convert.ToInt32(Console.ReadLine());

                    for (int number = 1; number <= numberOfFiles; number++) {
                        string fileName;
                        Console.WriteLine("Enter the Name of file with their extension file  " + number );
                        fileName = Console.ReadLine();
                        Console.WriteLine("Please Enter the data for : " + fileName + "  File  ");
                        fileText = Console.ReadLine();

                        //string FilePath = DirPath;
                        if (fileName != string.Empty) {
                            File.WriteAllText(Path.Combine(dirName, fileName), fileText);

                            if (File.Exists(fileName)) {
                                Console.WriteLine("File Created");
                            }
                        }
                    }
                }
            }
            return dirName;
        }
    }
}