﻿using CHIA_RPC.General_NS;
using CHIA_RPC.Harvester_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Harvester_NS
{
    public class Test_AddPlotDirectory
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"dirname\": \"/plots_new\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<AddPlotDirectory_RPC> helper = new Test_RPCClasses<AddPlotDirectory_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DeletePlot_RPC> helper = new Test_RPCClasses<DeletePlot_RPC>();
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
