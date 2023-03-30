using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidGetDid
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"coin_id\": \"0xce323237c656693fc2f633f911a589b42fe142f18c70883fbe70f7718538cf66\",\r\n  \"my_did\": \"did:chia:17sfqnlhawfu5k5nzp36v67u85qythp7aummt8f4sj2t3rdag2yvskjyqal\",\r\n  \"success\": true,\r\n  \"wallet_id\": 3\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DidGetDid_Response> helper = new Test_ResponseClasses<DidGetDid_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidGetDid_Response> helper = new Test_ResponseClasses<DidGetDid_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
