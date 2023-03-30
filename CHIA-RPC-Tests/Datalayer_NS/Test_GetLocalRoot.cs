using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetLocalRoot
    {

        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"hash\": \"0xcdb172490d2d1838e7cca24e28e2089ccbacf0e03b0f3d0a61eedae8462b3e75\",\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetLocalRoot_Response> helper = new Test_ResponseClasses<GetLocalRoot_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetLocalRoot_Response> helper = new Test_ResponseClasses<GetLocalRoot_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
