using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_Insert
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"key\":\"0001\", \"value\":\"fadedcab\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"tx_id\": \"0xaba9c1a25199acc8e05557527cfe683797b1c8b81d6011cdbb03f80f900febd2\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<Insert_RPC> helper = new Test_RPCClasses<Insert_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<Insert_RPC> helper = new Test_RPCClasses<Insert_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<TxID_Response> helper = new Test_ResponseClasses<TxID_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<TxID_Response> helper = new Test_ResponseClasses<TxID_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
