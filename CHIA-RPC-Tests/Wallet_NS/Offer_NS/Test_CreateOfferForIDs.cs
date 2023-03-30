using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Offer_NS
{
    public class Test_CreateOfferForIDs
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"offer\":{\"1\":1000000000000,\"93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\":-1},\"fee\":10000000,\"driver_dict\":{},\"validate_only\":false}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"offer\": \"offer1qqr83wcuu2rykcmqvpsxvgqqemhmlaekcenaz02ma6hs5w600dhjlvfjn477nkwz369h88kll73h37fefnwk3qqnz8s0lle0lzuk8m29ahf74v6c039gt8j0n7luufm07ul2zpa7vmagj57t89vyljcrj47dau6jdtxegfgdpj9fxvhx0j7a8wfydh578t84fcts7a48whzufmp3l00udu8zeffqzp4s8h05ccay50tx0mwha7lhynpxvru7r9ax2ldwfa7u0vthet3vk2xrn5fvvxgm9v7lhwrcanardkpp806v8rsfkmrs0mng2z4e32frhnxehvpmhgx3cuygk0ayxxlarxvj6xve9larxvj5xu9xqjftv9754ueq4hnl7l3gx7a888vndh2fwt0hmerugflcgjdvhr27meqhtd4wdl6lxrul39lk32k62nfpldauleeuuhlvfhpzvagpckte09q7n9kffm4tn0qtmeljs40jp3yr3y8k9h0k3ndpu464vak92knm44edhxuvcm7fmxpmv2ap2cs3w84r7vemgjgq50en8smh0crfecqh9ncf6867uc0m93xwc9sd7m7lq6ntcajke92uhyjd6m7npuy0vk08czyk9a9078ugeq5zj2fgkmfdwn62fn9jujkdfn9jltfveh95u27w4rx2stp0xqezltdgxqe54jjv4myy6tp2xger8nkwely2jtxwfqmjkd4d9nyzsv6dfshdfjevfq4adj6t9v5jajf0ffxyl4wte8xvkp46y43urwn9rftuthq00ex8llt9al0s2z7zzw2xt2anp2hh0jkund00p706q2glllumw2cnsg4fhqsrzdea9wmjgwanhq32kvpl8x4mqgxfhqczhhay5scrw2e3hy5z84fvc57zkde9y57jtt7jxsantta5zjtj8xnjsqtyfgjmjp3fdy5ujxtxc65k235ea9jhj2ff76j5jeveay5hjjtffy2ln6v9xmyjtxt9j5y6new426yk23fxr85a3lwe0gpp57nwy0xs2p38zzvgenx4scz5yxgmy2wtvhwscz70umpnk480ejge3s994m00ue2rktq7m0s4h495zmk2tzs0ec2g28mnu04mkqehj64thfu3w6hch4nzc74y64lwr4qer0ylht62vpclnt7tmd8hm5drtxl0d370e5x64wnaatx2umttza8mqwt0h4e8ne49a0w4szkw68vnn98uxyarkde68druq00lgan70zydylavenjpe2l2826l2kh9l3fqrk38ul7p38e5aflj9kltvjzhlnw8c29gmphdx0t4xkyrykpesmt0z8yau5dfmeg67je4ellfmnq45u8xvzqw9mpth50r2xaj4tfvcalftz2w0ap3rl0r5nfmwrm62wcne0vkzkv2z83xgmqed0vwuwsprw72r0vl7xt96k47y6f7fg7gktvsl7uzeklznlc0tt6j6cx26la60tvld3kynlju0krwlk52w7eku6h28cx90p543yx6348llu9sy9ku90x3wwt4hn5eknw9adp4jxl0tpwt0wwxrr7zgn6ac04ctsaf8hl3wkzutdj0346us8luezmh3kngz7muvhtpual829kltm9mrtqm2dl5l99tpj6qvd9kqpcrrdnjqpnumphqrgf324yyuqrk6vy25pyef6x8rs9kejp8xq5fca02lk7jcn3tjh0mk8l6g2v7watkc747w38094ecm5r2h35zqaq9tahlzlk08uvmdtr8r70yn0uj93lzl7hwlee7c0q4dv8p3tt8r9e0wathnk9tcxe0t4wy88wyc274ulw3whxhafg8lc6wf8gnl9leeat8whpeu0q3t6ad7f2ae6qjlvrzle4mk4yn5falfj7x9veqfnnth9wu47e6h7x5texdp6fwqcxn4mk5augp6cdfk3j4avsp2dpx7eusmzyu5dm436a5f70xntle7gavz9wje8e00z5rth6ujaf655tkyt07460l6uk8684zp8tq5j29crj8qv0caaf0ajatf7lpq4q2ltl2le6dcrwryhlhf00fxq3knw7lwkmye8mtl9tpc76g75upafxladesejvqdrteww7kfemhq9df2wm8vh5k48fez2j8efl9e0vl2llyk7lew2xlle8mgx9getm07q58s5hau9jg7v7p8dshdykls4855t223sejlwvd9m3h5che98edx3lqgr4wjm64e675hq9umn26hmcjd2zlwxcdzt734zyhjmwkhnuwumw7rvl3kl0yx6hge034703gztfht74aslnuc4cuak8g6atcknw8ua89ea7hapgl4zssqhrm6yel8c7tg3dpy6ganrlfuuz9aawahandca6lm34ryner6qgqpvq3ymqqjqgn79\",\r\n    \"success\": true,\r\n    \"trade_record\": {\r\n        \"accepted_at_time\": null,\r\n        \"coins_of_interest\": [\r\n            {\r\n                \"amount\": 1,\r\n                \"parent_coin_info\": \"0xf6355c1b5aaf6abf2f8fd4c61c50a7c3e935d4861fbcdeee53ce765976036136\",\r\n                \"puzzle_hash\": \"0x60a223434eeee141e75b3c5361f490c04d6330cf99d0781e7874dc036bbb518a\"\r\n            },\r\n            {\r\n                \"amount\": 3106899989,\r\n                \"parent_coin_info\": \"0xd5619c0b02a9279edf11ae85407fd8dc7472fe449fe6ab88d4cc480a5d4b24f5\",\r\n                \"puzzle_hash\": \"0x1732d207b04a03dd7d622cc9f491d43ca0561cf73a1efacdaa0e26e8902c8b73\"\r\n            }\r\n        ],\r\n        \"confirmed_at_index\": 0,\r\n        \"created_at_time\": 1678334380,\r\n        \"is_my_offer\": true,\r\n        \"pending\": {\r\n            \"93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\": 1,\r\n            \"unknown\": 3106899989\r\n        },\r\n        \"sent\": 0,\r\n        \"sent_to\": [],\r\n        \"status\": \"PENDING_ACCEPT\",\r\n        \"summary\": {\r\n            \"fees\": 10000000,\r\n            \"infos\": {\r\n                \"93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\": {\r\n                    \"also\": {\r\n                        \"also\": {\r\n                            \"owner\": \"()\",\r\n                            \"transfer_program\": {\r\n                                \"launcher_id\": \"0x93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\",\r\n                                \"royalty_address\": \"0xccc150219bd48d487cb06a7a6637ba2c38776c8e03c3b5962b51bbd2dc917707\",\r\n                                \"royalty_percentage\": \"0\",\r\n                                \"type\": \"royalty transfer program\"\r\n                            },\r\n                            \"type\": \"ownership\"\r\n                        },\r\n                        \"metadata\": \"((117 \\\"https://bafkreifouyunkfshyhywp27uxx62bicxmarr263kohlyshg6s5yphv5acq.ipfs.nftstorage.link\\\") (104 . 0xaea628d51647c1f167ebf4bdfda0a05760231d7b6a71d7891cde9770f3d7a014) (28021 \\\"https://bafkreibspamgjmtkisxjqocjqpb3qjo4tqmjacrhe6d7jmddgdny5kenuu.ipfs.nftstorage.link\\\") (27765 \\\"https://bafkreibd6dchfc56by7fntdoe2viwdnbfbhowals4ivipugkzq6btx7koq.ipfs.nftstorage.link/\\\") (29550 . 1) (29556 . 1) (28008 . 0x32781864b26a44ae98384983c3b825dc9c18900a272787f4b06330db8ea88da5) (27752 . 0x23f0c4728bbe0e3e56cc6e26aa8b0da1284eeb0172e22a87d0cacc3c19dfea74))\",\r\n                        \"type\": \"metadata\",\r\n                        \"updater_hash\": \"0xfe8a4b4e27a2e29a4d3fc7ce9d527adbcaccbab6ada3903ccf3ba9a769d2d78b\"\r\n                    },\r\n                    \"launcher_id\": \"0x93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\",\r\n                    \"launcher_ph\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n                    \"type\": \"singleton\"\r\n                }\r\n            },\r\n            \"offered\": {\r\n                \"93c7f48778b5758254bf8dcf6ce50bf203841e30735979d3a075b49342276d0d\": 1\r\n            },\r\n            \"requested\": {\r\n                \"xch\": 1000000000000\r\n            }\r\n        },\r\n        \"taken_offer\": null,\r\n        \"trade_id\": \"0x0cb147ed072210499e1f33f288aa6233a37b7db0a49012d103a89168a08da1d0\"\r\n    }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CreateOfferForIds_RPC> helper = new Test_RPCClasses<CreateOfferForIds_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CreateOfferForIds_RPC> helper = new Test_RPCClasses<CreateOfferForIds_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ObjectClasses<OfferFile> helper = new Test_ObjectClasses<OfferFile>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ObjectClasses<OfferFile> helper = new Test_ObjectClasses<OfferFile>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
