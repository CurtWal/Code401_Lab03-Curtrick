using System;
using System.IO;

namespace challenge8
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filePath = "../challenge6/words.txt";

            FileReadAllText(filePath);
        }
        static void FileReadAllText(string file)
        {
            string str = File.ReadAllText(file);
            str = str.Replace("Add new line", "some other text");
            File.WriteAllText(file, str);
            Console.WriteLine($"Your old text has been replaced by: {str}");
        }
    }
}
