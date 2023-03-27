using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidGetPubkey
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"pubkey\": \"886826068778f285c442cfd08a45c7b55ecc9ef870b9b18810e81457c56df9764793686c1756e48a91586839a4abd290\",\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DidGetPubkey_Response> helper = new Test_ResponseClasses<DidGetPubkey_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidGetPubkey_Response> helper = new Test_ResponseClasses<DidGetPubkey_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
