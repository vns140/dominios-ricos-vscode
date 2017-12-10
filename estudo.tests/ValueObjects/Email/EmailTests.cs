using estudo.domain.Entities;
using estudo.domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace estudo.tests.ValueObjects
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void EmailInvalido()
        {
            Email email = Email.Factory("");

            Assert.AreEqual(false,email.IsValid);
        }
    }
}