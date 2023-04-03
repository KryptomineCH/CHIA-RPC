﻿using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_CatSetName
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 2, \"name\": \"New CAT Wallet\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"wallet_id\": 2\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CatSetName_RPC> helper = new Test_RPCClasses<CatSetName_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CatSetName_RPC> helper = new Test_RPCClasses<CatSetName_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
