using System;
using System.IO;

namespace challenge7{
    class Program{
        static void Main(string[] args) {
            string filePath = "../challenge6/words.txt";

            FileReadAllText(filePath);
        }
        static void FileReadAllText(string file)
        {
            Console.WriteLine("----- Words Stored in text file -----");
            string myFileContents = File.ReadAllText(file);
            Console.WriteLine(myFileContents);
        }
    }
}