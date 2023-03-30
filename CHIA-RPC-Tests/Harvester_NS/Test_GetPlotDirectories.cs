using CHIA_RPC.Harvester_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Harvester_NS
{
    public class Test_GetPlotDirectories
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"directories\": [\r\n        \"/plots\",\r\n        \"/plots_new\"\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetPlotDirectories_Response> helper = new Test_ResponseClasses<GetPlotDirectories_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetPlotDirectories_Response> helper = new Test_ResponseClasses<GetPlotDirectories_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
