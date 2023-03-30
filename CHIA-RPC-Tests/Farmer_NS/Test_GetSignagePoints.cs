using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetSignagePoints
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"signage_points\": [\r\n        {\r\n            \"proofs\": [],\r\n            \"signage_point\": {\r\n                \"challenge_chain_sp\": \"0xe7bff062bcddd480852422d6e1db0af6ff8db96959dd06300cb6f9768ac62fc9\",\r\n                \"challenge_hash\": \"0xdce6ce932f790f1846e7875ac9899036920672ec38f542ea148f5718a56870bd\",\r\n                \"difficulty\": 1992,\r\n                \"reward_chain_sp\": \"0x217cb43d129f0576d5e0aeb6dd4946c2786619b8cbd4ca0f784357862e1bef45\",\r\n                \"signage_point_index\": 39,\r\n                \"sub_slot_iters\": 147849216\r\n            }\r\n        },\r\n        {\r\n            \"proofs\": [],\r\n            \"signage_point\": {\r\n                \"challenge_chain_sp\": \"0x98fefcd637299a9d7fb923b68adcac0f5ead98d7f76e1cbc629c9498b80a4ce7\",\r\n                \"challenge_hash\": \"0xdce6ce932f790f1846e7875ac9899036920672ec38f542ea148f5718a56870bd\",\r\n                \"difficulty\": 1992,\r\n                \"reward_chain_sp\": \"0xea03892b3ff17926ec55f9b002c5a57b399cc3150d847db44165fae2d1d016c2\",\r\n                \"signage_point_index\": 40,\r\n                \"sub_slot_iters\": 147849216\r\n            }\r\n        },\r\n        {\r\n            \"proofs\": [],\r\n            \"signage_point\": {\r\n                \"challenge_chain_sp\": \"0x94157672db825df25a3d9d6860785716c3a01678430ba92a7aaaa5d8b2ab81df\",\r\n                \"challenge_hash\": \"0xdce6ce932f790f1846e7875ac9899036920672ec38f542ea148f5718a56870bd\",\r\n                \"difficulty\": 1992,\r\n                \"reward_chain_sp\": \"0xd23c76d3d308b58657a2b6d847056d607aa0bd474ab6049b0ddf83f9f3ccfbec\",\r\n                \"signage_point_index\": 41,\r\n                \"sub_slot_iters\": 147849216\r\n            }\r\n        },\r\n        {\r\n            \"proofs\": [],\r\n            \"signage_point\": {\r\n                \"challenge_chain_sp\": \"0xe213a89280cb67644a196e84d16241117844e31f4b7eac199c6743adc37b0282\",\r\n                \"challenge_hash\": \"0x2544de1fe6a12f6cd11241accf858a29fc5d8540d78afb8f872798533a51043b\",\r\n                \"difficulty\": 1992,\r\n                \"reward_chain_sp\": \"0xa4e51e9db27b1594c38cac43d86bcb58db5e3fe3b8623325526369ca61558fe0\",\r\n                \"signage_point_index\": 38,\r\n                \"sub_slot_iters\": 147849216\r\n            }\r\n        },\r\n        {\r\n            \"proofs\": [],\r\n            \"signage_point\": {\r\n                \"challenge_chain_sp\": \"0xed7eb2541620e7fdf77233a8ea2b31eceb1ccb79be04c090da03b8a9debc5569\",\r\n                \"challenge_hash\": \"0x2544de1fe6a12f6cd11241accf858a29fc5d8540d78afb8f872798533a51043b\",\r\n                \"difficulty\": 1992,\r\n                \"reward_chain_sp\": \"0x00ea6a98f662e1d5b3187c8fbec1a68aae048a9eb790cdac2e8383b6dfdffc29\",\r\n                \"signage_point_index\": 39,\r\n                \"sub_slot_iters\": 147849216\r\n            }\r\n        }\r\n    ],\r\n    \"success\": true\r\n}        "
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetSignagePoints_Response> helper = new Test_ResponseClasses<GetSignagePoints_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetSignagePoints_Response> helper = new Test_ResponseClasses<GetSignagePoints_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
