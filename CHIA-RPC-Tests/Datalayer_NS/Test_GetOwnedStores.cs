using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetConnections
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"connections\": [\r\n    {\r\n      \"bytes_read\": 66,\r\n      \"bytes_written\": 66,\r\n      \"creation_time\": 1660636909.9794328,\r\n      \"last_message_time\": 1660636909.9815319,\r\n      \"local_port\": 8561,\r\n      \"node_id\": \"0x8e961b617579d476419003728d6d71ab1b182f7d962e5db16f61ebfb157d771b\",\r\n      \"peer_host\": \"localhost\",\r\n      \"peer_port\": 58444,\r\n      \"peer_server_port\": 58444,\r\n      \"type\": 1\r\n    }\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetConnections_Response> helper = new Test_ResponseClasses<GetConnections_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetConnections_Response> helper = new Test_ResponseClasses<GetConnections_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
