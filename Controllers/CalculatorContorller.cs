using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public string Add(decimal left, decimal right)
        {  
            decimal result = MathLib.Add(left, right); 
            return $"{left} plus {right} equals {result}"; 
        }
        public string Subtract(decimal left, decimal right)
        {  
            decimal result = MathLib.subtract(left, right); 
            return $"{left} minus {right} equals {result}"; 
        }

        public string Multiply(decimal left, decimal right)
        {  
            decimal result = MathLib.Multiply(left, right); 
            return $"{left} times {right} equals {result}"; 
        }
        public string Divide(decimal left, decimal right)
        {  
            decimal result = MathLib.Divide(left, right); 
            return $"{left} divided by {right} equals {result}"; 
        }
        public string Power(double left, double right)
        {  
            double result = MathLib.power(left, right); 
            return $"{left} to the power of {right} equals {result}"; 
        }
        public string Cieling(decimal left)
        {  
            decimal result = MathLib.cielingc(left); 
            return $"The cieling of {left} is {result}"; 
        }
        public string Floor(decimal left)
        {  
            decimal result = MathLib.floorf(left); 
            return $"The floor of {left} is {result}"; 
        }



        

    }
}
