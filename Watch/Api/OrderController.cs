using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Watch.Data;

namespace Watch.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext context;
        public OrderController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Order>> GetAll()
        {
            return Ok(context.Orders.AsEnumerable());
        }
        [HttpGet("{Id}")]
        public ActionResult<Models.Order> GetById(int Id)
        {
            if (context.Orders.Find(Id) != null)
                return Ok(context.Orders.Find(Id));
            return NotFound();
        }
        
        [HttpDelete("{Id}")]
        public ActionResult<bool> Delete(int Id)
        {
            if (context.Orders.Find(Id) != null)
            {
                context.Orders.Remove(context.Orders.Find(Id));
                context.SaveChanges();
                return Ok(true);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
