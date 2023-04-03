using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetOffer
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"trade_id\": \"c4d9f06599e4ba30edfabecc72a03db7d7e86c003ab83520002a844cfebf2ef5\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"offer\": null,\r\n    \"success\": true,\r\n    \"trade_record\": {\r\n        \"accepted_at_time\": null,\r\n        \"coins_of_interest\": [\r\n            {\r\n                \"amount\": 998999,\r\n                \"parent_coin_info\": \"0xc40219a0d62cd481f2a47fdedc5ef1c936f3dea0d8a751794dba233c8aeac790\",\r\n                \"puzzle_hash\": \"0x91362b7593aab3bcc4d3f5c0b3e9952b5eeccd0b22e06d1ce6242d6fce9b6526\"\r\n            },\r\n            {\r\n                \"amount\": 100000,\r\n                \"parent_coin_info\": \"0x5e0ec48322fff686044e02d159e2679fba716cab80f4fb10fdf42a775f85604a\",\r\n                \"puzzle_hash\": \"0xa023dfcc927f2c5f71fb9f4cd81078d478448452c10acac9156e3b51bd7abe63\"\r\n            }\r\n        ],\r\n        \"confirmed_at_index\": 0,\r\n        \"created_at_time\": 1669280986,\r\n        \"is_my_offer\": true,\r\n        \"pending\": {\r\n            \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": 998999,\r\n            \"unknown\": 100000\r\n        },\r\n        \"sent\": 0,\r\n        \"sent_to\": [],\r\n        \"status\": \"PENDING_ACCEPT\",\r\n        \"summary\": {\r\n            \"fees\": 1,\r\n            \"infos\": {\r\n                \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": {\r\n                    \"tail\": \"0x0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\",\r\n                    \"type\": \"CAT\"\r\n                }\r\n            },\r\n            \"offered\": {\r\n                \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": 1000\r\n            },\r\n            \"requested\": {\r\n                \"xch\": 10000\r\n            }\r\n        },\r\n        \"taken_offer\": null,\r\n        \"trade_id\": \"0xc4d9f06599e4ba30edfabecc72a03db7d7e86c003ab83520002a844cfebf2ef5\"\r\n    }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetOffer_RPC> helper = new Test_RPCClasses<GetOffer_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetOffer_RPC> helper = new Test_RPCClasses<GetOffer_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ObjectClasses<OfferFile> helper = new Test_ObjectClasses<OfferFile>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ObjectClasses<OfferFile> helper = new Test_ObjectClasses<OfferFile>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
