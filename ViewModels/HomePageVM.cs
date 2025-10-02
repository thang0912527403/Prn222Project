using Microsoft.AspNetCore.Mvc;
using Prn222Project.Models;

namespace Prn222Project.ViewModels
{
    public class HomePageVM : Controller
    {
        public List<Category> Categories { get; set; } = new();
        public List<Product> Featured { get; set; } = new();
        public List<Product> BestSellers { get; set; } = new();
        public List<Product> MoreProducts { get; set; } = new();
    }
}
