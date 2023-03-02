using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_NPC
    {
        // npc_result
        [Fact]
        public void Test_NpcResultSerialisation()
        {
            string[] expectedResults = new string[]
            {
                "{\r\n  \"clvm_cost\": 416866,\r\n  \"error\": null,\r\n  \"npc_list\": [\r\n    {\r\n      \"coin_name\": \"0xbf71e1d17630e3793321944b5825b5b573ac28c03113498baae997e0781f0278\",\r\n      \"conditions\": [\r\n        [\r\n          \"0x33\",\r\n          [\r\n            {\r\n              \"opcode\": \"CREATE_COIN\",\r\n              \"vars\": [\r\n                \"0x3be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033d\",\r\n                \"0x00ec8e78e9\",\r\n                \"0x\"\r\n              ]\r\n            }\r\n          ]\r\n        ],\r\n        [\r\n          \"0x32\",\r\n          [\r\n            {\r\n              \"opcode\": \"AGG_SIG_ME\",\r\n              \"vars\": [\r\n                \"0xb44f24f7dae4af24334870c3f291c8a8e4d370fb935f0c30b6d1fee734c229d351fed2a5a87c059049d205a8ec3c8124\",\r\n                \"0xcae8db944550d51ef9eb4bdc297ac7a2ddb759f2e202c13df629abb41cc69290\"\r\n              ]\r\n            }\r\n          ]\r\n        ]\r\n      ],\r\n      \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n    }\r\n  ]\r\n}"
            };
            Test_ObjectClasses<NpcResult> helper = new Test_ObjectClasses<NpcResult>();
            helper.Test_ObjectSerialisation(expectedResults);
        }
        [Fact]
        public void Test_NpcResultDiskIO()
        {
            string[] expectedResults = new string[]
            {
                "{\r\n  \"clvm_cost\": 416866,\r\n  \"error\": null,\r\n  \"npc_list\": [\r\n    {\r\n      \"coin_name\": \"0xbf71e1d17630e3793321944b5825b5b573ac28c03113498baae997e0781f0278\",\r\n      \"conditions\": [\r\n        [\r\n          \"0x33\",\r\n          [\r\n            {\r\n              \"opcode\": \"CREATE_COIN\",\r\n              \"vars\": [\r\n                \"0x3be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033d\",\r\n                \"0x00ec8e78e9\",\r\n                \"0x\"\r\n              ]\r\n            }\r\n          ]\r\n        ],\r\n        [\r\n          \"0x32\",\r\n          [\r\n            {\r\n              \"opcode\": \"AGG_SIG_ME\",\r\n              \"vars\": [\r\n                \"0xb44f24f7dae4af24334870c3f291c8a8e4d370fb935f0c30b6d1fee734c229d351fed2a5a87c059049d205a8ec3c8124\",\r\n                \"0xcae8db944550d51ef9eb4bdc297ac7a2ddb759f2e202c13df629abb41cc69290\"\r\n              ]\r\n            }\r\n          ]\r\n        ]\r\n      ],\r\n      \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n    }\r\n  ]\r\n}"
            };
            Test_ObjectClasses<NpcResult> helper = new Test_ObjectClasses<NpcResult>();
            helper.Test_ObjectDiskIO(expectedResults);
        }
        // npc
        [Fact]
        public void Test_NpcSerialisation()
        {
            string[] expectedResults = new string[]
            {
                "{\r\n  \"coin_name\": \"0xbf71e1d17630e3793321944b5825b5b573ac28c03113498baae997e0781f0278\",\r\n  \"conditions\": [\r\n    [\r\n      \"0x33\",\r\n      [\r\n        {\r\n          \"opcode\": \"CREATE_COIN\",\r\n          \"vars\": [\r\n            \"0x3be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033d\",\r\n            \"0x00ec8e78e9\",\r\n            \"0x\"\r\n          ]\r\n        }\r\n      ]\r\n    ],\r\n    [\r\n      \"0x32\",\r\n      [\r\n        {\r\n          \"opcode\": \"AGG_SIG_ME\",\r\n          \"vars\": [\r\n            \"0xb44f24f7dae4af24334870c3f291c8a8e4d370fb935f0c30b6d1fee734c229d351fed2a5a87c059049d205a8ec3c8124\",\r\n            \"0xcae8db944550d51ef9eb4bdc297ac7a2ddb759f2e202c13df629abb41cc69290\"\r\n          ]\r\n        }\r\n      ]\r\n    ]\r\n  ],\r\n  \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n}"
            };
            Test_ObjectClasses<Npc> helper = new Test_ObjectClasses<Npc>();
            helper.Test_ObjectSerialisation(expectedResults);
        }
        [Fact]
        public void Test_NpcDiskIO()
        {
            string[] expectedResults = new string[]
            {
                "{\r\n  \"coin_name\": \"0xbf71e1d17630e3793321944b5825b5b573ac28c03113498baae997e0781f0278\",\r\n  \"conditions\": [\r\n    [\r\n      \"0x33\",\r\n      [\r\n        {\r\n          \"opcode\": \"CREATE_COIN\",\r\n          \"vars\": [\r\n            \"0x3be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033d\",\r\n            \"0x00ec8e78e9\",\r\n            \"0x\"\r\n          ]\r\n        }\r\n      ]\r\n    ],\r\n    [\r\n      \"0x32\",\r\n      [\r\n        {\r\n          \"opcode\": \"AGG_SIG_ME\",\r\n          \"vars\": [\r\n            \"0xb44f24f7dae4af24334870c3f291c8a8e4d370fb935f0c30b6d1fee734c229d351fed2a5a87c059049d205a8ec3c8124\",\r\n            \"0xcae8db944550d51ef9eb4bdc297ac7a2ddb759f2e202c13df629abb41cc69290\"\r\n          ]\r\n        }\r\n      ]\r\n    ]\r\n  ],\r\n  \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n}"
            };
            Test_ObjectClasses<Npc> helper = new Test_ObjectClasses<Npc>();
            helper.Test_ObjectDiskIO(expectedResults);
        }
    }
}
