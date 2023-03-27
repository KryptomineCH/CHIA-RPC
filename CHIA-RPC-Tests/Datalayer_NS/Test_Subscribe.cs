using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_Subscribe
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"8f6ed792bbbf5216f8e55064793f74ce01286b9c1d542cc4a357cf7f8712df1d\", \"urls\":[]}",
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<Subscribe_RPC> helper = new Test_RPCClasses<Subscribe_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<Subscribe_RPC> helper = new Test_RPCClasses<Subscribe_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
    }
}
