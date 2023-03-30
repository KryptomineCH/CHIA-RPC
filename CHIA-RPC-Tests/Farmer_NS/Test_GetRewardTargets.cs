using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetRewardTargets
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"search_for_private_key\": false}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"farmer_target\": \"xch1xdm7s8fq4kdrq28lulnhxcxq8h6gcsf0y5j643vqx4ec3z9dhq7sqxsa9j\",\r\n    \"pool_target\": \"xch1xdm7s8fq4kdrq28lulnhxcxq8h6gcsf0y5j643vqx4ec3z9dhq7sqxsa9j\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetRewardTargets_RPC> helper = new Test_RPCClasses<GetRewardTargets_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetRewardTargets_RPC> helper = new Test_RPCClasses<GetRewardTargets_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetRewardTargets_Response> helper = new Test_ResponseClasses<GetRewardTargets_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRewardTargets_Response> helper = new Test_ResponseClasses<GetRewardTargets_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
