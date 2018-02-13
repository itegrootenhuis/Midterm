using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Midterm;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Models;

namespace Models
{
    class HandleJsonData
    {
        public static string filePath = @"..\..\products.json";

        public static ProductsList GetProducts()
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                string json = file.ReadToEnd();
                ProductsList productList = JsonConvert.DeserializeObject<ProductsList>(json);
                return productList;
            }
        }
    }
}
