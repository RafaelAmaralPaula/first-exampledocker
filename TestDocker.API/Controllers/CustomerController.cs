using Microsoft.AspNetCore.Mvc;
using TestDocker.Application.Interfaces;
using TestDocker.Domain.Entities;

namespace TestDocker.API.Controllers
{
    [ApiController]
    [Route("/customers")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController (ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> FindAll()
        {
            return Ok(_customerService.FindAll());
        }

    }
}
