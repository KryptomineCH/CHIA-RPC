using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetTransaction
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"transaction_id\": \"0x43f6811a4daf18622fc7f132f5166a1246056b4a983b7befccb7e4b2e2c57f3b\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"transaction\": {\r\n        \"additions\": [\r\n            {\r\n                \"amount\": 100,\r\n                \"parent_coin_info\": \"0xabbb6c6859db74e8e627f21263c078893383131bcf22faec68b2de914d03e59f\",\r\n                \"puzzle_hash\": \"0xb4a41bbce457745b006181ab99e34a0cbd8c83c196bc74fc98eb3aec882ed784\"\r\n            }\r\n        ],\r\n        \"amount\": 100,\r\n        \"confirmed\": true,\r\n        \"confirmed_at_height\": 2863494,\r\n        \"created_at_time\": 1669182237,\r\n        \"fee_amount\": 0,\r\n        \"memos\": {},\r\n        \"name\": \"0x43f6811a4daf18622fc7f132f5166a1246056b4a983b7befccb7e4b2e2c57f3b\",\r\n        \"removals\": [\r\n            {\r\n                \"amount\": 100,\r\n                \"parent_coin_info\": \"0x9c0083d8da8733c899787e4dcf18a56bc944f49ed668808e20890f01cbc35f37\",\r\n                \"puzzle_hash\": \"0xb4a41bbce457745b006181ab99e34a0cbd8c83c196bc74fc98eb3aec882ed784\"\r\n            }\r\n        ],\r\n        \"sent\": 10,\r\n        \"sent_to\": [],\r\n        \"spend_bundle\": null,\r\n        \"to_address\": \"xch1kmk3jx30sqv57j07x05mjf2xgt9fgthzslaweg4yta9edfwqsadqagh96h\",\r\n        \"to_puzzle_hash\": \"0xb6ed191a2f80194f49fe33e9b9254642ca942ee287faeca2a45f4b96a5c0875a\",\r\n        \"trade_id\": null,\r\n        \"type\": 0,\r\n        \"wallet_id\": 2\r\n    },\r\n    \"transaction_id\": \"0x43f6811a4daf18622fc7f132f5166a1246056b4a983b7befccb7e4b2e2c57f3b\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<TransactionID_RPC> helper = new Test_RPCClasses<TransactionID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<TransactionID_RPC> helper = new Test_RPCClasses<TransactionID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetTransaction_Response> helper = new Test_ResponseClasses<GetTransaction_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetTransaction_Response> helper = new Test_ResponseClasses<GetTransaction_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
