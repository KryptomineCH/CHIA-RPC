using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLDeleteMirror
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"coin_id\": \"a6f36cf305c59db988ee0c1c39546ae9577ce75fd9cabe18cdacf94d8168077b\", \"fee\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"transactions\": [\r\n        {\r\n            \"additions\": [\r\n                {\r\n                    \"amount\": 9,\r\n                    \"parent_coin_info\": \"0xa6f36cf305c59db988ee0c1c39546ae9577ce75fd9cabe18cdacf94d8168077b\",\r\n                    \"puzzle_hash\": \"0x23e9be9739546282f50c10cbcd39c36c4f20452721e845c4d0775f61f587749e\"\r\n                }\r\n            ],\r\n            \"amount\": 10,\r\n            \"confirmed\": false,\r\n            \"confirmed_at_height\": 0,\r\n            \"created_at_time\": 1669356270,\r\n            \"fee_amount\": 1,\r\n            \"memos\": {},\r\n            \"name\": \"0x92b71646dbcbc713ceb073618e8043d24defc514285aaffaae4037d14e4bd899\",\r\n            \"removals\": [\r\n                {\r\n                    \"amount\": 10,\r\n                    \"parent_coin_info\": \"0x33a7cfa39f9dd223833df0f1f35f2dc17d922b094395b1b9dfe7c0eae3150c1d\",\r\n                    \"puzzle_hash\": \"0x03c8adaf87e5af0e4087c9b5271feff4d17f33b68fba84bf1c0846f4e649abee\"\r\n                }\r\n            ],\r\n            \"sent\": 10,\r\n            \"sent_to\": [],\r\n            \"spend_bundle\": {\r\n                \"aggregated_signature\": \"0x876c9a74397d4fcec257662eea48d29c10c72dc53ca723313c7be2d447ce8b7b41a30e937827e9def691fe9fca442a1707139c802a47389dd9287b0ab8d60d91917d0f309fcb8661f13239554492a9262ab7b7bafdb6ee8d01f01258010d4547\",\r\n                \"coin_spends\": [\r\n                    {\r\n                        \"coin\": {\r\n                            \"amount\": 10,\r\n                            \"parent_coin_info\": \"0x33a7cfa39f9dd223833df0f1f35f2dc17d922b094395b1b9dfe7c0eae3150c1d\",\r\n                            \"puzzle_hash\": \"0x03c8adaf87e5af0e4087c9b5271feff4d17f33b68fba84bf1c0846f4e649abee\"\r\n                        },\r\n                        \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff04ffff04ff08ffff04ffff02ff0affff04ff02ffff04ff0bffff04ffff02ff05ffff02ff0effff04ff02ffff04ff17ff8080808080ffff04ff2fff808080808080ff808080ffff02ff17ff5f8080ffff04ffff01ffff4720ffff02ffff03ffff22ffff09ffff0dff0580ff0c80ffff09ffff0dff0b80ff0c80ffff15ff17ffff0181ff8080ffff01ff0bff05ff0bff1780ffff01ff088080ff0180ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff0effff04ff02ffff04ff09ff80808080ffff02ff0effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff0101ff018080\",\r\n                        \"solution\": \"0xffa05bf3b9607bfa60958b6d2a7f3c6a28f3dcc7f9081a0dd95d361cff3ca970658dffff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0b326638c42fcc6ebb926ecf1bbd1ea7e12adfdf338a3b2ee5f45711076d27abf3583f8b33d6cad56c8008b95c129d38dff018080ff83018695ffff80ffff01ffff33ffa023e9be9739546282f50c10cbcd39c36c4f20452721e845c4d0775f61f587749eff098080ff808080\"\r\n                    }\r\n                ]\r\n            },\r\n            \"to_address\": \"xch1y05ma9ee233g9agvzr9u6wwrd38jq3f8y85yt3xswa0krav8wj0qlf7xxw\",\r\n            \"to_puzzle_hash\": \"0x23e9be9739546282f50c10cbcd39c36c4f20452721e845c4d0775f61f587749e\",\r\n            \"trade_id\": null,\r\n            \"type\": 1,\r\n            \"wallet_id\": 8\r\n        }\r\n    ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DlDeleteMirror_RPC> helper = new Test_RPCClasses<DlDeleteMirror_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlDeleteMirror_RPC> helper = new Test_RPCClasses<DlDeleteMirror_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlNewMirror_Response> helper = new Test_ResponseClasses<DlNewMirror_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlNewMirror_Response> helper = new Test_ResponseClasses<DlNewMirror_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
