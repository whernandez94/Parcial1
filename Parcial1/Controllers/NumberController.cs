using Microsoft.AspNetCore.Mvc;
using Parcial1.Models;

namespace Parcial1.Controllers
{
    public class NumberController : Controller
    {

        public IActionResult Index()
        {
            var model = new NumberModel
            {
                Drop = CalculateDrop(),
                RandomNum = GenerateRandomNumber()
            };
            return View(model);
        }

        private double CalculateDrop()
        {
   
            return new Random().NextDouble();
        }

        private int GenerateRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 100);
        }
    }
}
