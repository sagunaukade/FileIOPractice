using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Serialization And Deserialization program ");
            BinarySerialization binary = new BinarySerialization();
            binary.Serialization();
            Console.ReadKey();
        }
    }
}
