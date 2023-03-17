using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_ChallengeVdfOutput
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"data\": \"0x01001ea29503859966e59024fb3a903e424a1652e724483b86928febca5e308d7039b7138847e436e5f1ba5f6c025f6c6ff275c070149079877463aa077f571d0706516723eaa51113c8ec624a005dc73704fcccefa26bb0eefbb9af15eb5c61b6090201\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<ChallengeVdfOutput> helper = new Test_ObjectClasses<ChallengeVdfOutput>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<ChallengeVdfOutput> helper = new Test_ObjectClasses<ChallengeVdfOutput>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
