using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NewProj1
{
    public class HelperClass
    {
        public HelperClass()
        {
            
        }

        public static byte[] SerializeObjectListToByteArray(List<TestModel> objLst)
        {
            byte[] serializedData = null;

            if(objLst == null || objLst.Count == 0)
            {
                throw new Exception("empty list error");
            }

            var formatter = new BinaryFormatter();

            using (var ms = new MemoryStream())
            {
                formatter.Serialize(ms, objLst);
                serializedData = ms.toArray();                
            }
            return serializedData;            
        }

        public static List<TestModel> DeserializeByteArrayToObjectList(byte[] serializedData)
        {
            if(serializedData == null || serializedData.Length == 0){
                throw new Exception("not valid input data error");
            }

            var deserializedDataList = new List<TestModel>();

            using(var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();

                deserializedDataList = formatter.Deserialize(ms) as List<TestModel>;
            }

            return deserializedDataList;


        }
        
    }
}