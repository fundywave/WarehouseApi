using FindProduct.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FindProduct.Data.Response
{
    public class ProductSearchResponse
    {
        public Product Product{get;set;}
        public string WarehouseName{get;set;}
    }
}
