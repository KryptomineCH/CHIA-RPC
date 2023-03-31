﻿using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_LogIn
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"fingerprint\": 2818719465}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"fingerprint\": 2818719465,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<FingerPrint_RPC> helper = new Test_RPCClasses<FingerPrint_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<FingerPrint_RPC> helper = new Test_RPCClasses<FingerPrint_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<FingerPrint_Response> helper = new Test_ResponseClasses<FingerPrint_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<FingerPrint_Response> helper = new Test_ResponseClasses<FingerPrint_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
