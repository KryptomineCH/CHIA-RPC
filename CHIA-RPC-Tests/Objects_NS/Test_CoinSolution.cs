﻿using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_CoinSolution
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"coin\": {\r\n    \"amount\": 921800500,\r\n    \"parent_coin_info\": \"0x055c0286a0eb881f2e950ce4ee30870868d1a951a0e0eb4dc52de5472a9c8b91\",\r\n    \"puzzle_hash\": \"0xb1736654875b1c49b4077b89580c4447f12f1e86fb85d488d7efddd5c6e06be0\"\r\n  },\r\n  \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0a86690841c222e78e9726962933db62bbe823fa858a6582b465073fbac0818893db2a0e40faf9aa371add95c37d8072cff018080\",\r\n  \"solution\": \"0xff80ffff01ffff33ffa0bc421848e2404cc5cc83100ad7effd4f2126ce0d4564acea650e313ea2bb8e12ff8205dc80ffff33ffa0c45165adea743c6c31433801e220acd15ed9d1cacfa907a8dd1afacdb4e70da6ff8436f1895880ffff3cffa0dfaf7c8eb6e3ee108a3580bd91ca452701d5d0bf1d513b5d3accd750e75cc6858080ff8080\"\r\n}"
        };

        [Fact]
        public void Test_CoinSerialisation()
        {
            Test_ObjectClasses<CoinSolution> helper = new Test_ObjectClasses<CoinSolution>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_CoinDiskIO()
        {
            Test_ObjectClasses<CoinSolution> helper = new Test_ObjectClasses<CoinSolution>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
