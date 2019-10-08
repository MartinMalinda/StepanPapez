using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            WriteName("Stepan Papez");
        }
        public static void WriteName(string name)
        {
            string path = @"../../../my-file.txt";
            try
            {
                File.WriteAllText(path, name);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}
