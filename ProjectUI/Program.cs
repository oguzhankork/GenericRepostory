using Microsoft.EntityFrameworkCore;
using ProjectBll.Repostories;
using ProjectEntities.Models;

namespace ProjectCA_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepostory mr = new ProductRepostory();
            foreach (var product in mr.GetAll())
            {
                Console.WriteLine(product.ProductName + " " + product.ProductId);
            }
            Product product1 = new Product();
            product1.ProductName = "Telefon";
            mr.Delete();


        }
    }
}