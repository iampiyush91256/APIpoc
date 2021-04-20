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
    [Route("api/product")]
    public class ProductController: ControllerBase
    {

        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }

        public override bool Equals(object obj)
        {
            return obj is ProductController controller &&
                   EqualityComparer<IProduct>.Default.Equals(_product, controller._product);
        }

        [HttpGet]
        public ActionResult<IEnumerable<TblProduct>> Get()
        {
            var items = _product.GetAllProduct();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<TblUser> Post(TblProduct product)
        {
            _product.CreateProduct(product);
            return Ok();
        }
    }
}
