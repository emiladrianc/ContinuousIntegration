using System.Collections.Generic;

namespace Accenture.ContinuousIntegration.Business.Customer
{
    public interface ICustomerManager
    {

        List<ICustomer> GetCustomers();

        ICustomer GetCustomer(int id);
        
    }

}
