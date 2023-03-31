using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.KeyManagement;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_GetPrivateKey
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"fingerprint\": 2818719465}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"private_key\": {\r\n        \"farmer_pk\": \"8c65856685323f149a651e6cbe068ece36f87a84efa16246b0eef65ac586a30fb678878bd4364d52c432fbb77838cbf6\",\r\n        \"fingerprint\": 2473794447,\r\n        \"pk\": \"b73cf2471b10a7ba839616aff0ab1cb319d9d3a77ee26ff88ec1c8e645468eb0b7653518b85e5dd0df7cf50d8612b978\",\r\n        \"pool_pk\": \"845ff087376ffecf83950485d63ffed1cc73f36daf018deb4fbd2f05e7198b07521486274d82ecc4f5a2eaae63dfd0a7\",\r\n        \"seed\": \"arrest legend bounce attend rebel blade palace bean dry shell nice bubble coil cook token nerve visa december hero garment grid attend nerve certain\",\r\n        \"sk\": \"0665913196501420c0fe2de6b5ce7b25f749d52dcbf997b069bb2ea8438c6c3c\"\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<FingerPrint_RPC> helper = new Test_RPCClasses<FingerPrint_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<FingerPrint_RPC> helper = new Test_RPCClasses<FingerPrint_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetPrivateKey_Response> helper = new Test_ResponseClasses<GetPrivateKey_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetPrivateKey_Response> helper = new Test_ResponseClasses<GetPrivateKey_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
