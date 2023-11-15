using CHIA_RPC.ErrorInterface_NS;

namespace CHIA_RPC_Tests.ErrorInterface_NS
{
    public class Test_ErrorLog
    {
        [Fact]
        public void Test_UploadError()
        {
            Error error = new Error(
                    objectJson: this.ToString(),
                    objectName: "Transaction_DictMemos",
                    errorDescription: "could not identify apropriate coin!",
                    function: "GetPrimaryCoins()");
            Task t = ReportError.UploadFileAsync(error);
            t.Wait();
        }

    }
}
