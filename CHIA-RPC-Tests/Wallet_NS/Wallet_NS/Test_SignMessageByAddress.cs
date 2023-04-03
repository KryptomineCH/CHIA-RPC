using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_SignMessageByAddress
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"address\":\"xch1q94gd4hd62ecx08d0kuagmp5cr8umrwtcvatfupmd7uyzhuf4c4sy2zd46\", \"message\":\"test\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"pubkey\": \"814612ec24a4957cf38ee5f5d5bc544820575375d7997da12c07f3f09215a178cfa76f151edba4c0ae40b66a97a6275e\",\r\n    \"signature\": \"a10234b38cc962f9678882f18885fee23a288c389bc0145588f7000bca12b55fcfaffff0cdd4ef7f136f8aab571ddd2e089b281ae267347fb20225d86490e91fbedad59ba9d38f9308f251070ea1260909dd69133273a49650749cfe6ff96d40\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SignMessageByAddress_RPC> helper = new Test_RPCClasses<SignMessageByAddress_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SignMessageByAddress_RPC> helper = new Test_RPCClasses<SignMessageByAddress_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<SignMessage_Response> helper = new Test_ResponseClasses<SignMessage_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
