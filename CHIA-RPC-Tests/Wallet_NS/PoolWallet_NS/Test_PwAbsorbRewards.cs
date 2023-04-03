using CHIA_RPC.Wallet_NS.PoolWallet_NS;
using CHIA_RPC_Tests.Testhelpers;
using System.Xml.Schema;

namespace CHIA_RPC_Tests.Wallet_NS.PoolWallet_NS
{
    public class Test_PwAbsorbRewards
    {
        private string[] ExpectedRPCResults = new string[]
        {
            ""
        };
        string[] ExpectedResponseResults = new string[]
        {
            ""
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards is incomplete!");
            Test_RPCClasses<PwSelfPool_RPC> helper = new Test_RPCClasses<PwSelfPool_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards is incomplete!");
            Test_RPCClasses<PwSelfPool_RPC> helper = new Test_RPCClasses<PwSelfPool_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards is incomplete!");
            Test_ResponseClasses<PwJoinPool_Response> helper = new Test_ResponseClasses<PwJoinPool_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards is incomplete!");
            Test_ResponseClasses<PwJoinPool_Response> helper = new Test_ResponseClasses<PwJoinPool_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
