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
    [Route("api/checkout")]
    public class CheckoutController:ControllerBase
    {
        private readonly ICheckout _payment;

        public CheckoutController(ICheckout payment)
        {
            _payment = payment;
        }

        [HttpPost]
        public ActionResult<TblCheckout> Post(TblCheckout checkout)
        {
            _payment.CreateCheckout(checkout);
            return Ok();
        }
    }
}
