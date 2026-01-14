using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            string[] lines = { "First line", "Second line", "Third line" };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "test.txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }
}