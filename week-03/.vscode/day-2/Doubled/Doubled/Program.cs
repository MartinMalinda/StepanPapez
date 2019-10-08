using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 

            Decrypt(@"../../../duplicated-chars.txt", @"../../../decrypted.txt");
        }
        static void Decrypt(string decryptFrom, string copyTo)
        {
            try
            {
                string[] contents = File.ReadAllLines(decryptFrom);

                foreach (var line in contents)
                {
                    char[] charArrays = line.ToCharArray;
                    //File.WriteAllLines(copyTo, contents);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
