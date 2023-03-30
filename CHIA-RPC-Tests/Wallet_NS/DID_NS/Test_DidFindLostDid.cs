using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidFindLostDid
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"coin_id\": \"did:chia:1cxw5dqug4gavvgylx88zfkmqv235ryr6j9tvyjwwuga0pa52wjvqavdyar\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"latest_coin_id\": \"fa6a754142a557b0bf3ce5122f0146b5d7d996aadd521cf63b97f49a0e998c53\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DidFindLostDid_RPC> helper = new Test_RPCClasses<DidFindLostDid_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DidFindLostDid_RPC> helper = new Test_RPCClasses<DidFindLostDid_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DidFindLostDid_Response> helper = new Test_ResponseClasses<DidFindLostDid_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidFindLostDid_Response> helper = new Test_ResponseClasses<DidFindLostDid_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
