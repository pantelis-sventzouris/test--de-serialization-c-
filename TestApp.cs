using System.Collections.Generic;

namespace NewProj1
{
    public class TestApp
    {
        public static void main(string[] args)
        {
            var model1 = new TestModel
            {
                Property1 = "1",
                Property2 = "2",
                Property3 = "3",
                Property4 = "4",
                Property5 = "5"                
            };

            var model2 = new TestModel
            {
                Property1 = "2",
                Property2 = "4",
                Property3 = "6",
                Property4 = "8",
                Property5 = "10"
            };

            var testList = new List<TestModel>();
            testList.Add(model1);
            testList.Add(model2);

            byte[] serializedData = HelperClass.SerializeObjectListToByteArray(testList);

        }
    }
}