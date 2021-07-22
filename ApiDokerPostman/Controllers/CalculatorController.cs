using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiDokerPostman.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {


        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{a}/{b}")]
        public IActionResult Sum(string a , string b)
        {
            if (IsNumeric(a) && IsNumeric(a)) {
                var sum = (Convert.ToDecimal(a) + Convert.ToDecimal(b));
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("substraction/{a}/{b}")]
        public IActionResult Substraction(string a, string b)
        {
            if (IsNumeric(a) && IsNumeric(a))
            {
                var sum = (Convert.ToDecimal(a) - Convert.ToDecimal(b));
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{a}/{b}")]
        public IActionResult Multiplication(string a, string b)
        {
            if (IsNumeric(a) && IsNumeric(a))
            {
                var sum = (Convert.ToDecimal(a) * Convert.ToDecimal(b));
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{a}/{b}")]
        public IActionResult Division(string a, string b)
        {
            if (IsNumeric(a) && IsNumeric(a))
            {
                var sum = (Convert.ToDecimal(a) / Convert.ToDecimal(b));
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string str_a)
        {
            double number;
            bool IsNumber = double.TryParse(str_a,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return IsNumber;
        }
    }
}
