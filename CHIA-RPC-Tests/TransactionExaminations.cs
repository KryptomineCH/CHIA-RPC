using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;

namespace CHIA_RPC_Tests
{
    public class TransactionExaminations
    {
        [Fact]
        public void ExamineCustomTransactionType()
        {
            DirectoryInfo baseFolder = new DirectoryInfo("TestAssets\\Transaction_NoMemo\\Sorted_Transactions");
            foreach (DirectoryInfo tokenType in baseFolder.EnumerateDirectories())
            {
                foreach (DirectoryInfo transactionType in tokenType.EnumerateDirectories())
                {
                    foreach (FileInfo transactionFile in transactionType.EnumerateFiles())
                    {
                        Transaction_NoMemo transaction = Transaction_DictMemos.LoadObjectFromFile(transactionFile);
                        if (transactionType.Name.Contains("incoming")
                            && transaction.customTransactionType.Value != CustomTransactionType.Incoming)
                        {
                            { }
                            transaction.GetCustomTransactionType(); // for testing purposes, set a break pointer first
                            throw new InvalidDataException();
                        }
                        if (transactionType.Name.Equals("outgoing_coins")
                            && transaction.customTransactionType.Value != CustomTransactionType.Outgoing)
                        {
                            { }
                            transaction.GetCustomTransactionType(); // for testing purposes, set a break pointer first
                            throw new InvalidDataException();
                        }
                        if (transactionType.Name.Equals("fee_transaction")
                            && transaction.customTransactionType.Value != CustomTransactionType.Fee)
                        {
                            { }
                            transaction.GetCustomTransactionType(); // for testing purposes, set a break pointer first
                            throw new InvalidDataException();
                        }
                        if (transactionType.Name.Contains("cancellation")
                            && transaction.customTransactionType.Value != CustomTransactionType.Neutral)
                        {
                            { }
                            transaction.GetCustomTransactionType(); // for testing purposes, set a break pointer first
                            throw new InvalidDataException();
                        }
                        if (transactionType.Name.Equals("outgoing_trade")
                            && transaction.customTransactionType.Value != CustomTransactionType.Outgoing_Trade)
                        {
                            { }
                            transaction.GetCustomTransactionType(); // for testing purposes, set a break pointer first
                            throw new InvalidDataException();
                        }
                    }
                }
            }
        }
        [Fact]
        public void GenerateTestTransactionTypes()
        {
            SendTransaction_RPC defaultTransaction = new SendTransaction_RPC(0,);
            defaultTransaction.amount = 1000;
        }
    }
}