using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC_Tests.Testhelpers
{
    internal class Test_ObjectClasses<T> where T : ObjectTemplate<T>
    {
        internal void Test_ObjectSerialisation(string[] expectedResults)
        {
            foreach (string expectedResult in expectedResults)
            {
                T rpc = ObjectTemplate<T>.LoadObjectFromString(expectedResult);
                string rpcString = rpc.ToString();
                Assert.Equal(expectedResult, rpcString);
            }
        }
        internal void Test_ObjectDiskIO(string[] expectedResults)
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
