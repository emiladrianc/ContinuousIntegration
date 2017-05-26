
using Accenture.ContinuousIntegration.Common;

namespace Accenture.ContinuousIntegration.Business.Customer
{
    public interface ICustomer
    {
        int Id { get; }

        string UserName { get; }

        string FirstName { get; }

        string LastName { get; }

        Gender Gender { get; }

        string EmailAddress { get; }

        string PhoneNumber { get; }

    }
}
