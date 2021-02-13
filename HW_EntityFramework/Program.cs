using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (OrderDBEntities orderEntities = new OrderDBEntities())
            {
                List<Product> products = (from p in orderEntities.Products
                                select p).ToList();

                List<Product> productsMS = orderEntities.Products.ToList();


                Console.WriteLine();

                foreach  (var p in products)
                {
                    Console.WriteLine(p.NAME);
                }
            }

        }
    }
}
