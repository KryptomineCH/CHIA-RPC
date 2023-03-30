using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetNetworkInfo
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"network_name\": \"mainnet\",\r\n    \"network_prefix\": \"xch\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetNetworkInfo_Response> helper = new Test_ResponseClasses<GetNetworkInfo_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetNetworkInfo_Response> helper = new Test_ResponseClasses<GetNetworkInfo_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
