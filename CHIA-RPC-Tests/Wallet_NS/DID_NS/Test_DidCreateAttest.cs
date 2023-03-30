using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidCreateAttest
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 4, \"coin_name\": \"0x44a3e90ab1f103d6a259aa3009bdb34e9b092dce9f320f96342368df6b0555c7\", \"pubkey\": \"af8024892a231de462ed7f70abfc1a49372be4d2c34b80f9b48f06093a1629f7a0734c001eb0dd3942aeaecb372b70d2\", \"puzhash\": \"0xb83b62a297e44cb53878276e51db3daaf6b0a69ca8fdd4165c8c5bb1816289ea\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"attest_data\": \"6a8d474f7587eb25667d3dbb14918737962c159453d105b6224b7950a758512d:0000000144a3e90ab1f103d6a259aa3009bdb34e9b092dce9f320f96342368df6b0555c77ffee04b4796a1442b18ddb41644acd8de703ac23771a7bb779ff08cbc97cf290000000000000000ff01ffff3cffa044a3e90ab1f103d6a259aa3009bdb34e9b092dce9f320f96342368df6b0555c780ffff31ffb0af8024892a231de462ed7f70abfc1a49372be4d2c34b80f9b48f06093a1629f7a0734c001eb0dd3942aeaecb372b70d2ffa0b83b62a297e44cb53878276e51db3daaf6b0a69ca8fdd4165c8c5bb1816289ea808080c00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000:7738c8bc6629a6ece9197280238fa2db9437a66d4dc09d8c7d8446956e91e905:b83b62a297e44cb53878276e51db3daaf6b0a69ca8fdd4165c8c5bb1816289ea:1\",\r\n  \"info\": [\r\n    \"7738c8bc6629a6ece9197280238fa2db9437a66d4dc09d8c7d8446956e91e905\",\r\n    \"b83b62a297e44cb53878276e51db3daaf6b0a69ca8fdd4165c8c5bb1816289ea\",\r\n    1\r\n  ],\r\n  \"message_spend_bundle\": \"0000000144a3e90ab1f103d6a259aa3009bdb34e9b092dce9f320f96342368df6b0555c77ffee04b4796a1442b18ddb41644acd8de703ac23771a7bb779ff08cbc97cf290000000000000000ff01ffff3cffa044a3e90ab1f103d6a259aa3009bdb34e9b092dce9f320f96342368df6b0555c780ffff31ffb0af8024892a231de462ed7f70abfc1a49372be4d2c34b80f9b48f06093a1629f7a0734c001eb0dd3942aeaecb372b70d2ffa0b83b62a297e44cb53878276e51db3daaf6b0a69ca8fdd4165c8c5bb1816289ea808080c00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000\",\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DidCreateAttest_RPC> helper = new Test_RPCClasses<DidCreateAttest_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DidCreateAttest_RPC> helper = new Test_RPCClasses<DidCreateAttest_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DidCreateAttest_Response> helper = new Test_ResponseClasses<DidCreateAttest_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidCreateAttest_Response> helper = new Test_ResponseClasses<DidCreateAttest_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
