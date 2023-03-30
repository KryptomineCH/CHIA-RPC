using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidGetRecoveryList
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"num_required\": 2,\r\n  \"recovery_list\": [\r\n    \"did:chia:1d2x5wnm4sl4j2ena8ka3fyv8x7tzc9v520gstd3zfdu4pf6c2yksk8th4u\",\r\n    \"did:chia:1gsarjll9lrd4kwxdglh28cjn3ln6u7ldfzsask9gw4tprzce20vsywwsqs\"\r\n  ],\r\n  \"success\": true,\r\n  \"wallet_id\": 3\r\n}"
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
            
            Test_ResponseClasses<DidGetRecoveryList_Response> helper = new Test_ResponseClasses<DidGetRecoveryList_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidGetRecoveryList_Response> helper = new Test_ResponseClasses<DidGetRecoveryList_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
