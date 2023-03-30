using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_CreateNewDIDWallet
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_type\": \"did_wallet\", \"did_type\": \"new\", \"amount\": 1, \"backup_dids\": [\"did:chia:13p5fdxgm8e2pngdwp8m088t0etp7rgzx9ye2ju8v5ackcyg7t9nqx2um83\"], \"num_of_backup_ids_needed\": 1, \"fee\": 10000000}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"my_did\": \"did:chia:1pzrm9dyhvu8hmqyzqmy0v3wyp7cn98jlxk49jv7mgkhvk229erhqmh6c2m\",\r\n    \"success\": true,\r\n    \"type\": 8,\r\n    \"wallet_id\": 2\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CreateNewDIDWallet_RPC> helper = new Test_RPCClasses<CreateNewDIDWallet_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CreateNewDIDWallet_RPC> helper = new Test_RPCClasses<CreateNewDIDWallet_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<CreateNewDIDWallet_Response> helper = new Test_ResponseClasses<CreateNewDIDWallet_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CreateNewDIDWallet_Response> helper = new Test_ResponseClasses<CreateNewDIDWallet_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
