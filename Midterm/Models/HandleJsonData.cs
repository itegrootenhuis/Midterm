using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Midterm;
using Newtonsoft.Json;

namespace Models
{
    class HandleJsonData
    {
        public static string filePath = @"C:\Users\test\Documents\GrandCircus\Midterm\Midterm\products.json";
        public static List<Product> ProductList;
        public static void GetProducts()
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //var test = serializer.Deserialize(file, typeof(Product));
                //ProductList.Add(serializer.Deserialize(file, typeof(Product)));
                //Product movie2 = (Product)serializer.Deserialize(file, typeof(Product));
            }
        }
    }
}
