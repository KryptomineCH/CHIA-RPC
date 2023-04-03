using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetTransactionMemo
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"transaction_id\": \"0x21899b89bf36154e44c2277e9bfb6cff0574d7e9df4e100b782b03ab2476e171\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"21899b89bf36154e44c2277e9bfb6cff0574d7e9df4e100b782b03ab2476e171\": {\r\n        \"21899b89bf36154e44c2277e9bfb6cff0574d7e9df4e100b782b03ab2476e171\": [\r\n            \"f8858363837eaccf1249844dfd200999ebd480b393dd0f7f2022880868ce3bf3\"\r\n        ]\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<TransactionID_RPC> helper = new Test_RPCClasses<TransactionID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<TransactionID_RPC> helper = new Test_RPCClasses<TransactionID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Memo_Response> helper = new Test_ResponseClasses<Memo_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Memo_Response> helper = new Test_ResponseClasses<Memo_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
