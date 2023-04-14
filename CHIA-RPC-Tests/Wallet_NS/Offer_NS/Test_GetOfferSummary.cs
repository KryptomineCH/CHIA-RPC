using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC.Wallet_NS.Offer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Offer_NS
{
    public class Test_GetOfferSummary
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"offer\": \"offer1qqr83wcuu2rykcmqvpsxzgqq4gnsn0v2w6gchlaawrmeju4af4arrwu5s2kvce6at3nhmsa4v03kvgvc8furkat55swhlsmpwjj86a9ylhljq8mfs7jw6p044wxg9a7lhhuwphnff6my6aujm3m37wvl6q0kzy3tde6nh7w9j6d0nlchdsgk628m7aktm6jfqa47hwwnj705chexjdkhufx3fd9zegkcwhfknvg9auleg2neqcjpcj8mjehmfeks7gazhwlz4ffam6ukt3wwddlya3qah92s4wgqhr73797a5fyq68clmcfmhc85auqtzmuvure07v84jch8vzcwldm0qdf4uwatuj4xtjfxadlp37x8xf8nupxtz7jl7reyvj2fg9q5t057kfe95e2jdftx5etj2f6k2kjfdx48zmjwdx55j4jfwf4xzj24295hnxd7gfz425j72x99jc2kf9py56dxtxu62an2g4lxzkvwsegk5s27hed9j52f0eqhykn206h9vnnxt66mtqvw3ft85cqam9935q4wlmd45q9u7t5t86dl3g37vrrghz8aelwgga99mg3e0uylklaume8alal4xtksxxynga2v2echu8ksx4xnjsym2f5xv56wveex5hn34f0yzzkgadxu27dqvx4wyyssnxdmzcyn5tlsl0v0tnsalqhlwgly708udd0n9ee5q0lqnhm7hul7m8e6cxn3he9u3sz546dwmxtualtc0h5f89knj34tdmkrrvknf0pzat0ju7hm3a7hz7raqqkfalm408a6jtm6xn9a0lhchxu5z4dhf7wandtdah3qjdh844tjanauwj73kjap8ga08qujwarxwljxvalq3w88ll5vcra379zflxglfrvhwa844090t2cc53pafme08pcaa625hmzaw9hf320ekrc9zhdkmw484cr9zp3tclgr4fdrxv52xvegsdlqdefln5a47zuzfu7t8hh7f3y0fd5dcqktrt57ntn30xm6nja58d8kfh8rsct4lypkfyq0npsh2sxwddqvkk4rqdk03c5jz90yfs4glll3w888k40ml09v39n6xhpdhlz85lm9mcdjlsujrck85alr6lceqjgl0etsp9tv98mq48hkmvulalxn9vgn0nht9k6sayee0mdwyfp0wd67ewknh64pxsppf3gprjxwmgsdmrfj4l8ejtukh846a43sh036d6a3e80gkmjdmf3nfu0qr50vxrg0nmezadj5hkku0srmhefz57xxw5re2na6pku46t5neaaq5fzkda9kwcrqzramre95yeayjwnvk7cgqrw7kzddne7778jslravahl4ua8v2tklam7v9x0yc63l7mu7j8xkeu7t4unqs72l9q0th3npxakcgeynt8uaksf2edgpjtc07techllaakccnazlwm9ehu4wc08dhk7ufjn576jkwzem9m88jlhl3l3wtelltvvnvhvgvd5zq543hprajzagvtsamxaxn2vt4lzn83aagcvw8rt65l57a88ua4a0ls70tekewukd805hq9xeuwj9uy89pvgf4zyq053kluthp3d4z7h8vaa4nv75tmwlc5y3duk7l4aylcmwaqrdljzl4gjm62nuxdgftl0lqh9m7xmeaha0t7dc0tp3wrwah94w7xaltkvnq460f8l09atlnd0vueveq3glt7mka5xk28fas8hawnqamaa80nfhdr7jna5qvldunsnhh70ra78ze5ycatyhplvmlhc0xf8skk4fklj2pkwtxh30xwr03qr9ckmz7r97dwe8hlaajk0t6664dahv6y78anx29pmgxkdzmk3zj57am2ngdh05u699ce8k0qrrp5f3eccrkarcssjm4950tv63cfmf8dnh5nl9vp8w7hagjjuwm6udnftt24le2wnd79kadf4jxxrmuh5myxte6vh2sky9vlvnc3j2wjm079msdng0uan048n0t09lmsnn0mfl2teylev3avfgdupa32x57tjxe6t86phk6ypgrk4e2x92kasy447ds0te305gdsrrdvl9d8vurct22gqel9z8dh2pg2y3zdxjpa9t4ga98agazj4s3grz5g2cldpq5zez2jpdevdc7p28mfzrkru7nsk9vgdv9x7jmn9edtf5fn69xw84sxjaacjdemhdfsqaxu49dlzm0aq4rk0ptpxclwncekuk4yu29tgakdl53uwfdkaavr8dnmweljt66csujmjkeeznhecn9cx5aaw9du02wkkp09qkd8kmjyqtqqv6yzy7lk89vq\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"id\": \"0x7cd4ea3988ffe67388b7a12facff0499059000f99b0f9cb8b343c821b422ced9\",\r\n    \"success\": true,\r\n    \"summary\": {\r\n        \"fees\": 10000,\r\n        \"infos\": {\r\n            \"b4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16\": {\r\n                \"also\": {\r\n                    \"also\": {\r\n                        \"owner\": \"()\",\r\n                        \"transfer_program\": {\r\n                            \"launcher_id\": \"0xb4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16\",\r\n                            \"royalty_address\": \"0x53c8e63bb7e61215db3c109a168a8c7ce7d1828c438b542abe9368c83ad3f0ff\",\r\n                            \"royalty_percentage\": \"300\",\r\n                            \"type\": \"royalty transfer program\"\r\n                        },\r\n                        \"type\": \"ownership\"\r\n                    },\r\n                    \"metadata\": \"((117 \\\"https://bafybeigzcazxeu7epmm4vtkuadrvysv74lbzzbl2evphtae6k57yhgynp4.ipfs.nftstorage.link/880.gif\\\") (104 . 0x7a6eedd652d0e6d315e691e87f5098e858bfe646122d1a8759a40fcf3efb024b) (28021 \\\"https://bafybeigzcazxeu7epmm4vtkuadrvysv74lbzzbl2evphtae6k57yhgynp4.ipfs.nftstorage.link/880.json\\\") (27765 \\\"https://bafybeigzcazxeu7epmm4vtkuadrvysv74lbzzbl2evphtae6k57yhgynp4.ipfs.nftstorage.link/license.pdf\\\") (29550 . 1) (29556 . 1) (28008 . 0xb2214ff82ef10a57f653fd09e761c3fabe630996300f90f6fbefcb4f65904c8b) (27752 . 0x2267456bd2cef8ebc2f22a42947b068bc3b138284a587feda2edfe07a3577f50))\",\r\n                    \"type\": \"metadata\",\r\n                    \"updater_hash\": \"0xfe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78b\"\r\n                },\r\n                \"launcher_id\": \"0xb4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16\",\r\n                \"launcher_ph\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n                \"type\": \"singleton\"\r\n            }\r\n        },\r\n        \"offered\": {\r\n            \"xch\": 100000000000\r\n        },\r\n        \"requested\": {\r\n            \"b4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16\": 1\r\n        }\r\n    }\r\n}"
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
