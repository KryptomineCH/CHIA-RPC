using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_RPCClasses<T> where T : RPCTemplate<T>, new()
    {
        internal void Test_RPCSerialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                // parse teststring into a dynamic type for comparison later
                JsonElement inputParsed = JsonSerializer.Deserialize<JsonElement>(expectedResult, new JsonSerializerOptions { AllowTrailingCommas = true });
                // parse teststring into class which is to be tested
                T myRPC = RPCTemplate<T>.LoadRpcFromString(expectedResult);
                // parse object back into a json
                string myRPC_Json = myRPC.ToString();
                // parse myObject output into a dynamic type for comparison with expectedResult
                JsonElement myRPC_Result = JsonSerializer.Deserialize<JsonElement>(myRPC_Json, new JsonSerializerOptions { AllowTrailingCommas = true });
                // test result
                JsonElementComparer.AssertEqual(inputParsed, myRPC_Result);
            }
        }
        internal void Test_RPCDiskIO(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                string fileName = "";
                try
                {
                    T originalRPC = RPCTemplate<T>.LoadRpcFromString(expectedResult);
                    fileName = originalRPC.GetType().ToString() + "_Test_SavingRPC.rpc";
                    originalRPC.SaveRpcToFile(fileName);
                    T newRPC = RPCTemplate<T>.LoadRpcFromFile(fileName);
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
