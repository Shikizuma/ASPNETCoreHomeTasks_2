using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class Calc : Controller
    {
        private readonly ILogger<Calc> _logger;

        public Calc(ILogger<Calc> logger)
        {
            _logger = logger;
        }

        public IActionResult Add(int num1, int num2)
        {
            int result = num1 + num2;
            return View("Result", new { Operation = "Addition", Result = result });
        }

        public IActionResult Mul(int num1, int num2)
        {
            int result = num1 * num2;
            return View("Result", new { Operation = "Multiplication", Result = result });
        }

        public IActionResult Div(int num1, int num2)
        {
            int result = num1 / num2;
            return View("Result", new { Operation = "Division", Result = result });
        }

        public IActionResult Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return View("Result", new { Operation = "Subtraction", Result = result });
        }
    }
}
