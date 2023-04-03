using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetAllOffers
    {
        string[] ExpectedRpcResults = new string[]
        {
            ""
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"offers\": null,\r\n    \"success\": true,\r\n    \"trade_records\": [\r\n        {\r\n            \"accepted_at_time\": null,\r\n            \"coins_of_interest\": [\r\n                {\r\n                    \"amount\": 999999,\r\n                    \"parent_coin_info\": \"0x60a8b06515aaefe74236eb234130d769a1b65c99706414901277926fe29c3360\",\r\n                    \"puzzle_hash\": \"0xad5de77c7da1316b9b72708d17dbb8937855d740ebaf85669b8bd925275e8d49\"\r\n                }\r\n            ],\r\n            \"confirmed_at_index\": 0,\r\n            \"created_at_time\": 1669275137,\r\n            \"is_my_offer\": true,\r\n            \"pending\": {\r\n                \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": 999999\r\n            },\r\n            \"sent\": 0,\r\n            \"sent_to\": [],\r\n            \"status\": \"PENDING_ACCEPT\",\r\n            \"summary\": {\r\n                \"fees\": 0,\r\n                \"infos\": {\r\n                    \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": {\r\n                        \"tail\": \"0x0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\",\r\n                        \"type\": \"CAT\"\r\n                    }\r\n                },\r\n                \"offered\": {\r\n                    \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": 1000\r\n                },\r\n                \"requested\": {\r\n                    \"xch\": 1000000000000\r\n                }\r\n            },\r\n            \"taken_offer\": null,\r\n            \"trade_id\": \"0x84d14398c1a38f376953bf8fa76cbee0d3216b382266d38b5612f17e96bcd1de\"\r\n        }\r\n    ]\r\n}"
        };
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#get_all_offers, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<GetAllOffers_RPC> helper = new Test_RPCClasses<GetAllOffers_RPC>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#get_all_offers, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetAllOffers_RPC> helper = new Test_RPCClasses<GetAllOffers_RPC>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ObjectClasses<OfferFiles> helper = new Test_ObjectClasses<OfferFiles>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ObjectClasses<OfferFiles> helper = new Test_ObjectClasses<OfferFiles>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
