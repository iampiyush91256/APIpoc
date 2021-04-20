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
    [Route("api/address")]
    public class AddressController:ControllerBase
    {
        private readonly IAddress _address;
        public AddressController(IAddress address)
        {
            _address = address;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TblAddress>> GetAllAddress()
        {
            var items = _address.GetAllAddress();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<TblAddress> Post(TblAddress address)
        {
            _address.CreateAddress(address);
            return Ok();
        }
    }
}
