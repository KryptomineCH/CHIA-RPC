using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_SignMessageByID
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"nft12dfld077vn3ywp4vdx9ljg96k89kpr6jlqwkm7lgaf3g8jwn2l4q6eytqs\", \"message\":\"test\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"pubkey\": \"a5b35d3370745ae7634022ddd970379b4ed4acdd2d34622f1dfdf2b9923b16ac6e8b317abcf1cc8beb1e882d341e4458\",\r\n    \"signature\": \"843deb871383889bfb8b9b22c0137e9b12cef875e27c998a3def6aa13c9340e2036ae90bbbb9a78894572319bf0fedbc08057849882ca6723834a99bf0e97a5e9f9702c5a02a64434b3550922c488f957036d19af2be2c92eb84c1d5d4f8eba6\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SignMessageByID_RPC> helper = new Test_RPCClasses<SignMessageByID_RPC>();
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
