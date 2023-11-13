

using Data.DbModels;
using Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assign1.Controllers
{

    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly IUow _uow;

        public TitlesController(IUow uow)
        {
            _uow = uow;
        }

        [HttpGet]
        [Route("api/titles")]

        public List<Title> GetTitles()
        {
            var books = _uow.TitlesRepo.GetTitles();
            return books;
        }

        [HttpGet]
        [Route("api/sales")]

        public List<Sale> GetSales(string ord_num)
        {
            var books = _uow.SalesRepo.GetSales(ord_num);
            return books;
        }

        [HttpPost]
        [Route("api/submitOrder")]

        public IActionResult SubmitOrder(string title, int qty)
        {
            if(title == null || qty < 1) 
            {
                return BadRequest("Invalid order data");
            }

            _uow.SubmitOrderRepo.SubmitOrder(title, qty);
            return Created("", "order placed successfully");
        }
    }
}