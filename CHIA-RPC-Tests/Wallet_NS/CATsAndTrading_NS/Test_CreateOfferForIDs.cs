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

        [Fact]
        public void Test_RPCSerialisation()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#create_offer_for_idse is empty");
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#create_offer_for_idse is empty");
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#create_offer_for_idse is empty");
            Test_ResponseClasses<CatGetAssetId_Response> helper = new Test_ResponseClasses<CatGetAssetId_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            throw new NotImplementedException("documentation at https://docs.chia.net/wallet-rpc#create_offer_for_idse is empty");
            Test_ResponseClasses<CatGetAssetId_Response> helper = new Test_ResponseClasses<CatGetAssetId_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
