using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetAllMempoolTxIDs
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"tx_ids\": [\r\n    \"0x94c6db00186900418ef7c1f05e127ee1a647cbe6e514ec3bc57acb7bbe6dfb10\"\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetAllMempoolTxIDs_Response> helper = new Test_ResponseClasses<GetAllMempoolTxIDs_Response>();
            helper.Test_ResponseSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetAllMempoolTxIDs_Response> helper = new Test_ResponseClasses<GetAllMempoolTxIDs_Response>();
            helper.Test_ResponseDiskIO(ExpectedResults);
        }
    }
}
