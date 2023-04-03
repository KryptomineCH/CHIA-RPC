using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetCatList
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"cat_list\": [\r\n        {\r\n            \"asset_id\": \"a628c1c2c6fcb74d53746157e438e108eab5c0bb3e5c80ff9b1910b3e4832913\",\r\n            \"name\": \"Spacebucks\",\r\n            \"symbol\": \"SBX\"\r\n        },\r\n        {\r\n            \"asset_id\": \"8ebf855de6eb146db5602f0456d2f0cbe750d57f821b6f91a8592ee9f1d4cf31\",\r\n            \"name\": \"Marmot\",\r\n            \"symbol\": \"MRMT\"\r\n        },\r\n        {\r\n            \"asset_id\": \"6d95dae356e32a71db5ddcb42224754a02524c615c5fc35f568c2af04774e589\",\r\n            \"name\": \"Stably USD\",\r\n            \"symbol\": \"USDS\"\r\n        },\r\n        {\r\n            \"asset_id\": \"509deafe3cd8bbfbb9ccce1d930e3d7b57b40c964fa33379b18d628175eb7a8f\",\r\n            \"name\": \"Chia Holiday 2021 Token\",\r\n            \"symbol\": \"CH21\"\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetCatList_Response> helper = new Test_ResponseClasses<GetCatList_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetCatList_Response> helper = new Test_ResponseClasses<GetCatList_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
