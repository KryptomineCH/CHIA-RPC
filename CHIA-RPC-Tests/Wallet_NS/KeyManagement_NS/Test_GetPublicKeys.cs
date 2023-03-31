using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.KeyManagement;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_GetPublicKeys
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"public_key_fingerprints\": [\r\n        2104826454,\r\n        3792481086,\r\n        2818719465,\r\n        2121994410\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetPublicKeys_Response> helper = new Test_ResponseClasses<GetPublicKeys_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetPublicKeys_Response> helper = new Test_ResponseClasses<GetPublicKeys_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
