using AppBaap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBaap.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        AppDbContext _db;
        public ProductController(AppDbContext getDb)
        {
            _db = getDb;
        }

        //public IEnumerable<Product> ProductGiver()
        //{
        //    List<Product> prods = new List<Product>() { new Product() { id= 1,name="Bottle",price=5,category="scsc"}, new Product() { id = 2, name = "Drum", price = 10, category = "scsc" }, new Product() { id = 3, name = "NAav", price = 5, category = "scsc" }, new Product() { id = 4, name = "Glass", price = 5, category = "scsc" } };


        //    return prods;
        //}
        //[HttpGet]
        //public IEnumerable<Product> getAll()
        //{
        //    return ProductGiver();
        //}
        //[HttpGet("{id}")]
        //public Product getAll(int id)
        //{
        //    return ProductGiver().Where(e=>e.id==id).FirstOrDefault();
        //}

        [HttpPost]
        [Route("add")]
        public Product addProd([FromBody] Product p)
        {
            _db.products.Add(p);
            _db.SaveChanges();
            return p;
        }
        [HttpGet("{id}")]
        public Product getById(int id)
        {
            return _db.products.FirstOrDefault(r=>r.id==id);
        }
        [HttpGet]
        public IEnumerable<Product> getAll()
        {
            return _db.products;
        }
        [HttpPut]
        public Product editor([FromBody] Product prod)
        {
            _db.products.Update(prod);
            _db.SaveChanges();
            return prod;
        }

    }
}
