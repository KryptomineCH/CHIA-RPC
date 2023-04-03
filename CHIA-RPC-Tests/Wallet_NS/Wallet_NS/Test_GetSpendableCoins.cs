﻿using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetSpendableCoins
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"confirmed_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 999996796,\r\n                \"parent_coin_info\": \"0xfecaf9d1cffe1b71f00aee7816ea90562b18307d4461757e23f097703340beb7\",\r\n                \"puzzle_hash\": \"0x138373343443d3cdf6bd033244f32d904dd93e1ad2772f120955c0d8d761b722\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 2867783,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1669261898\r\n        }\r\n    ],\r\n    \"success\": true,\r\n    \"unconfirmed_additions\": [],\r\n    \"unconfirmed_removals\": []\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetSpendableCoins_RPC> helper = new Test_RPCClasses<GetSpendableCoins_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetSpendableCoins_RPC> helper = new Test_RPCClasses<GetSpendableCoins_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetSpendableCoins_Response> helper = new Test_ResponseClasses<GetSpendableCoins_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetSpendableCoins_Response> helper = new Test_ResponseClasses<GetSpendableCoins_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
