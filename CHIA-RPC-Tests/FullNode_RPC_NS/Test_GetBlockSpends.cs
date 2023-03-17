using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetBlockSpends
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"block_spends\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 1,\r\n        \"parent_coin_info\": \"0xd75976eb5837b2c91778f47d5ad8d2972d9cbd854627940aa5df3dd51e08bb5a\",\r\n        \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n      },\r\n      \"puzzle_reveal\": \"0xff02ffff01ff04ffff04ff04ffff04ff05ffff04ff0bff80808080ffff04ffff04ff0affff04ffff02ff0effff04ff02ffff04ffff04ff05ffff04ff0bffff04ff17ff80808080ff80808080ff808080ff808080ffff04ffff01ff33ff3cff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff0effff04ff02ffff04ff09ff80808080ffff02ff0effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080\",\r\n      \"solution\": \"0xffa07418054c549480839e77b4d16d8766c76f826936ddda3c9d93a8cc7687e5897bff01ff8080\"\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetBlockSpends_Response> helper = new Test_ResponseClasses<GetBlockSpends_Response>();
            helper.Test_ResponseSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetBlockSpends_Response> helper = new Test_ResponseClasses<GetBlockSpends_Response>();
            helper.Test_ResponseDiskIO(ExpectedResults);
        }
    }
}
