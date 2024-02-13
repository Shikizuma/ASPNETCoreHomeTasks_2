using System;
using System.Collections.Generic;
using System.IO;

namespace ASPNETCoreHomeTasks_2.Models
{
    public class ProductReader
    {
        private readonly string path = "App_Data/data.txt";

        public List<Product> ReadFromFile()
        {
            string[] lines = File.ReadAllLines(path);

            List<Product> result = new List<Product>();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                Product product = new Product();
                product.Id = Convert.ToInt32(items[0].Trim());
                product.Name = items[1].Trim();
                product.Price = Convert.ToDouble(items[2].Trim());
                product.Description = items[3].Trim();
                product.Quantity = Convert.ToInt32(items[4].Trim());
                product.Category = items[5].Trim();

                result.Add(product);
            }



            return result;
        }
    }
}
