using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetAllMempoolTxIDs
    {

        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"tx_ids\": [\r\n    \"0x94c6db00186900418ef7c1f05e127ee1a647cbe6e514ec3bc57acb7bbe6dfb10\"\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}",
            "{\r\n    \"success\": true,\r\n    \"tx_ids\": [\r\n        \"0xcde95bf9f0630d96d7b13b0ec7bb4251e06e407307f68e01c158a3ce2d903df6\",\r\n        \"0x27d6e2390cc810ed8953089a76b79b04b5088e3b7c0f974e1a266d964eb67501\",\r\n        \"0xebc444de2e43d151a7c9d8c1db081ce19780c07e07c334fb448955a401ee96a4\",\r\n        \"0x0daaa1be38c96019df8de5e345dcd1a1423c383a1fcb54e64ff0f994604d3c4b\",\r\n        \"0x75a561a1bf3e2fc26ebdcfc37592c18e228d25486f4f7874a228fbd2aa935b1a\"\r\n    ]\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetAllMempoolTxIDs_Response> helper = new Test_ResponseClasses<GetAllMempoolTxIDs_Response>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetAllMempoolTxIDs_Response> helper = new Test_ResponseClasses<GetAllMempoolTxIDs_Response>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
