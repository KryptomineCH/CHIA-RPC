using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;
using System.Transactions;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Transaction_NoMemo_GetPrimaryCoin
    {
        private DirectoryInfo TestFolder = new DirectoryInfo(Path.Combine("TestAssets","Transaction_NoMemo","Get_PrimaryCoin"));

        [Fact]
        public void Test_CoinSerialisation()
        {
            FileInfo[] testFiles = TestFolder.GetFiles();
            foreach (FileInfo testFile in testFiles)
            {
                Transaction_NoMemo transaction = Transaction_NoMemo.LoadObjectFromFile(testFile);
                Coin[] primaryCoin = transaction.GetPrimaryCoins();
                { }
            }
        }

    }
}
