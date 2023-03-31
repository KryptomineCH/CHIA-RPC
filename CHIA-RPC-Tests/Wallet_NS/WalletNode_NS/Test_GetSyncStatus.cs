using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.WalletNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.WalletNode_NS
{
    public class Test_GetSyncStatus
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"genesis_initialized\": true,\r\n    \"success\": true,\r\n    \"synced\": true,\r\n    \"syncing\": false\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetSyncStatus_Response> helper = new Test_ResponseClasses<GetSyncStatus_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetSyncStatus_Response> helper = new Test_ResponseClasses<GetSyncStatus_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
