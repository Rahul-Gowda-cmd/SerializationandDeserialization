using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationandDeserialization
{
    class BinarySerilaization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\HP\csharp\SerializationandDeserialization\SerializationandDeserialization\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\HP\csharp\SerializationandDeserialization\SerializationandDeserialization\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }

        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; } = "Binary Serialize";
            public int ApplicationId { get; set; } = 1001;
        }
    }
}
