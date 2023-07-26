using CHIA_RPC.General_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_SaveLoading
    {

        [Fact]
        public void Test_OfferSafeLoading()
        {
            OfferFile offerFile = new OfferFile();
            offerFile.offer = "ASDF";
            offerFile.RawContent = "SADA";
            offerFile.error = "test";
            offerFile.success = true;
            FileInfo file = new FileInfo("offerfileSaveLoadingTest.offerfile");
            if (file.Exists) file.Delete();
            offerFile.SaveObjectToFile(file);
            OfferFile? loadTest = OfferFile.LoadObjectFromFile(file);
            Assert.NotNull(loadTest);
            file.Delete();
            Assert.Equal(offerFile.offer, loadTest.offer);
            Assert.Equal(offerFile.error, loadTest.error);
            Assert.True(loadTest.success);
        }
    }
}
