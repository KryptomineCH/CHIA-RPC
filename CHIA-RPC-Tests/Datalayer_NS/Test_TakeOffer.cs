using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_TakeOffer
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"offer\": \"596dc917f56ceaf2df17a8cf9672b2e3cd49e2c1432b25834035aafbe063cbae\",\r\n \"fee\": 1000000}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"trade_id\": \"705b5eac32f037e785a72658f1be405799b9149f9a6e0345e3c10b5d9eed0edf\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<TakeOffer_RPC> helper = new Test_RPCClasses<TakeOffer_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<TakeOffer_RPC> helper = new Test_RPCClasses<TakeOffer_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<TradeID_Response> helper = new Test_ResponseClasses<TradeID_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<TradeID_Response> helper = new Test_ResponseClasses<TradeID_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
