using Accenture.ContinuousIntegration.Common;

namespace Accenture.ContinuousIntegration.Business.Customer
{
    public class Customer : ICustomer
    {
        public Customer(int id, string userName, string firstName, string lastName, Gender gender, string emailAddress, string phoneNumber)
        {
            Id = id;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; private set; }

        public string UserName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Gender Gender { get; private set; }

        public string EmailAddress { get; private set; }

        public string PhoneNumber { get; private set; }
    }
}
