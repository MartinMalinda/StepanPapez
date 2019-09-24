using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            CopyFile(@"../../../source-file.txt", @"../../../target-file.txt");
        }
        static void CopyFile(string copyFrom, string copyTo)
        {
            try
            {
                string[] contents = File.ReadAllLines(copyFrom);

                foreach (var line in contents)
                {
                    File.WriteAllLines(copyTo, contents);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }

            bool doesTargetExist = File.Exists(copyTo);
            if (doesTargetExist == true)
            {
                Console.WriteLine("Copied successfully");
            }
            else
            {
                Console.WriteLine("Copying went wrong");
            }
        }
    }
}
