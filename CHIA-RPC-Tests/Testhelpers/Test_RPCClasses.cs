using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_RPCClasses<T> where T : RPCTemplate<T>
    {
        internal void Test_RPCSerialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                T rpc = RPCTemplate<T>.LoadRpcFromString(expectedResult);
                string rpcString = rpc.ToString();
                Assert.Equal(expectedResult, rpcString);
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
