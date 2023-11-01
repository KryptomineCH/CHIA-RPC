using CHIA_RPC.Objects_NS;
using System.Diagnostics;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetTransactionType
    {
        [Fact]
        public void Test_TransactionTypesManual()
        {
            DirectoryInfo testDir = new DirectoryInfo(@"TestAssets\transactions");
            FileInfo[] transactionFiles = testDir.GetFiles();
            foreach(FileInfo transactionFile in transactionFiles)
            {
                Transaction_NoMemo transaction = Transaction_DictMemos.LoadObjectFromFile(transactionFile);
                Debug.WriteLine("");
                Debug.WriteLine($"examining: {transactionFile.Name}");
                Debug.WriteLine($"type: {transaction.type.ToString()}");
                Debug.WriteLine($"Wallet: {transaction.wallet_id}");
                { }
            }
        }
    }
}
