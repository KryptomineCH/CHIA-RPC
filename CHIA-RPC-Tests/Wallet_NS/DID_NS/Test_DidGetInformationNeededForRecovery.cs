using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidGetInformationNeededForRecovery
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"backup_dids\": [\r\n    \"0x0fc4d8aea5b66cac7c29d93d9eee37b6c0bd9ffcd6b8e38e2c8810de5199c4d3\"\r\n  ],\r\n  \"coin_name\": \"025b4ed9eafab653a6e80c1c1603272cfec0e5c5591bb45a7025dadedba63e23\",\r\n  \"my_did\": \"did:chia:19z0ladugc29x36580yejgp0s6czq0axt4tq0w7kr9uk4042asusqvxldga\",\r\n  \"newpuzhash\": \"0x3929e3a268d3d04b8a40f226b66f0ab4f00b5c12fd628bc18f8ce573e76b291f\",\r\n  \"pubkey\": \"0xa1b184cf85e9804ba1df27acd2efd4622366315293f2c2e06eae7d9776cd3ef474edd4d0f10323e8a7a817b5a42317de\",\r\n  \"success\": true,\r\n  \"wallet_id\": 2\r\n}"
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
            
            Test_ResponseClasses<DidGetInformationNeededForRecovery_Response> helper = new Test_ResponseClasses<DidGetInformationNeededForRecovery_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidGetInformationNeededForRecovery_Response> helper = new Test_ResponseClasses<DidGetInformationNeededForRecovery_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
