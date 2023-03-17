using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByParentIDs
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"parent_ids\":[\"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\",\"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\"],\"start_height\":4,\"end_height\":1900000,\"include_spent_coins\":true}"
        };
            
        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByParentIDs_RPC> helper = new Test_RPCClasses<GetCoinRecordsByParentIDs_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByParentIDs_RPC> helper = new Test_RPCClasses<GetCoinRecordsByParentIDs_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
