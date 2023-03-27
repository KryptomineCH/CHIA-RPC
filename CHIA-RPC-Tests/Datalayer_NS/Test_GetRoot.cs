using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetRoot
    {

        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"confirmed\": true,\r\n  \"hash\": \"0x75cccd7342e93b5a716877c285282f45b1125c33d3f67cd62a353efdbe4fd9fa\",\r\n  \"success\": true,\r\n  \"timestamp\": 1660623078\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetRoot_Response> helper = new Test_ResponseClasses<GetRoot_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRoot_Response> helper = new Test_ResponseClasses<GetRoot_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
