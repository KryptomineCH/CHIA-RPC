using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Spend
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"coin\": {\r\n    \"amount\": 3981342052,\r\n    \"parent_coin_info\": \"0x0252418f0ad7a0009dc055a48a2aaff897f4ea6289b57f1ed9c0d8c7a5b5e6a8\",\r\n    \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n  },\r\n  \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0b44f24f7dae4af24334870c3f291c8a8e4d370fb935f0c30b6d1fee734c229d351fed2a5a87c059049d205a8ec3c8124ff018080\",\r\n  \"solution\": \"0xff80ffff01ffff33ffa057b09fa466e876fed06a697b0b82e237ad81424fa809df8c7f41fbcfcc7fcc25ff8400bffc7b80ffff33ffa03be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033dff8500ec8e78e980ffff3cffa029505509405ab0d47b986bb2456c288dc272b7fecad9a54943db25c26dc03de48080ff8080\"\r\n}"
        };

        [Fact]
        public void Test_SpendSerialisation()
        {
            Test_ObjectClasses<Spend> helper = new Test_ObjectClasses<Spend>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_SpendDiskIO()
        {
            Test_ObjectClasses<Spend> helper = new Test_ObjectClasses<Spend>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
