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
    [Route("product/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ICategory>> Get()
        {
            var items = _category.GetAllCategories();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<TblCategory> Post(TblCategory category)
        {
            _category.CreateCategory(category);
            return Ok();
        }
    }
}
