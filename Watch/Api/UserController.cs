using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Watch.Data;

namespace Watch.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext context;
        public UserController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet("{Id}")]
        public ActionResult <IEnumerable<Models.ApplicationUser>> GetById(string Id)
        {
            if (context.Users.Find(Id) != null)
                return Ok(context.Users.Find(Id));
            return NotFound();
        }
        [HttpDelete]
        public ActionResult <bool> Delete(string Id)

        {
            if (context.Users.Find(Id) != null)
            {
                context.Users.Remove(context.Users.Find(Id));
                context.SaveChanges();
                return Ok();
            }
            else return BadRequest();
        }

    }
}
