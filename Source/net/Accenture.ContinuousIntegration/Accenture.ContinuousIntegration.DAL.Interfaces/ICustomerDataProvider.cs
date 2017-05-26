using System.Collections.Generic;

namespace Accenture.ContinuousIntegration.DAL.Interfaces
{
    public interface ICustomerDataProvider
    {
        List<ICustomer> GetCustomers();

        ICustomer GetCustomer(int id);

    }
}
