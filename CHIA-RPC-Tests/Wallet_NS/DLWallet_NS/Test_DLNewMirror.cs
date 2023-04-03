using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLNewMirror
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\", \"urls\":[\"http://www.example.com:8575\", \"http://www.example2.com:8575\"], \"amount\":10, \"fee\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"transactions\": [\r\n        {\r\n            \"additions\": [\r\n                {\r\n                    \"amount\": 10,\r\n                    \"parent_coin_info\": \"0x33a7cfa39f9dd223833df0f1f35f2dc17d922b094395b1b9dfe7c0eae3150c1d\",\r\n                    \"puzzle_hash\": \"0x03c8adaf87e5af0e4087c9b5271feff4d17f33b68fba84bf1c0846f4e649abee\"\r\n                },\r\n                {\r\n                    \"amount\": 99978,\r\n                    \"parent_coin_info\": \"0x33a7cfa39f9dd223833df0f1f35f2dc17d922b094395b1b9dfe7c0eae3150c1d\",\r\n                    \"puzzle_hash\": \"0xecc03bb1f7d2c27f56baa9829630980a2cb2d0db426b09b677b3e5efdf7ce7c2\"\r\n                }\r\n            ],\r\n            \"amount\": 10,\r\n            \"confirmed\": false,\r\n            \"confirmed_at_height\": 0,\r\n            \"created_at_time\": 1669355484,\r\n            \"fee_amount\": 1,\r\n            \"memos\": {\r\n                \"a6f36cf305c59db988ee0c1c39546ae9577ce75fd9cabe18cdacf94d8168077b\": \"687474703a2f2f7777772e6578616d706c65322e636f6d3a38353735\"\r\n            },\r\n            \"name\": \"0x7f4560f9c058ac0801cf95003f0fc18d3ddb07e2b9d8ce1e4d947494b4b084cd\",\r\n            \"removals\": [\r\n                {\r\n                    \"amount\": 99989,\r\n                    \"parent_coin_info\": \"0x5bf3b9607bfa60958b6d2a7f3c6a28f3dcc7f9081a0dd95d361cff3ca970658d\",\r\n                    \"puzzle_hash\": \"0xf7bf0a56b4883b42f5999fd7237300b33a541f8b92be02868483d073506098e0\"\r\n                }\r\n            ],\r\n            \"sent\": 0,\r\n            \"sent_to\": [],\r\n            \"spend_bundle\": {\r\n                \"aggregated_signature\": \"0x98cf9cae8b45172d9aeec0aeeffe52fb78530f62f056e140f172e1893d25e2c38e6e2584b912e6b6f7c60a53ccfe21f2034008730a53655beab4d7379f198a43bb337ed332e2a60f1f3dedda459145c2c56f59bf6aa73d993e4cc578706d2f3b\",\r\n                \"coin_spends\": [\r\n                    {\r\n                        \"coin\": {\r\n                            \"amount\": 99989,\r\n                            \"parent_coin_info\": \"0x5bf3b9607bfa60958b6d2a7f3c6a28f3dcc7f9081a0dd95d361cff3ca970658d\",\r\n                            \"puzzle_hash\": \"0xf7bf0a56b4883b42f5999fd7237300b33a541f8b92be02868483d073506098e0\"\r\n                        },\r\n                        \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0b326638c42fcc6ebb926ecf1bbd1ea7e12adfdf338a3b2ee5f45711076d27abf3583f8b33d6cad56c8008b95c129d38dff018080\",\r\n                        \"solution\": \"0xff80ffff01ffff33ffa003c8adaf87e5af0e4087c9b5271feff4d17f33b68fba84bf1c0846f4e649abeeff0affffa04aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09eff9b687474703a2f2f7777772e6578616d706c652e636f6d3a38353735ff9c687474703a2f2f7777772e6578616d706c65322e636f6d3a383537358080ffff33ffa0ecc03bb1f7d2c27f56baa9829630980a2cb2d0db426b09b677b3e5efdf7ce7c2ff8301868a80ffff34ff0180ffff3cffa0cd6be8c3889bc01d161e53c75cf56934c38499725c22cf54f8646bafea0d82648080ff8080\"\r\n                    }\r\n                ]\r\n            },\r\n            \"to_address\": \"xch1q0y2mtu8ukhsusy8ex6jw8l07ngh7vak37agf0cuppr0fejf40hq5u7ds7\",\r\n            \"to_puzzle_hash\": \"0x03c8adaf87e5af0e4087c9b5271feff4d17f33b68fba84bf1c0846f4e649abee\",\r\n            \"trade_id\": null,\r\n            \"type\": 1,\r\n            \"wallet_id\": 1\r\n        }\r\n    ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DlNewMirror_RPC> helper = new Test_RPCClasses<DlNewMirror_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlNewMirror_RPC> helper = new Test_RPCClasses<DlNewMirror_RPC>();
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
