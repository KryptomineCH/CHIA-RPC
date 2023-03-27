using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetRootHistory
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"root_history\": [\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n      \"timestamp\": 1660618627\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0xa03d7ea8e488d6443f51a8b586f11754447fb449dc48af881ee78ff77ec7cdb1\",\r\n      \"timestamp\": 1660622775\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x75cccd7342e93b5a716877c285282f45b1125c33d3f67cd62a353efdbe4fd9fa\",\r\n      \"timestamp\": 1660623078\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x9527cc5e43bf93062423221e9bec761cbc3f24a0811cb0738da2419dfe7649f7\",\r\n      \"timestamp\": 1660632383\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x75cccd7342e93b5a716877c285282f45b1125c33d3f67cd62a353efdbe4fd9fa\",\r\n      \"timestamp\": 1660632535\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x9489c92aa253bbc8489eef1b2dee0f26855ee88d82744b4a7721b1e1528442ba\",\r\n      \"timestamp\": 1660632993\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0xa78402ca50f743152e1e2f7848f8bd5edce150723f5baa85242d3e1a7518b163\",\r\n      \"timestamp\": 1660633450\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"root_hash\": \"0x044e03adb3d3180ed91b8bd4afb4c381e821d5641e5cc11e458ab33cbae2ed01\",\r\n      \"timestamp\": 1660635004\r\n    }\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetRootHistory_Response> helper = new Test_ResponseClasses<GetRootHistory_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<TxID_Response> helper = new Test_ResponseClasses<TxID_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
