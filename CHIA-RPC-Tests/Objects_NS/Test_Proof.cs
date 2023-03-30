using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Proof
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"normalized_to_identity\": false,\r\n  \"witness\": \"0x0100b2958c29235fdf94a0b7476e039267d5d5d833f21b7af28c4e0aefde3767a9036523c67fc58706a1d1e91fd52e8f70db9a3401ff2e204c3ada572639d8fc966c990ccd7d8173ae4960e6ca05634c2ded08494e2c7a62d31684285db44ad0783f01000000000000170750a098e503259a8c08ec6a4192f1c9a950d09bb9ce43c4b9b3409420a519eca6c2650200549e022e2ce20e815b4a7a3ad376d173a78a8f0dc55022ce2a9d823495e9e719cd872a3c3e76a8b262e7c2650e6009a6f9b93434b228dbeb667a1d33b6a6b30051c7a00637cfcc6907269f0db89695a9a26bf1a63a13f01b23168795a5593e012b1d00000000004515f0a167be06b340921afd1dc019299dcebc42eeb906f3bffb86e740d190c09185b1c102000e7762337db196427682b5927617a0cfd7378f4d4bd434a62e19bd2e60f8bde267a5742a837351d5bac3ecc5ed2fd915a2caf1ac06061e90ed61f22b26a37034a5e7a631342184de9e218e1d7ff07640bc07ce2889efd082bd3ca11c8e80a74f0100\",\r\n  \"witness_type\": 2\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Proof> helper = new Test_ObjectClasses<Proof>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Proof> helper = new Test_ObjectClasses<Proof>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
