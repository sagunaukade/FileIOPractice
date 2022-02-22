using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOpertions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the basic io operations");
            FileOperations fileoperation = new FileOperations();
            fileoperation.fileExits();
            fileoperation.readAllLines();
            fileoperation.readAllText();
            fileoperation.fileCopy();
            StreamReaderWriterOp stream = new StreamReaderWriterOp();
            stream.ReadFromStreamReader();
            stream.WriteFromStreamWriter();
            Console.ReadKey();
        }
    }
}
