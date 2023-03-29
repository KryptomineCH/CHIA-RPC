using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftGetNfts
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 2}"
        };
        string[] ExpectedResponseResults = new string[]
        {
			"{\r\n    \"nft_list\": [\r\n        {\r\n            \"chain_info\": \"((117 \"https://images.pexels.com/photos/11053072/pexels-photo-11053072.jpeg\") (104 . 0x14836b86a48e1b2b5e857213af97534704475b4c155d34b2cb83ed4b7cba2bb0) (28021) (27765) (29550 . 1) (29556 . 1))\",\r\n            \"data_hash\": \"0x14836b86a48e1b2b5e857213af97534704475b4c155d34b2cb83ed4b7cba2bb0\",\r\n            \"data_uris\": [\r\n                \"https://images.pexels.com/photos/11053072/pexels-photo-11053072.jpeg\"\r\n            ],\r\n            \"launcher_id\": \"0xba54ae34764b024b3b7a4f0ead65e66e53fbf54d29563f09b360b978ebf9edf1\",\r\n            \"launcher_puzhash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n            \"license_hash\": \"0x\",\r\n            \"license_uris\": [],\r\n            \"metadata_hash\": \"0x\",\r\n            \"metadata_uris\": [],\r\n            \"mint_height\": 1127233,\r\n            \"nft_coin_id\": \"0x2691a4aa3533a3b3ef57cc8f70af22f1238d8961fb6b98b4f48eb34b61dc47b1\",\r\n            \"owner_did\": null,\r\n            \"pending_transaction\": false,\r\n            \"royalty_percentage\": null,\r\n            \"royalty_puzzle_hash\": null,\r\n            \"edition_number\": 1,\r\n            \"edition_total\": 1,\r\n            \"supports_did\": false,\r\n            \"updater_puzhash\": \"0xfe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78b\"\r\n        }\r\n    ],\r\n    \"success\": true,\r\n    \"wallet_id\": 2\r\n}"
		};

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<NftGetNfts_RPC> helper = new Test_RPCClasses<NftGetNfts_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<NftGetNfts_RPC> helper = new Test_RPCClasses<NftGetNfts_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<NftGetNfts_Response> helper = new Test_ResponseClasses<NftGetNfts_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<NftGetNfts_Response> helper = new Test_ResponseClasses<NftGetNfts_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
