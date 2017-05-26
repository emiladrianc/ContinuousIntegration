using System.Collections.Generic;
using System.Linq;

namespace Accenture.ContinuousIntegration.Business.Customer
{
    public class CustomerAssembler
    {
        public static ICustomer Assemble(DAL.Interfaces.ICustomer customer)
        {
            if (customer == null)
                return null;

            return new Customer(
                customer.Id,
                customer.UserName,
                customer.FirstName,
                customer.LastName,
                customer.Gender,
                customer.EmailAddress,
                customer.PhoneNumber
                );
        }

        public static List<ICustomer> Assemble(List<DAL.Interfaces.ICustomer> customers)
        {
            return customers.Where(c => c != null).Select(c => Assemble(c)).ToList();
        }
    }
}
