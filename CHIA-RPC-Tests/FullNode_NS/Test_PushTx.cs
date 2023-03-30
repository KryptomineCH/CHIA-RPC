using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_PushTx
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\r\n    \"spend_bundle\": {\r\n    \"aggregated_signature\": \"0xa5e5ea1f5ae2335a72fe0a7ed7ca39e8f142e2e1f6e37a348482290e88eb9cea2d973acf6145e34d0afeee7ba22f99850641e21a549b2c092bb49aa393acd938825bccca9413c1a268ba44367bc8433cd0fc0eb82e87bebe23817aa695bdb566\",\r\n    \"coin_spends\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000004082\",\r\n                \"puzzle_hash\": \"0x94c6db00186900418ef7c1f05e127ee1a647cbe6e514ec3bc57acb7bbe6dfb10\"\r\n            },\r\n            \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0aec9c2e5984fe928406abca942d55ec6b56340af8315bfefa55889dbaade669b9fd3f330af2af44c2a0626d383e64757ff018080\",\r\n            \"solution\": \"0xff80ffff01ffff33ffa03fa549a708302b401c45cf387f8f03b4f76b7c9eabf567bea974f61dedf721e0ff840098968080ffff33ffa055b9fe4c9ce0cef8ad574bf5a9158dc0db7848b96be1a98ab2806d8f0a376a08ff860197738845808080ff8080\"\r\n        }\r\n    ]\r\n  }\r\n}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\"status\": \"SUCCESS\", \"success\": true}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<PushTx_RPC> helper = new Test_RPCClasses<PushTx_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<PushTx_RPC> helper = new Test_RPCClasses<PushTx_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<PushTx_Response> helper = new Test_ResponseClasses<PushTx_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<PushTx_Response> helper = new Test_ResponseClasses<PushTx_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
