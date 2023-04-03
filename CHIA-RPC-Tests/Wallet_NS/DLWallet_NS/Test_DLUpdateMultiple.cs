using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLUpdateMultiple
    {
        private string[] ExpectedRPCResults = new string[]
        {
            ""
        };
        string[] ExpectedResponseResults = new string[]
        {
            ""
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#dl_update_multiple, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<DlDeleteMirror_RPC> helper = new Test_RPCClasses<DlDeleteMirror_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#dl_update_multiple, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlDeleteMirror_RPC> helper = new Test_RPCClasses<DlDeleteMirror_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#dl_update_multiple, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlUpdateRoot_Response> helper = new Test_ResponseClasses<DlUpdateRoot_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#dl_update_multiple, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlUpdateRoot_Response> helper = new Test_ResponseClasses<DlUpdateRoot_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
