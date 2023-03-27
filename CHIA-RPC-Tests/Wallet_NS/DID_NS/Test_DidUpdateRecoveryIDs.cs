using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidUpdateRecoveryIDs
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3, \"new_list\": [\"did:chia:1d2x5wnm4sl4j2ena8ka3fyv8x7tzc9v520gstd3zfdu4pf6c2yksk8th4u\", \"did:chia:1gsarjll9lrd4kwxdglh28cjn3ln6u7ldfzsask9gw4tprzce20vsywwsqs\"]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DidUpdateRecoveryIDs_RPC> helper = new Test_RPCClasses<DidUpdateRecoveryIDs_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DidUpdateRecoveryIDs_RPC> helper = new Test_RPCClasses<DidUpdateRecoveryIDs_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
