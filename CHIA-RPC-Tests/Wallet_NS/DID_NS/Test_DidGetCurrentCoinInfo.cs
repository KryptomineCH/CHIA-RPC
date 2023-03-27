using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidGetCurrentCoinInfo
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"did_amount\": 1,\r\n  \"did_innerpuz\": \"0x02067ee5d738b59436477a13c6d1450916d46b45e5f39062cdfb5973776be836\",\r\n  \"did_parent\": \"0x0a0ea8551568817765ef05c3c198f96d7376b19250bdb5ffaab24378f5593d09\",\r\n  \"my_did\": \"did:chia:17sfqnlhawfu5k5nzp36v67u85qythp7aummt8f4sj2t3rdag2yvskjyqal\",\r\n  \"success\": true,\r\n  \"wallet_id\": 3\r\n}"
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
            
            Test_ResponseClasses<DidGetCurrentCoinInfo_Response> helper = new Test_ResponseClasses<DidGetCurrentCoinInfo_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidGetCurrentCoinInfo_Response> helper = new Test_ResponseClasses<DidGetCurrentCoinInfo_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
