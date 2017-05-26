using Accenture.ContinuousIntegration.DAL.Interfaces;
using Accenture.ContinuousIntegration.Logger;
using System;
using System.Collections.Generic;

namespace Accenture.ContinuousIntegration.Business.Customer
{
    public class CustomerManager : ICustomerManager
    {
        private readonly DAL.Interfaces.ICustomerDataProvider _customerDataProvider;

        private readonly ILogger _logger;

        public CustomerManager(ICustomerDataProvider customerDataProvider, ILogger logger)
        {
            _customerDataProvider = customerDataProvider;
            _logger = logger;
        }

        public ICustomer GetCustomer(int id)
        {
            try
            {
                _logger.Info("Get customers started...");

                var dalCustomer = _customerDataProvider.GetCustomer(id);

                var customer = CustomerAssembler.Assemble(dalCustomer);

                _logger.Info("Get customers started...Done. ");

                return customer;
            }
            catch (Exception ex)
            {
                _logger.Error("Get customers exception" + ex.Message, ex);
                throw;
            }
        }

        public List<ICustomer> GetCustomers()
        {
            try
            {
                _logger.Info("Get customers started...");

                var dalCustomers = _customerDataProvider.GetCustomers();

                var customers = CustomerAssembler.Assemble(dalCustomers);

                _logger.InfoFormat("Get customers started...Done. Retrieved: {0} customers.", customers.Count);

                return customers;
            }
            catch (Exception ex)
            {
                _logger.Error("Get customers exception" + ex.Message, ex);
                throw;
            }
        }
    }
}
