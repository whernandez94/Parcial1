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

            double roundResult = new Random().NextDouble();
            return Math.Round(roundResult, 2);
        }

        private int GenerateRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 100);
        }
    }
}
