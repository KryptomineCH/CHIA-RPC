using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_CreateOfferForIDs
    {
        private string[] ExpectedRPCResults = new string[]
        {
            ""
        };
        string[] ExpectedResponseResults = new string[]
        {
            ""
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc/#create_offer_for_idse, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc/#create_offer_for_idse, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc/#create_offer_for_idse, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<CatGetAssetId_Response> helper = new Test_ResponseClasses<CatGetAssetId_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc/#create_offer_for_idse, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CatGetAssetId_Response> helper = new Test_ResponseClasses<CatGetAssetId_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
