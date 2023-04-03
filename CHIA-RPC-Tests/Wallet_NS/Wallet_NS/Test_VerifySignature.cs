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

        [Fact]
        public void Test_RPCSerialisation()
        {
           throw new NotImplementedException("cannot be validated due to incomplete documentation on https://docs.chia.net/wallet-rpc#verify_signature");
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            throw new NotImplementedException("cannot be validated due to incomplete documentation on https://docs.chia.net/wallet-rpc#verify_signature");
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            throw new NotImplementedException("cannot be validated due to incomplete documentation on https://docs.chia.net/wallet-rpc#verify_signature");
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            throw new NotImplementedException("cannot be validated due to incomplete documentation on https://docs.chia.net/wallet-rpc#verify_signature");
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
