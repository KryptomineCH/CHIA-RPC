﻿using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_CreateSignedTransaction
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 2, \"new_address\": false}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"address\": \"xch1jxe8yfq8xem0e8ty5dq9hp86ududys96n6ugy2q4fextr0pplw9qwpfru9\",\r\n    \"success\": true,\r\n    \"wallet_id\": 2\r\n}"
        };

        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#create_signed_transaction, unable to test this method yet.")]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<CreateSignedTransaction_RPC> helper = new Test_RPCClasses<CreateSignedTransaction_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#create_signed_transaction, unable to test this method yet.")]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CreateSignedTransaction_RPC> helper = new Test_RPCClasses<CreateSignedTransaction_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#create_signed_transaction, unable to test this method yet.")]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetNextAddress_Response> helper = new Test_ResponseClasses<GetNextAddress_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact(Skip = "Incomplete documentation at https://docs.chia.net/wallet-rpc#create_signed_transaction, unable to test this method yet.")]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetNextAddress_Response> helper = new Test_ResponseClasses<GetNextAddress_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
