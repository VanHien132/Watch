using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Watch.Data;

namespace Watch.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext context;
        public CategoryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Category>> GetAll()
        {
            return Ok(context.Categories.AsEnumerable());
        }
        [HttpGet("{Id}")]
        public ActionResult<Models.Category> GetById(int Id)
        {
            if(context.Categories.Find(Id)!=null)
            return Ok(context.Categories.Find(Id));
            return NotFound();
        }
        [HttpPost]
        public ActionResult<Models.Category> Add(Models.Category category)
        {
            var newcate = new Models.Category();
            newcate.Name = category.Name;
            newcate.Address = category.Address;
            newcate.Decription = category.Decription;
            context.Categories.Add(newcate);
            if (context.SaveChanges() > 0) return Ok(newcate);
            return BadRequest();
        }
        [HttpPut]
        public ActionResult<Models.Category> Update(Models.Category category)
        {
            var newcate =  context.Categories.Find(category.Id);
            if(newcate==null) return BadRequest();
            else
            {
                try
                {
                    newcate.Name = category.Name;
                    newcate.Address = category.Address;
                    newcate.Decription = category.Decription;
                    context.Categories.Update(newcate);
                    context.SaveChanges();
                    return Ok(newcate);
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
               
                
            }
            
        }
        [HttpDelete("{Id}")]
        public ActionResult<bool> Delete(int Id)
        {
            if (context.Categories.Find(Id) != null)
            {
                context.Categories.Remove(context.Categories.Find(Id));
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
