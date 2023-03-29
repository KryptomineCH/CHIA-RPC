using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftGetWalletsWithDids
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"nft_wallets\": [\r\n        {\r\n            \"did_id\": \"did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5\",\r\n            \"did_wallet_id\": 2,\r\n            \"wallet_id\": 5\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<NftGetWalletsWithDIDs_Response> helper = new Test_ResponseClasses<NftGetWalletsWithDIDs_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<NftGetWalletsWithDIDs_Response> helper = new Test_ResponseClasses<NftGetWalletsWithDIDs_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
