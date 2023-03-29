using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftCalculateRoyalties
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\r\n    \"royalty_assets\": [\r\n        {\r\n            \"asset\": \"nft1sy37ezgaqjzg3mg3pwhltvz8ukc3uh9yaeagrs46qj4l8mdy7pmsun32tp\",\r\n            \"royalty_address\": \"xch120ywvwahucfptkeuzzdpdz5v0nnarq5vgw94g247jd5vswkn7rls35y2gc\",\r\n            \"royalty_percentage\": 300\r\n        },\r\n        {\r\n            \"asset\": \"nft1au09xq3d7dzjq4mt3lmxg97tay85grttc3nwmrx5wksmhkczx2tqc5twgs\",\r\n            \"royalty_address\": \"xch1dkj0aju6kkk24mwmwk99t5z0clnn5zw5rz9k7yg58yur747acgsqmy889v\",\r\n            \"royalty_percentage\": 777\r\n        }\r\n    ],\r\n    \"fungible_assets\": [\r\n        {\r\n            \"asset\": \"xch\",\r\n            \"amount\": 1000000000000\r\n        },\r\n        {\r\n            \"asset\": \"a628c1c2c6fcb74d53746157e438e108eab5c0bb3e5c80ff9b1910b3e4832913\",\r\n            \"amount\": 1000\r\n        }\r\n    ]\r\n}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"nft1au09xq3d7dzjq4mt3lmxg97tay85grttc3nwmrx5wksmhkczx2tqc5twgs\": [\r\n        {\r\n            \"address\": \"xch1dkj0aju6kkk24mwmwk99t5z0clnn5zw5rz9k7yg58yur747acgsqmy889v\",\r\n            \"amount\": 38850000000,\r\n            \"asset\": \"xch\"\r\n        },\r\n        {\r\n            \"address\": \"xch1dkj0aju6kkk24mwmwk99t5z0clnn5zw5rz9k7yg58yur747acgsqmy889v\",\r\n            \"amount\": 38,\r\n            \"asset\": \"a628c1c2c6fcb74d53746157e438e108eab5c0bb3e5c80ff9b1910b3e4832913\"\r\n        }\r\n    ],\r\n    \"nft1sy37ezgaqjzg3mg3pwhltvz8ukc3uh9yaeagrs46qj4l8mdy7pmsun32tp\": [\r\n        {\r\n            \"address\": \"xch120ywvwahucfptkeuzzdpdz5v0nnarq5vgw94g247jd5vswkn7rls35y2gc\",\r\n            \"amount\": 15000000000,\r\n            \"asset\": \"xch\"\r\n        },\r\n        {\r\n            \"address\": \"xch120ywvwahucfptkeuzzdpdz5v0nnarq5vgw94g247jd5vswkn7rls35y2gc\",\r\n            \"amount\": 15,\r\n            \"asset\": \"a628c1c2c6fcb74d53746157e438e108eab5c0bb3e5c80ff9b1910b3e4832913\"\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<NftCalculateRoyalties_RPC> helper = new Test_RPCClasses<NftCalculateRoyalties_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<NftCalculateRoyalties_RPC> helper = new Test_RPCClasses<NftCalculateRoyalties_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<NftCalculateRoyalties_Response> helper = new Test_ResponseClasses<NftCalculateRoyalties_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<NftCalculateRoyalties_Response> helper = new Test_ResponseClasses<NftCalculateRoyalties_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
