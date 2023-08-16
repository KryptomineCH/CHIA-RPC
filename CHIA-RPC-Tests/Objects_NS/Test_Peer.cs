using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;
namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Peer
    {
        private string[] ExpectedResults = new string[]
        {
        "[\"91886c69c24a08f0526744f5a3799ba9db35726aadb1d287b10b09b3a84b8589\", 3, \"DOUBLE_SPEND\"]",
        "[\"aeeba19c44d25dae2e03a0e408ed33c40a07ba54e599c62a855cbc2911124c74\", 2, null]"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Peer> helper = new Test_ObjectClasses<Peer>();
            helper.Test_Serialisation(ExpectedResults);
        }

        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Peer> helper = new Test_ObjectClasses<Peer>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}

// Note: I assume that Test_ObjectClasses<T> has methods like Test_Serialisation and Test_DiskIO which handle the generic logic of testing, and you've set them up to work with System.Text.Json. 
