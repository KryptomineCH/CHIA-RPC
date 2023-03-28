using CHIA_RPC.Farmer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetPoolLoginLink
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"login_link\": \"https://asia1.pool.space/login?launcher_id=55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8&authentication_token=5592184&signature=a529ccabdadb2f3cdb1dcefe8f3f609ab512d5a2b871e85e779d21329f593b1d1b95f6978483c09cf414f74d239c973e19d37b676eff11d019cc1f5849cf00e1b886f2d1c1520cf41ea9b7134ce599c67b216dcaa1bb226bbcf0a799f3c88554\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<LauncherID_RPC> helper = new Test_RPCClasses<LauncherID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<LauncherID_RPC> helper = new Test_RPCClasses<LauncherID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetPoolLoginLink_Response> helper = new Test_ResponseClasses<GetPoolLoginLink_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetPoolLoginLink_Response> helper = new Test_ResponseClasses<GetPoolLoginLink_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
