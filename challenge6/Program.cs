using System;
using System.IO;

namespace challenge6{
    class Program{
        public static void Main(string[] args){
            string filePath = "./words.txt";

            FileAddSomeLines(filePath);
            
        }
        static void FileAddSomeLines(string file)
        {
            Console.WriteLine("----- ADD LINES -----");
            string phrase = Console.ReadLine();
            File.AppendAllText(file, "\n");
            File.AppendAllText(file, phrase);
        }
    }
}