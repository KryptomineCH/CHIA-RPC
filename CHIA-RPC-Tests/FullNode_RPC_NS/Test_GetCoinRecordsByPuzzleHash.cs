using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetCoinRecordsByPuzzleHash
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"puzzle_hash\":\"b1736654875b1c49b4077b89580c4447f12f1e86fb85d488d7efddd5c6e06be0\",\"start_height\":800000,\"end_height\":1000000,\"include_spent_coins\":true}"
        };
            
        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
