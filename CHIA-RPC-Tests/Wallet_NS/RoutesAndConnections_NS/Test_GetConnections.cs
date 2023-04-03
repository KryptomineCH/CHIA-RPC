using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.RoutesAndConnections_NS
{
    public class Test_GetConnections
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"connections\": [\r\n        {\r\n            \"bytes_read\": 49581235,\r\n            \"bytes_written\": 717978,\r\n            \"creation_time\": 1669283764.8537369,\r\n            \"last_message_time\": 1669358138.7421055,\r\n            \"local_port\": 8449,\r\n            \"node_id\": \"0xcda6b919f90af6f021ccf6ca748a30d03b22622863654b57bd74896dd60c4eca\",\r\n            \"peer_host\": \"127.0.0.1\",\r\n            \"peer_port\": 8444,\r\n            \"peer_server_port\": 8444,\r\n            \"type\": 1\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetConnections_Response> helper = new Test_ResponseClasses<GetConnections_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetConnections_Response> helper = new Test_ResponseClasses<GetConnections_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
