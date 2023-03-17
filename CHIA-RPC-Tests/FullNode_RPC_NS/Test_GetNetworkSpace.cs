using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetNetworkSpace
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"older_block_header_hash\":\"0xd780d22c7a87c9e01d98b49a0910f6701c3b95015741316b3fda042e5d7b81d2\",\"newer_block_header_hash\":\"0xd3372ec62d3ef2f55a8e3d0e76f6f341212f5e09b4d5112add588262257a8e4e\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"space\": 137052209455435968,\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetNetworkSpace_RPC> helper = new Test_RPCClasses<GetNetworkSpace_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetNetworkSpace_RPC> helper = new Test_RPCClasses<GetNetworkSpace_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetNetworkSpace_Response> helper = new Test_ResponseClasses<GetNetworkSpace_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetNetworkSpace_Response> helper = new Test_ResponseClasses<GetNetworkSpace_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
