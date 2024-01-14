using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractProject.Abstract;

namespace InterfaceAbstractProject.Concrete
{
    public class DoraCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public DoraCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Not a volid Person");

            }
        }
         
    }
}
