using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationandDeserialization
{
    class JsonDeserealization
    {
        public void JsonDesrialize()
        {
            string json = @"{'Name' : 'Rahul','Description' : 'Welcome to Json Program'}";
            BlogSites1 obj = JsonConvert.DeserializeObject<BlogSites1>(json);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Description);
        }
    }
    [DataContract]
    class BlogSites1
    {
        [DataMember]

        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}

