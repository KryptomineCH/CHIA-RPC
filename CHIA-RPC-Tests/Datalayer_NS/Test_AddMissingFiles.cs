using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_AddMissingFiles
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "",
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<AddMissingFiles_RPC> helper = new Test_RPCClasses<AddMissingFiles_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<AddMissingFiles_RPC> helper = new Test_RPCClasses<AddMissingFiles_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
