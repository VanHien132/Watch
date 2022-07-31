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
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProductController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Models.Product>> GetAll()
        {
            return Ok(context.Products.AsEnumerable());
        }
        [HttpGet("{Id}")]
        public ActionResult<Models.Product> GetById(int Id)
        {
            if (context.Products.Find(Id) != null)
                return Ok(context.Products.Find(Id));
            return NotFound();

        }
        [HttpPost]
        public ActionResult<Models.Product> Add(Models.Product product)
        {
            var newproduct = new Models.Product();
            newproduct.CategoryId = product.CategoryId;
            newproduct.Name = product.Name;
            newproduct.Mount = product.Mount;
            newproduct.PriceN = product.PriceN;
            newproduct.PriceB = product.PriceB;
            newproduct.Avatar = product.Avatar;
            context.Products.Add(newproduct);
            if (context.SaveChanges() > 0) return Ok(newproduct);
            return BadRequest();

        }
        [HttpPut]
        public ActionResult<Models.Product> Update(Models.Product upproduct)
        {
            var product = context.Products.Find(upproduct.Id); 
            if(product != null )
            {
                try
                {
                    product.Name = upproduct.Name;
                    product.Mount = upproduct.Mount;
                    product.PriceN = upproduct.PriceN;
                    product.PriceB = upproduct.PriceB;
                    product.Avatar = upproduct.Avatar;
                    product.CategoryId = upproduct.CategoryId;
                    context.Products.Update(product);
                    context.SaveChanges();
                     return Ok(product);
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
                
               

            }
            else
                return BadRequest();
            
        }
        [HttpDelete("{Id}")]
        public ActionResult <bool> Delete(int Id)
        {

            if (context.Products.Find(Id) != null)
            {
                context.Products.Remove(context.Products.Find(Id));
                context.SaveChanges();
                return Ok(true);
            }
            else return BadRequest();
        }
    }
}
