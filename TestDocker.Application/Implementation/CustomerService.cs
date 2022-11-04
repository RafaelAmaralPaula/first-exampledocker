using TestDocker.Application.Interfaces;
using TestDocker.Domain.Entities;

namespace TestDocker.Application.Implementation
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> FindAll()
        {
            var list = new List<Customer> { 
                new Customer("1" , "José" , "jose@jose.com"),
                new Customer("2" , "Maria" , "maria@maria.com"),
                new Customer("3" , "Marta" , "marta@marta.com"),
                new Customer("4" , "João" , "joao@joao.com")

            };

            return list;
        }
    }
}
