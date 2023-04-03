using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_VerifySignature

    {
        private string[] ExpectedRPCResults = new string[]
        {
        };
        string[] ExpectedResponseResults = new string[]
        {
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#verify_signature, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#verify_signature, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#verify_signature, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#verify_signature, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
