using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByPuzzleHashes
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"puzzle_hashes\":[\"0x6776391535247e1617ee17cabc6a13932faa3d3f2094a55fe95ccefcbb1a749a\",\"0x37bde5f12f697eac8b4f2093656814ce3f05a485702bd1cbd6e436652d99dd96\",\"0xd51afe647b6cb50f4feaa437c1e51d13ee0019831498f5a01418daece0d20a37\"],\"start_height\":400000,\"end_height\":1900000,\"include_spent_coins\":false}"
        };
            
        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
