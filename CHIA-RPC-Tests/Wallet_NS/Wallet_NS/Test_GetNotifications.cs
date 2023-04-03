using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetNotifications
    { 
        private string[] ExpectedRPCResults = new string[]
        {
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"notifications\": [\r\n        {\r\n            \"amount\": 10000000,\r\n            \"id\": \"f74fb363fbdeef3f6bcf7a0664a8ef76ea3e5f22bb4ffc9a1f9ef23b9329ae28\",\r\n            \"message\": \"fadedcab\"\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#get_notifications, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<Index_RPC> helper = new Test_RPCClasses<Index_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#get_notifications, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<Index_RPC> helper = new Test_RPCClasses<Index_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetNotifications_Response> helper = new Test_ResponseClasses<GetNotifications_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetNotifications_Response> helper = new Test_ResponseClasses<GetNotifications_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
