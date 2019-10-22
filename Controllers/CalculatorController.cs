using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            CalculatorNumbers myNumbers = new CalculatorNumbers();
            return View(myNumbers);
        }

        public IActionResult Add(float Number1, float Number2)
        {
            float calculatedNumber = Number1 + Number2;
            return View(calculatedNumber);
        }

        public IActionResult Subtract(float Number1, float Number2)
        {
            float calculatedNumber = Number1 - Number2;
            return View(calculatedNumber);
        }

        public IActionResult Divide(float Number1, float Number2)
        {
            float calculatedNumber = Number1 / Number2;
            //just a check if they try to break it by dividing by 0 or not putting anything in
            if (calculatedNumber.ToString() == "NaN" || calculatedNumber.ToString() == "∞")
            {
                calculatedNumber = 0;
            }
            return View(calculatedNumber);
        }

        public IActionResult Multiply(float Number1, float Number2)
        {
            float calculatedNumber = Number1 * Number2;
            return View(calculatedNumber);
        }



    }
}