using CHIA_RPC.Wallet_NS.WalletNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.WalletNode_NS
{
    public class Test_PushTransactions
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"height\": 2863319,\r\n    \"success\": true\r\n}"
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#push_tx, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetHeightInfo_Response> helper = new Test_ResponseClasses<GetHeightInfo_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#push_tx, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetHeightInfo_Response> helper = new Test_ResponseClasses<GetHeightInfo_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
