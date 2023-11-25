using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_ResponseClasses<T> where T : ResponseTemplate<T>, new()
    {
        internal void Test_Serialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                // parse teststring into a dynamic type for comparison later
                JsonElement inputParsed = JsonSerializer.Deserialize<JsonElement>(expectedResult, new JsonSerializerOptions { AllowTrailingCommas = true });
                // parse teststring into class which is to be tested
                ActionResult<T> myResponse = ResponseTemplate<T>.LoadResponseFromString(expectedResult);
                // parse object back into a json
                if (myResponse.Data == null) throw new InvalidOperationException("failed to load expectedResult!");
                string myResponse_Json = myResponse.Data.ToString();
                // parse myObject output into a dynamic type for comparison with expectedResult
                JsonElement myResponse_Result = JsonSerializer.Deserialize<JsonElement>(myResponse_Json, new JsonSerializerOptions { AllowTrailingCommas = true });
                // test result
                JsonElementComparer.AssertEqual(inputParsed, myResponse_Result);
            }
        }
        internal void Test_DiskIO(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                string fileName = "";
                try
                {
                    ActionResult<T> originalRPC = ResponseTemplate<T>.LoadResponseFromString(expectedResult);
                    if (originalRPC.Data == null) throw new InvalidOperationException($"failed to load expectedResult!");
                    fileName = originalRPC.GetType().ToString() + "_Test_SavingResponse.response";
                    originalRPC.Data.SaveResponseToFile(fileName);
                    T? newRPC = ResponseTemplate<T>.LoadResponseFromFile(fileName);
                    if (newRPC == null) throw new InvalidOperationException($"failed to load newRPC!");
                    Assert.Equal(originalRPC.ToString(), newRPC.ToString());
                }
                catch (Exception ex)
                {
                    var _ = ex.Message;
                    // Handle the exception here if needed, for example by logging it.
                    // Then rethrow the exception.
                    throw;
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
