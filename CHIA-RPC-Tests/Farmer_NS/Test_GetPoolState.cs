using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetPoolState
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"pool_state\": [\r\n        {\r\n            \"authentication_token_timeout\": 5,\r\n            \"current_difficulty\": 1,\r\n            \"current_points\": 0,\r\n            \"next_farmer_update\": 1677651891.2115443,\r\n            \"next_pool_info_update\": 1677655190.955341,\r\n            \"p2_singleton_puzzle_hash\": \"f5daa5a0d83c6a628782a386aa1f94ff041e29c4da4b9b97f91f4d46563d8e9b\",\r\n            \"plot_count\": 0,\r\n            \"points_acknowledged_24h\": [],\r\n            \"points_acknowledged_since_start\": 0,\r\n            \"points_found_24h\": [],\r\n            \"points_found_since_start\": 0,\r\n            \"pool_config\": {\r\n                \"launcher_id\": \"0x55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8\",\r\n                \"owner_public_key\": \"0xb5ab4fb9ef69ac933868ef951fe7a78557ca334ff356b8eb79790ceb18ed4687ca78b96b0144c9d507d650905d7b98d9\",\r\n                \"p2_singleton_puzzle_hash\": \"0xf5daa5a0d83c6a628782a386aa1f94ff041e29c4da4b9b97f91f4d46563d8e9b\",\r\n                \"payout_instructions\": \"716f88dcadafa320d840aad02799a500fe4d01831dab6c0a47bb61f6451ad557\",\r\n                \"pool_url\": \"https://asia1.pool.space\",\r\n                \"target_puzzle_hash\": \"0x2f2c9ba1b2315d413a92b5f034fa03282ccba1767fd9ae7b14d942b969ed5d57\"\r\n            },\r\n            \"pool_errors_24h\": [\r\n                {\r\n                    \"error_code\": 10,\r\n                    \"error_message\": \"Farmer with launcher_id 55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8 unknown.\"\r\n                },\r\n                {\r\n                    \"error_code\": 10,\r\n                    \"error_message\": \"Farmer with launcher_id 55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8 unknown.\"\r\n                }\r\n            ]\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetPoolState_Response> helper = new Test_ResponseClasses<GetPoolState_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetPoolState_Response> helper = new Test_ResponseClasses<GetPoolState_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
