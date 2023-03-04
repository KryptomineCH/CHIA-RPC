using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Vdf
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"challenge\": \"0x04b130f89a8fc37519eab0d835a43ef5547552b2b67c5129fa00f79a57ba8d7f\",\r\n  \"number_of_iterations\": 78200832,\r\n  \"output\": {\r\n    \"data\": \"0x0200dd868820cb2fd82a8a234872a133e5660d55d43c79d10e1cf2258890820acce29d16831fd75f8c70e47bcdb67a264cceef982b151139741812a7aa477a647b1f0c5dd60eebfae9bd41a51911a54324c84c705d8169c7058d27d987fd8c22c0430100\"\r\n  }\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Vdf> helper = new Test_ObjectClasses<Vdf>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Vdf> helper = new Test_ObjectClasses<Vdf>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
