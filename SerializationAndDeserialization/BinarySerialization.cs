using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    internal class BinarySerialization
    {
        public void Serialization()
        {
            Demo D = new Demo();
            FileStream filestream = new FileStream(@"C:\Users\ganes\source\repos\FELLOWSHIP\SerializationAndDeserialization\SerializationAndDeserialization\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, D);
            Console.ReadKey();
        }
    }
    public void Deserialization()
    {
        Demo D = new Demo();
        FileStream filestream = new FileStream(@"C:\Users\ganes\source\repos\FELLOWSHIP\SerializationAndDeserialization\SerializationAndDeserialization\Example.txt", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        Demo DeserializedSampleDemo = (Demo)formatter.Deserialize(filestream);
        Console.WriteLine($"ApplicationName{ DeserializedSampleDemo.ApplicationName}------ ApplicationId { DeserializedSampleDemo.ApplicationId}");
        Console.ReadKey();

    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}



   