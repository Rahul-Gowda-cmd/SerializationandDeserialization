using System;

namespace SerializationandDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerilaization objDesrialize = new BinarySerilaization();
            objDesrialize.Serialization();
            objDesrialize.DeSerialization();
            JsonSerilization json = new JsonSerilization();
            json.JsonSerilize();
            JsonDeserealization deserealization = new JsonDeserealization();
            deserealization.JsonDesrialize();
        }
    }
}
