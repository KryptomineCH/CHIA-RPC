using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftGetInfo
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\r\n    \"wallet_id\": 4,\r\n    \"coin_id\": \"0x821fdd13fe209466f1c69d82eb951cf630d28e901c2e14285d8a574dbde034c4\"\r\n}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"nft_info\": {\r\n        \"chain_info\": \"((117 \"https://images.pexels.com/photos/11053072/pexels-photo-11053072.jpeg\") (104 . 0x14836b86a48e1b2b5e857213af97534704475b4c155d34b2cb83ed4b7cba2bb0) (28021 \"https://metadata_example.com\", \"https://metadata_example2.com\") (27765 \"https://license_example.com\", \"https://license_example2.com\") (29550 . 1) (29556 . 5) (28008 . 0x868463c2ae6f8a9585156c9ad9f4b9b01eeacc56fec82aa629c97135ff21823e) (27752 . 0x358d4eb4aedefbec22824036299eff24216d213a95c8f986f862f0a89a250a82))\",\r\n        \"data_hash\": \"0x14836b86a48e1b2b5e857213af97534704475b4c155d34b2cb83ed4b7cba2bb0\",\r\n        \"data_uris\": [\r\n            \"https://images.pexels.com/photos/11053072/pexels-photo-11053072.jpeg\"\r\n        ],\r\n        \"launcher_id\": \"0x821fdd13fe209466f1c69d82eb951cf630d28e901c2e14285d8a574dbde034c4\",\r\n        \"launcher_puzhash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n        \"license_hash\": \"0x358d4eb4aedefbec22824036299eff24216d213a95c8f986f862f0a89a250a82\",\r\n        \"license_uris\": [\r\n            \"https://license_example.com\",\r\n            \"https://license_example2.com\"\r\n        ],\r\n        \"metadata_hash\": \"0x868463c2ae6f8a9585156c9ad9f4b9b01eeacc56fec82aa629c97135ff21823e\",\r\n        \"metadata_uris\": [\r\n            \"https://metadata_example.com\",\r\n            \"https://metadata_example2.com\"\r\n        ],\r\n        \"mint_height\": 1127304,\r\n        \"nft_coin_id\": \"0x9bcf429079bd8e394658a3f0c43c6641c9f92d0dcc1770eeb6be6588a49fc925\",\r\n        \"owner_did\": \"0xd590645dc77e25f22ffe37846e73868a99179d33de11648efaa286bc341936ea\",\r\n        \"pending_transaction\": false,\r\n        \"royalty_percentage\": 300,\r\n        \"royalty_puzzle_hash\": \"0x0fe4e859760b755980c9a92c91459b75eb4f02135ace8d2731eca0e89ceef1fb\",\r\n        \"edition_number\": 1,\r\n        \"edition_total\": 5,\r\n        \"supports_did\": true,\r\n        \"updater_puzhash\": \"0xfe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78b\"\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<NftGetInfo_RPC> helper = new Test_RPCClasses<NftGetInfo_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<NftGetInfo_RPC> helper = new Test_RPCClasses<NftGetInfo_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<NftGetInfo_Response> helper = new Test_ResponseClasses<NftGetInfo_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<NftGetInfo_Response> helper = new Test_ResponseClasses<NftGetInfo_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
