using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOpertions
{
    public class FileOperations
    {
        public void fileExits()
        {
            //provide file path
            string path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exits");
            }
            Console.ReadKey();

        }
        public void readAllLines()
        {
            string path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\Sample.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }
        public void readAllText()
        {
            string path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\Sample.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public void fileCopy()
        {
            string path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\Sample.txt";
            string copypath = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\SampleNew.txt";
            File.Copy(path, copypath);
        }
        public void deleteFile()
        {
            string path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOOpertions\FileIOOpertions\Sample.txt";
            File.Delete(path);
        }
    }
}
    
