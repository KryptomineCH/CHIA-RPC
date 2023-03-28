using CHIA_RPC.Farmer_NS;
using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_SetRewardTargets
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"farmer_target\": \"xch1zuedypasfgpa6ltz9nylfyw58js9v88h8g004nd2pcnw3ypv3descqnxpr\", \"pool_target\": \"xch1r826ps2w998ys3getxqearr5qlq6qm60s8rf49p6epjr820l98nqm705cx\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SetRewardTargets_RPC> helper = new Test_RPCClasses<SetRewardTargets_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SetRewardTargets_RPC> helper = new Test_RPCClasses<SetRewardTargets_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
