using Bank;

namespace Test
{
    [TestClass]
    public sealed class BankAccountTest
    {
        [TestMethod]
        public void ChargeTest()
        {
            Customer customer1 = new Customer("Gabriel", "123456677", "12345678971", 2005);
            BankAccount account1 = new BankAccount(customer1, 1234, 1000);
            double valorDeposito = 500;
            double valordeposito = 1500;

            account1.Charge(valorDeposito);

            Assert.AreEqual(saldoEsperado, account1.Balance);

        }
    }
}
