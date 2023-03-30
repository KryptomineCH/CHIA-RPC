using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftTransferNft
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\r\n    \"wallet_id\": 2,\r\n    \"target_address\": \"txch13w2ytvchereqawqjp4r09mqjhwk7unvndew2a400jxtu7q5kr7csqy70f7\",\r\n    \"nft_coin_id\": \"0x2691a4aa3533a3b3ef57cc8f70af22f1238d8961fb6b98b4f48eb34b61dc47b1\",\r\n    \"fee\": 10000000\r\n}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"spend_bundle\": {\r\n    \"aggregated_signature\": \"0xa309c0f92836f8026b7a0ed72db29b6505b11ace1fb2bfb5ab75a32184b50d11ef31f935fd383301bf38fa3d4211e06a0ddc8a27f48f6aa71c73e86a45056066d9ebe71c504494d079eb7cd74e7f7cf2f9e6c193790e3caa8cc7169afe3e320b\",\r\n    \"coin_solutions\": [\r\n      {\r\n        \"coin\": {\r\n          \"amount\": 1,\r\n          \"parent_coin_info\": \"0xa05ac57eb273f459a2b3afd71da2d613d55048d6db25052b399d109e35d8a363\",\r\n          \"puzzle_hash\": \"0x216718e9d29bf4ae4f010aa40d6560369546ebdd67be900e2d94644ec0acb286\"\r\n        },\r\n        \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ffff18ff2fff3c80ffff01ff04ffff04ff10ffff04ff2fff808080ffff04ffff02ff3effff04ff02ffff04ff05ffff04ffff0bff27ffff02ffff03ff77ffff01ff02ff36ffff04ff02ffff04ff09ffff04ff57ffff04ffff02ff2effff04ff02ffff04ff05ff80808080ff808080808080ffff011d80ff0180ffff02ffff03ff77ffff0181b7ffff015780ff018080ffff04ff77ff808080808080ffff02ff26ffff04ff02ffff04ff05ffff04ffff02ff0bff5f80ffff01ff8080808080808080ffff01ff088080ff0180ffff04ffff01ffffff49ff4702ff33ff0401ffff01ff02ff02ffff03ff05ffff01ff02ff3affff04ff02ffff04ff0dffff04ffff0bff2affff0bff3cff2c80ffff0bff2affff0bff2affff0bff3cff1280ff0980ffff0bff2aff0bffff0bff3cff8080808080ff8080808080ffff010b80ff0180ffffff02ffff03ff0bffff01ff02ffff03ffff02ffff03ffff09ff23ff1480ffff01ff02ffff03ffff18ff81b3ff3c80ffff01ff0101ff8080ff0180ff8080ff0180ffff01ff02ffff03ffff20ff1780ffff01ff02ffff03ffff09ff81b3ffff01818f80ffff01ff02ff26ffff04ff02ffff04ff05ffff04ff1bffff04ff3cff808080808080ffff01ff04ffff04ff23ffff04ffff02ff36ffff04ff02ffff04ff09ffff04ff53ffff04ffff02ff2effff04ff02ffff04ff05ff80808080ff808080808080ff738080ffff02ff26ffff04ff02ffff04ff05ffff04ff1bffff04ff3cff8080808080808080ff0180ffff01ff088080ff0180ffff01ff04ff13ffff02ff26ffff04ff02ffff04ff05ffff04ff1bffff04ff17ff8080808080808080ff0180ffff01ff02ffff03ff17ff80ffff01ff088080ff018080ff0180ff0bff2affff0bff3cff3880ffff0bff2affff0bff2affff0bff3cff1280ff0580ffff0bff2affff02ff3affff04ff02ffff04ff07ffff04ffff0bff3cff3c80ff8080808080ffff0bff3cff8080808080ffff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff2effff04ff02ffff04ff09ff80808080ffff02ff2effff04ff02ffff04ff0dff8080808080ffff01ff0bff3cff058080ff0180ff02ffff03ffff21ff17ffff09ff0bff158080ffff01ff04ff28ffff04ff0bff808080ffff01ff088080ff0180ff018080ffff04ffff01ffa0f1e8350cec62f8204aaf867cc3c12cae369f619258206616108c6cfd7be760b3ffa0ba54ae34764b024b3b7a4f0ead65e66e53fbf54d29563f09b360b978ebf9edf1a0eff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9ffff04ffff01ff02ffff01ff02ffff01ff02ff3effff04ff02ffff04ff05ffff04ffff02ff2fff5f80ffff04ff80ffff04ffff04ffff04ff0bffff04ff17ff808080ffff01ff808080ffff01ff8080808080808080ffff04ffff01ffffff0233ff04ff0101ffff02ff02ffff03ff05ffff01ff02ff1affff04ff02ffff04ff0dffff04ffff0bff12ffff0bff2cff1480ffff0bff12ffff0bff12ffff0bff2cff3c80ff0980ffff0bff12ff0bffff0bff2cff8080808080ff8080808080ffff010b80ff0180ffff0bff12ffff0bff2cff1080ffff0bff12ffff0bff12ffff0bff2cff3c80ff0580ffff0bff12ffff02ff1affff04ff02ffff04ff07ffff04ffff0bff2cff2c80ff8080808080ffff0bff2cff8080808080ffff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff2effff04ff02ffff04ff09ff80808080ffff02ff2effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff02ffff03ff0bffff01ff02ffff03ffff09ff23ff1880ffff01ff02ffff03ffff18ff81b3ff2c80ffff01ff02ffff03ffff20ff1780ffff01ff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff33ffff04ff2fffff04ff5fff8080808080808080ffff01ff088080ff0180ffff01ff04ff13ffff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ff2fffff04ff5fff80808080808080808080ff0180ffff01ff02ffff03ffff09ff23ffff0181e880ffff01ff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ffff02ffff03ffff22ffff09ffff02ff2effff04ff02ffff04ff53ff80808080ff82014f80ffff20ff5f8080ffff01ff02ff53ffff04ff818fffff04ff82014fffff04ff81b3ff8080808080ffff01ff088080ff0180ffff01ff0180808080808080ffff01ff04ff13ffff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ff2fffff04ff5fff80808080808080808080ff018080ff0180ffff01ff04ffff04ff18ffff04ffff02ff16ffff04ff02ffff04ff05ffff04ff27ffff04ffff0bff2cff82014f80ffff04ffff02ff2effff04ff02ffff04ff818fff80808080ffff04ffff0bff2cff0580ff8080808080808080ff378080ff81af8080ff0180ff018080ffff04ffff01a031f5e810e2ad078817e8b047306c877ad82c77511aa235179c4a98af413f162affff04ffff01ffff75ffc04468747470733a2f2f696d616765732e706578656c732e636f6d2f70686f746f732f31313035333037322f706578656c732d70686f746f2d31313035333037322e6a70656780ffff68a014836b86a48e1b2b5e857213af97534704475b4c155d34b2cb83ed4b7cba2bb0ffff826d7580ffff826c7580ffff82736e01ffff8273740180ffff04ffff01a0fe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78bffff04ffff01ff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b091f4a1811c7ccdf84207e433bc470ef9aaed1f141960017918fc3427b5e3bbff3513c3023b43a2f8a66d37df12c0aaddff018080ff018080808080ff01808080\",\r\n        \"solution\": \"0xffffa0ba54ae34764b024b3b7a4f0ead65e66e53fbf54d29563f09b360b978ebf9edf1ffa015ee802432d24048a8e32bad8ad006472bb65b720b03c6ba9f38158bea8dbe9bff0180ff01ffffff80ffff01ffff33ffa08b9445b317c8f20eb8120d46f2ec12bbadee4d936e5caed5ef9197cf02961fb1ff01ffffa08b9445b317c8f20eb8120d46f2ec12bbadee4d936e5caed5ef9197cf02961fb18080ffff3cffa02691a4aa3533a3b3ef57cc8f70af22f1238d8961fb6b98b4f48eb34b61dc47b18080ff80808080\"\r\n      },\r\n      {\r\n        \"coin\": {\r\n          \"amount\": 989949999972,\r\n          \"parent_coin_info\": \"0x8df3d521a60a4455b8ad6d1dd675632caa2092eb79c149e6ad20963278a2494f\",\r\n          \"puzzle_hash\": \"0xc10e58ea998df6c27f57d86548ca165e578a31bee643df5deb7295fbf445888c\"\r\n        },\r\n        \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0898ca2b00c017a30e9095dbfd2769a84bbd65cac8b533c209bab34f4b146378643403799ac44fb6bea7b7cc281256336ff018080\",\r\n        \"solution\": \"0xff80ffff01ffff33ffa0a320bb1086818cc3b22a3d3ca45086316d20a0e689b8767a6cf43450152dbfd0ff8600e67d05a4e480ffff34ff840098968080ffff3cffa0b1ae17303885cd04525dbf87678aa78d550eeac21f511d74301cd302daedb88a80ffff3dffa08b58c5ffe8bf9baebd47b4310b89bffe2c9ccd7239135d22b71efbb19c897ec68080ff8080\"\r\n      }\r\n    ]\r\n  },\r\n  \"success\": true,\r\n  \"wallet_id\": 2\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<NftTransferNft_RPC> helper = new Test_RPCClasses<NftTransferNft_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<NftTransferNft_RPC> helper = new Test_RPCClasses<NftTransferNft_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<SpendBundle_Response> helper = new Test_ResponseClasses<SpendBundle_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<SpendBundle_Response> helper = new Test_ResponseClasses<SpendBundle_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
