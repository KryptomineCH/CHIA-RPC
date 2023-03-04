using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetFeeEstimate
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"spend_bundle\":null,\"cost\":20000000,\"target_times\":[60,300,600]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"current_fee_rate\": 0,\r\n  \"estimates\": [\r\n    0,\r\n    0,\r\n    0\r\n  ],\r\n  \"full_node_synced\": true,\r\n  \"last_peak_timestamp\": 1669102616,\r\n  \"mempool_max_size\": 550000000000,\r\n  \"mempool_size\": 252581708,\r\n  \"node_time_utc\": 1669102646,\r\n  \"peak_height\": 2859331,\r\n  \"target_times\": [\r\n    60,\r\n    300,\r\n    600\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {

            Test_RPCClasses<GetFeeEstimate_RPC> helper = new Test_RPCClasses<GetFeeEstimate_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetFeeEstimate_RPC> helper = new Test_RPCClasses<GetFeeEstimate_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<GetFeeEstimate_Response> helper = new Test_ResponseClasses<GetFeeEstimate_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetFeeEstimate_Response> helper = new Test_ResponseClasses<GetFeeEstimate_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
