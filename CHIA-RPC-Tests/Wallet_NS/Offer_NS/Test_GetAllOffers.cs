using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Offer_NS
{
    public class Test_GetAllOffers
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"start\": 0, \"end\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"offers\": null,\r\n    \"success\": true,\r\n    \"trade_records\": [\r\n        {\r\n            \"accepted_at_time\": null,\r\n            \"coins_of_interest\": [\r\n                {\r\n                    \"amount\": 1,\r\n                    \"parent_coin_info\": \"0xe2824e6ce7df1fc29aeba24ee7d4d3bfadad2360430391f249a0ed50f745d547\",\r\n                    \"puzzle_hash\": \"0xffdea0260e14e73ab4489772c63b75d65b5b070da5c260b2682bfd83d2ca0d6c\"\r\n                }\r\n            ],\r\n            \"confirmed_at_index\": 0,\r\n            \"created_at_time\": 1676509124,\r\n            \"is_my_offer\": true,\r\n            \"pending\": {\r\n                \"afefeea01a615487ccfc2e3d70db69eceb5b715a81deba9e6b72b78067e61de6\": 1\r\n            },\r\n            \"sent\": 0,\r\n            \"sent_to\": [],\r\n            \"status\": \"PENDING_ACCEPT\",\r\n            \"summary\": {\r\n                \"fees\": 0,\r\n                \"infos\": {\r\n                    \"afefeea01a615487ccfc2e3d70db69eceb5b715a81deba9e6b72b78067e61de6\": {\r\n                        \"also\": {\r\n                            \"also\": {\r\n                                \"owner\": \"()\",\r\n                                \"transfer_program\": {\r\n                                    \"launcher_id\": \"0xafefeea01a615487ccfc2e3d70db69eceb5b715a81deba9e6b72b78067e61de6\",\r\n                                    \"royalty_address\": \"0xb185af1a299b92ac0f5de04d12e86d3e08dac37af59565f45d1555d8941b6e82\",\r\n                                    \"royalty_percentage\": \"200\",\r\n                                    \"type\": \"royalty transfer program\"\r\n                                },\r\n                                \"type\": \"ownership\"\r\n                            },\r\n                            \"metadata\": \"((117 \\\"https://nftstorage.link/ipfs/bafybeiciasr5ifxl73lq6mv5otyaukrvb6326nk6cgcsny2x4wcjxxis3q/356.gif\\\" \\\"ipfs://bafybeiciasr5ifxl73lq6mv5otyaukrvb6326nk6cgcsny2x4wcjxxis3q/356.gif\\\") (104 . 0x7b4981aba8d8e9dd25c40d6c696cb32eb7e281cb5629b29af64a2dd36495beb1) (28021 \\\"https://nftstorage.link/ipfs/bafybeiciasr5ifxl73lq6mv5otyaukrvb6326nk6cgcsny2x4wcjxxis3q/356.json\\\" \\\"ipfs://bafybeiciasr5ifxl73lq6mv5otyaukrvb6326nk6cgcsny2x4wcjxxis3q/356.json\\\") (27765 \\\"https://nftstorage.link/ipfs/bafybeidgtm4uobrog5kc7pn7bsmusdasf5w3drzqiitdjb3wragqrb7ola/LICENSE%20AGREEMENT.png\\\") (29550 . 1) (29556 . 1) (28008 . 0x9b40e3ed1d6b767886e6e8841aa1f6b60f8dc02cb98b2b876576c8dffc41995b) (27752 . 0x8e20454114197f82c7f50324df80170951fa3dfffd3b8860290207fb1e73743e))\",\r\n                            \"type\": \"metadata\",\r\n                            \"updater_hash\": \"0xfe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78b\"\r\n                        },\r\n                        \"launcher_id\": \"0xafefeea01a615487ccfc2e3d70db69eceb5b715a81deba9e6b72b78067e61de6\",\r\n                        \"launcher_ph\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n                        \"type\": \"singleton\"\r\n                    }\r\n                },\r\n                \"offered\": {\r\n                    \"afefeea01a615487ccfc2e3d70db69eceb5b715a81deba9e6b72b78067e61de6\": 1\r\n                },\r\n                \"requested\": {\r\n                    \"xch\": 2000000000000\r\n                }\r\n            },\r\n            \"taken_offer\": null,\r\n            \"trade_id\": \"0x039492f84708b8a585ddaa0dd44fa8db1a6afdad799b0900e37dfc9097f1f351\"\r\n        }\r\n    ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetAllOffers_RPC> helper = new Test_RPCClasses<GetAllOffers_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetAllOffers_RPC> helper = new Test_RPCClasses<GetAllOffers_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
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
