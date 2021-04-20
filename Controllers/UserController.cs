using APIpoc.Data;
using APIpoc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Controllers
{

    [ApiController]
    [Route("api/user")]
    public class UserController: ControllerBase
    {
        private readonly IUser _customer;

        public UserController(IUser customer)
        {
            _customer = customer;
        }

        public override bool Equals(object obj)
        {
            return obj is UserController controller &&
                   EqualityComparer<IUser>.Default.Equals(_customer, controller._customer);
        }

        [HttpGet]
        public ActionResult<IEnumerable<TblUser>> GetAllCustomer()
        {
            var items = _customer.GetAllCustomer();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<TblUser> Post(TblUser customer)
        {
            _customer.CreateCustomer(customer);
            return Ok();
        }
    }
}
