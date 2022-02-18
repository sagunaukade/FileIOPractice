using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class BinaryOperation
    {
        public static String path = @"C:\Users\ganes\source\repos\FELLOWSHIP\FileIOPractice\FileIOOperations\FileIOOperations\BinaryData.txt";

        public static void BinarySerialize()
        {
            Student stud = new Student() { FName = "Saguna", LName = "Ukade", Address = "bnglr", ZipCode = 405565 };
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, stud);
            Console.WriteLine("Binary Serialize");
            stream.Close();
        }
        public static void binaryDeserialize()
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            Student stud = (Student)binary.Deserialize(stream);
            Console.WriteLine("Binary Deserialize");
            Console.WriteLine(stud.Tostring());
            stream.Close();

        }
    }
}
[Serializable]
      public class Student
      {
         public string FName { get; set; }
         public string LName { get; set; }
         public string Address { get; set; }
         public int ZipCode { get; set; }
         public string Tostring()
         {
         return $"{FName} {LName} {Address} {ZipCode}";
         }
      }
