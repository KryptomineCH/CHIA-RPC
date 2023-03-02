using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_ResponseClasses<T> where T : ResponseTemplate<T>
    {
        internal void Test_ResponseSerialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                T rpc = ResponseTemplate<T>.LoadResponseFromString(expectedResult);
                string rpcString = rpc.ToString();
                Assert.Equal(expectedResult, rpcString);
            }
        }
        internal void Test_ResponseDiskIO(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                string fileName = "";
                try
                {
                    T originalRPC = ResponseTemplate<T>.LoadResponseFromString(expectedResult);
                    fileName = originalRPC.GetType().ToString() + "_Test_SavingResponse.response";
                    originalRPC.SaveResponseToFile(fileName);
                    T newRPC = ResponseTemplate<T>.LoadResponseFromFile(fileName);
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
