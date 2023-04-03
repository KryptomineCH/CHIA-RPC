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

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<PwSelfPool_RPC> helper = new Test_RPCClasses<PwSelfPool_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<PwSelfPool_RPC> helper = new Test_RPCClasses<PwSelfPool_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<PwJoinPool_Response> helper = new Test_ResponseClasses<PwJoinPool_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#pw_absorb_rewards, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<PwJoinPool_Response> helper = new Test_ResponseClasses<PwJoinPool_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
