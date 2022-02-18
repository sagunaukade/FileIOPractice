using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the file io operations");
            FileExists();
            BinaryOperation.BinarySerialize();
            BinaryOperation.binaryDeserialize();
        }
        public static void FileExists()
        {
            String path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOPractice\FileIOOperations\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File not exist");
                
            }
            Console.ReadLine();
        }
    }
}

