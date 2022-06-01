using System;
using FindProduct.Data.Enums;
using FindProduct.Data.Models;
using FindProduct.Data.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Warehouse2API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Warehouse2APIController : ControllerBase
    {
        public IActionResult Get(string productName)
        {
            if (string.IsNullOrEmpty(productName)) return NoContent();
            var product = new ProductSearchResponse
            {
                Product = new Product()
                {
                    Name = "Computer",
                    DeliveryMethods = new List<DeliveryMethods>
                 {
                     DeliveryMethods.Car,
                     DeliveryMethods.Plane
                 }
                },
                WarehouseName = "Warehouse2"
            };
            var response = (string.Equals(productName, product.Product.Name, StringComparison.CurrentCultureIgnoreCase)) ? Content(JsonConvert.SerializeObject(product, new StringEnumConverter())) : Content(string.Empty);
            return response;
        }


    }
}
