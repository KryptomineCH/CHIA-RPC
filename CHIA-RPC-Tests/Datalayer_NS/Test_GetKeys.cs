using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetKeys
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x8f9601eba73a276d5b9e12fbec52b113217e89a55831ae1d80bca48462fbaea7\", \"root_hash\": \"0x9527cc5e43bf93062423221e9bec761cbc3f24a0811cb0738da2419dfe7649f7\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"keys\": [\r\n        \"0x0001\",\r\n        \"0x0002\",\r\n        \"0x0003\"\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetKeys_RPC> helper = new Test_RPCClasses<GetKeys_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetKeys_RPC> helper = new Test_RPCClasses<GetKeys_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetKeys_Response> helper = new Test_ResponseClasses<GetKeys_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetKeys_Response> helper = new Test_ResponseClasses<GetKeys_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
