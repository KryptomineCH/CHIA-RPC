using CHIA_RPC.FullNode_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_VdfOutput
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"data\": \"0x0300a4bc6790208e73245df6a85b3f7beac0d17e73972b414a7f94cf1e3c3e9bb4a400516d368cfa8b1814f3b5163fe5a54a1fe35781f58290673c8d9f56cd23b94c138b21207d6aa6f3049f8ad805eb99b28292e06e748117e78e13598cee9945670100\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<VdfOutput> helper = new Test_ObjectClasses<VdfOutput>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<VdfOutput> helper = new Test_ObjectClasses<VdfOutput>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
