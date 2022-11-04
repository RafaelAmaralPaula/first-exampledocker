using TestDocker.Domain.Entities;

namespace TestDocker.Application.Interfaces
{
    public interface ICustomerService
    {

        List<Customer> FindAll();

    }
}
