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
    [Route("api/order")]
    public class OrderController: ControllerBase
    {
        private readonly IOrder _order;

        public OrderController(IOrder order)
        {
            _order = order;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TblOrder>> GetAllOrder()
        {
            var items = _order.GetAllOrders();
            return Ok(items);
        }

    }
}
