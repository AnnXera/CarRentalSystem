using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  CarRentalSystem.Utils;
using CarRentalSystem.Code;

namespace CarRentalSystem.Code
{
    public class Customer
    {
        public long CustID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DriversLicense { get; set; }
        public string Address { get; set; }
        public long RegisteredByEmpID { get; set; }
        public byte[] Picture { get; set; }

        public string RegisteredByName { get; set; }
    }

    public class CustomerFactory : IModalFactory<Customer>
    {
        private readonly CustomerRepository _repo;

        public CustomerFactory()
        {
            _repo = new CustomerRepository();
        }

        public List<Customer> ViewAll()
        {
            return _repo.GetAllCustomers();
        }

        public void Add(Customer cs)
        {
            _repo.AddCustomer(cs);
        }

        public void Edit(Customer cs)
        {
            _repo.UpdateCustomer(cs);
        }
    }
}
