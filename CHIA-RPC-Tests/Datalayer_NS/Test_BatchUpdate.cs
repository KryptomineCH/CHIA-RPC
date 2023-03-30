using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_BatchUpdate
    {
        private string[] ExpectedRPCResults = new string[]
        {
            // insert single
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"changelist\":[{\"action\":\"insert\", \"key\":\"0003\", \"value\":\"abc123\"}]}",
            // delete single
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"changelist\":[{\"action\":\"delete\", \"key\":\"0003\"}]}",
            // insert multi
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"changelist\":[{\"action\":\"insert\", \"key\":\"0x0004\", \"value\":\"123abc\"},{\"action\":\"insert\", \"key\":\"0005\", \"value\":\"0xbeadfeed\"}]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"tx_id\": \"0xc4fb487f6506129c17283c30f553c9a767298330636e8bd1f7ea2311e183ed1e\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<BatchUpdate_RPC> helper = new Test_RPCClasses<BatchUpdate_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<BatchUpdate_RPC> helper = new Test_RPCClasses<BatchUpdate_RPC>();
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
            Test_ResponseClasses<CreateDataStore_Response> helper = new Test_ResponseClasses<CreateDataStore_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
