using Accenture.ContinuousIntegration.Common;
using NUnit.Framework;

namespace Accenture.ContinuousIntegration.Business.Tests.Customer
{
    [TestFixture]
    public class CustomerTest
    {
        [TestCase]
        public void TestConstructor()
        {
            int id = 1;
            string userName = "userName";
            string firstName = "First name";
            string lastName = "Last name";
            Gender gender = Gender.Female;
            string emailAddress = "a@b.com";
            string phoneNumber = "1800800800";

            Business.Customer.Customer customer = new Business.Customer.Customer(id, userName, firstName, lastName, gender, emailAddress, phoneNumber);

            Assert.IsNotNull(customer);
            Assert.IsTrue(userName == customer.UserName);
            Assert.IsTrue(firstName == customer.FirstName);
            Assert.IsTrue(lastName == customer.LastName);
            Assert.IsTrue(emailAddress == customer.EmailAddress);
            Assert.IsTrue(phoneNumber == customer.PhoneNumber);
        }
    }
}
