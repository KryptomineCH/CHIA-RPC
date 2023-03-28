using CHIA_RPC.Farmer_NS;
using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetSignagePoint
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"sp_hash\": \"0xd1d48067e1a355e69808201db516008c3d71c88d8c07fcee7c790f725e56e9ac\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"proofs\": [],\r\n    \"signage_point\": {\r\n        \"challenge_chain_sp\": \"0xd1d48067e1a355e69808201db516008c3d71c88d8c07fcee7c790f725e56e9ac\",\r\n        \"challenge_hash\": \"0xd1d48067e1a355e69808201db516008c3d71c88d8c07fcee7c790f725e56e9ac\",\r\n        \"difficulty\": 1992,\r\n        \"reward_chain_sp\": \"0x0be5727cfe27822fc45852f983c6eee96d2160566eb7b6a18c7c92154ee01fbb\",\r\n        \"signage_point_index\": 0,\r\n        \"sub_slot_iters\": 147849216\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetSignagePoint_RPC> helper = new Test_RPCClasses<GetSignagePoint_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetSignagePoint_RPC> helper = new Test_RPCClasses<GetSignagePoint_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<SignagePointWithProofs> helper = new Test_ResponseClasses<SignagePointWithProofs>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<SignagePointWithProofs> helper = new Test_ResponseClasses<SignagePointWithProofs>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
