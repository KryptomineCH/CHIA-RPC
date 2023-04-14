using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC.Wallet_NS.Offer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetOfferSummary
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"offer\": \"offer1qqzh3wcuu2rykcmqvpsxygqqwc7hynr6hum6e0mnf72sn7uvvkpt68eyumkhelprk0adeg42nlelk2mpagr90qq0a37v8lc9pfxkwhdhlns4tnwtx933g0gsj06neuds6jjugly4k5x7we0x39h9ur65y2cmwttg00ht60xnjly6zhduf0h9hmedaq67yh89uafrzctmgrka06llmvv9uhze9tqqpd38v8zcv4x32hhe7wueh4t8vd9cn6uhqk7vejppfygfgtje8usle5c5ukqmlw72va4pv8mweg5ztmcakwex27z9uamchklr2mtk7ax4tadcte8hq98380vuxcnfkjxndkjxrdk68rdk69rdk68ga95mfr2xhump4wrstastammnc2aav3hrd4ej8gexus0gje2urasruamdvrwvas9wm56mykj42pj6cp0vlymr5daw8k9e780kxd46wsh9u4e4tk7dw49w2epylahdz44aq2kj4ypthrsme4qwdncgdnwhlcw2amlhhsl6z0wlca7573y7knevrjjz4kpg80gnrlmlx7q6lh2rdtll6j6kh72t66vmwn25gwh5eqsd6wpqc6yqkn9luteq6nz0hh7yln3r7ct9yqecrfh95lyzace38xayytnu7x2fl4whv40e6etxehv03mwzdlnfttaxckmea7xle3hs0tzvlmdlch7qjzul97gymhjsew40ef2vmf6m8m4ntw0x08ceu7xkxm0fxjut754n9qd2anljlwpk49z4472n65af226w03fha2j7hyshuuh8gdr68z3a67atjcnl07vswj0clutncre6wt4la0au8vdlmxjn7fe8mqald7l8rh2hgls66uxhutuzdqmnr0ljlkyulq5t67rru25jnxjjyxntvllt2n4j244utj7ahu6avas47nlhrah2p5uursd0uteccgjtncy6e62uvn6tathamz0m0rfweuaaq5mevp6klth99dhf0f6hcqksxfpqmvhlpvyrtj2qjmvnwyr96saajuyp8vm70h7vhtw93vkmj7llmquru84g0vv80fd3eg65vhfrlm5yrgzs4pa95el4wa6w9nfkgvvazzek9eef4kd6zr6rjue6culxd8wdg5dglrevft9lc7hfljuc70hx9uq587fl64gp3s467zj58nvdaawuet3lvft8hvynv5j83tlg5phaeteme079hw6xn5dn54tm602ln2vgknvammql8fe7zuqzvfq20gc9s4d4\", \"advanced\": true}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"summary\": {\r\n        \"fees\": 0,\r\n        \"infos\": {\r\n            \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": {\r\n                \"tail\": \"0x0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\",\r\n                \"type\": \"CAT\"\r\n            }\r\n        },\r\n        \"offered\": {\r\n            \"0570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4\": 1000\r\n        },\r\n        \"requested\": {\r\n            \"xch\": 1000000000000\r\n        }\r\n    }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetOfferSummary_RPC> helper = new Test_RPCClasses<GetOfferSummary_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetOfferSummary_RPC> helper = new Test_RPCClasses<GetOfferSummary_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetOfferSummary_Response> helper = new Test_ResponseClasses<GetOfferSummary_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetOfferSummary_Response> helper = new Test_ResponseClasses<GetOfferSummary_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
