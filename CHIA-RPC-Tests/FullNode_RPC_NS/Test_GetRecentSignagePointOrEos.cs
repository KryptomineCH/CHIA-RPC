using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetRecentSignagePointOrEos
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"sp_hash\":null,\"challenge_hash\":null}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            throw new NotImplementedException("documentation is empty");
            Test_RPCClasses<GetRecentSignagePointOrEos_RPC> helper = new Test_RPCClasses<GetRecentSignagePointOrEos_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            throw new NotImplementedException("documentation is empty");
            Test_RPCClasses<GetRecentSignagePointOrEos_RPC> helper = new Test_RPCClasses<GetRecentSignagePointOrEos_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
