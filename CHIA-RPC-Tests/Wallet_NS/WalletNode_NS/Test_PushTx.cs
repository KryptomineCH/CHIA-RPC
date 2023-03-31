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

        [Fact]
        public void Test_ResponseSerialisation()
        {
            throw new NotImplementedException("no documentation on https://docs.chia.net/wallet-rpc#push_tx");
            Test_ResponseClasses<GetHeightInfo_Response> helper = new Test_ResponseClasses<GetHeightInfo_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            throw new NotImplementedException("no documentation on https://docs.chia.net/wallet-rpc#push_tx");
            Test_ResponseClasses<GetHeightInfo_Response> helper = new Test_ResponseClasses<GetHeightInfo_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
