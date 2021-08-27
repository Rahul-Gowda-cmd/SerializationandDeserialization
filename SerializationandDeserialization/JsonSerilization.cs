using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationandDeserialization
{
    class JsonSerilization
    {
        public void JsonSerilize()
        {
            BlogSites obj = new BlogSites();
            string JsonData = JsonConvert.SerializeObject(obj);
            Console.WriteLine(JsonData);
        }
    }
    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string name { get; set; } = "Rahul";
        [DataMember]
        public string Description { get; set; } = "Welcome to Json Program";
    }
}

