using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gittest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    { 

        [HttpGet]
        [Route("getprds")]
        public IEnumerable<product> getPrds()
        {
            return product.getAllProducts();
        }
    }

    public class product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float price { get; set; }


        public product(int pid, string pname, float price)
        {


            Pid = pid;
            pname = pname;
            price = price;
        }
        public static List<product> getAllProducts()
        {


            List<product> products = new List<product>();
            products.Add(new product(1001, "Pen", 980));
            products.Add(new product(1002, "Paper", 90));
            products.Add(new product(1003, "Erasor", 80));
            products.Add(new product(1004, "Pencil", 95));
            return products;
        }

    }

}

