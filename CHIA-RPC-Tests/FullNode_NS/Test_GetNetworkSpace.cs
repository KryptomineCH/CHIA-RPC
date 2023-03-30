using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetNetworkSpace
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"older_block_header_hash\":\"0xd780d22c7a87c9e01d98b49a0910f6701c3b95015741316b3fda042e5d7b81d2\",\"newer_block_header_hash\":\"0xd3372ec62d3ef2f55a8e3d0e76f6f341212f5e09b4d5112add588262257a8e4e\"}"
            ,"{\"older_block_header_hash\": \"023cbcdc3cb97e5ddeb6fe40a6a28b303255bb821090b237d00dd77c9dfefb7a\", \"newer_block_header_hash\": \"6c26e4a79b437de1272942a7c4c78e1af3a71741f1244b14320279c7084cf3c8\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"space\": 137052209455435968,\r\n  \"success\": true,\r\n  \"error\": null\r\n}",
            "{\r\n    \"space\": 26915196432975761408,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetNetworkSpace_RPC> helper = new Test_RPCClasses<GetNetworkSpace_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetNetworkSpace_RPC> helper = new Test_RPCClasses<GetNetworkSpace_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetNetworkSpace_Response> helper = new Test_ResponseClasses<GetNetworkSpace_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetNetworkSpace_Response> helper = new Test_ResponseClasses<GetNetworkSpace_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
