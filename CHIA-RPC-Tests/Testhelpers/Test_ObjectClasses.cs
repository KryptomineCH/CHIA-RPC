using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_ObjectClasses<T> where T : ObjectTemplate<T>, new()
    {
        internal void Test_Serialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                // parse teststring into a dynamic type for comparison later
                JsonElement inputParsed = JsonSerializer.Deserialize<JsonElement>(expectedResult, new JsonSerializerOptions { AllowTrailingCommas = true });
                // parse teststring into class which is to be tested
                T myObject = ObjectTemplate<T>.LoadObjectFromString(expectedResult);
                // parse object back into a json
                string myObject_Json = myObject.ToString();
                // parse myObject output into a dynamic type for comparison with expectedResult
                JsonElement myObject_Result = JsonSerializer.Deserialize<JsonElement>(myObject_Json, new JsonSerializerOptions { AllowTrailingCommas = true });
                // test result
                JsonElementComparer.AssertEqual(inputParsed, myObject_Result);
            }
        }
        internal void Test_DiskIO(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                string fileName = "";
                try
                {
                    T originalRPC = ObjectTemplate<T>.LoadObjectFromString(expectedResult);
                    fileName = "Test_SavingObject."+ originalRPC.GetType().ToString().ToLower();
                    originalRPC.SaveObjectToFile(fileName);
                    T newRPC = ObjectTemplate<T>.LoadObjectFromFile(fileName);
                    Assert.Equal(originalRPC.ToString(), newRPC.ToString());
                }
                finally
                {
                    FileInfo fi = new FileInfo(fileName);
                    if (fi.Exists) fi.Delete();
                }

            }
        }
    }
}
