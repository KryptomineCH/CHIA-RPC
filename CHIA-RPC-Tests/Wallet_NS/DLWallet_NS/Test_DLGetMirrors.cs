using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLGetMirrors
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"mirrors\": [\r\n        {\r\n            \"amount\": 10,\r\n            \"coin_id\": \"a6f36cf305c59db988ee0c1c39546ae9577ce75fd9cabe18cdacf94d8168077b\",\r\n            \"launcher_id\": \"4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n            \"ours\": true,\r\n            \"urls\": [\r\n                \"http://www.example.com:8575\",\r\n                \"http://www.example2.com:8575\"\r\n            ]\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<LauncherID_RPC> helper = new Test_RPCClasses<LauncherID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<LauncherID_RPC> helper = new Test_RPCClasses<LauncherID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlGetMirrors_Response> helper = new Test_ResponseClasses<DlGetMirrors_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlGetMirrors_Response> helper = new Test_ResponseClasses<DlGetMirrors_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
