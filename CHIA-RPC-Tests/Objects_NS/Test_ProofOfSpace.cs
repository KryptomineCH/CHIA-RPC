using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_ProofOfSpace
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"challenge\": \"0xbe68fc3a34f3d2a6bfe329a3c27f390f5ef63ed9fd3373c3fe12e2c6729a98b4\",\r\n  \"plot_public_key\": \"0x90ca70c963f984d138fe4b97b3bade582513b8ddc115c8fd92033c7f3407df91e5d22313e83e80ea6f02c094636197be\",\r\n  \"pool_contract_puzzle_hash\": null,\r\n  \"pool_public_key\": \"0x8ab8f0eb56216b3f7376fb0462b5000b26f38461dc48f455a98581cec09f889b7c0b38eb42b9e2e2d7edd47d61da13d6\",\r\n  \"proof\": \"0xd1d823b917e7d493ae7bf14ad5fd045ca836bd2b3e97a34efcdc87c2aa4d335b9693c635997f559a2b17ddb7fd87cf352cc8a4a000ecfaaec516a52d7af17a775fff055b7f0f9018f2f6a27d36844f5381197fca792c668207bf7e3927c3f7a8d5854173e134dae95f51ab65f052fbf05b7f6fb046f3309589d6213c713a46a263dc3c2fdda2c7fc7236621e2a6b1164e4b6440aaa6ed403645753e1fb96629d0b7fd80236caad7be571aa1a6fbbfbee9380535e44bc8fac3ef5717e4ad93e3db5e60c617950d966b045ac20401f563a00069ec0052d9145f2f7d16311899d43abbb8b1eb60bcbb33fe82f7ec3c881afd47b16b1a3a34ac23e6a26c013c4e858\",\r\n  \"size\": 32\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<ProofOfSpace> helper = new Test_ObjectClasses<ProofOfSpace>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<ProofOfSpace> helper = new Test_ObjectClasses<ProofOfSpace>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
