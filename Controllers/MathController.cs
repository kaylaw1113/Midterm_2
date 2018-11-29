using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm2.Models;

namespace Midterm2.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DoCalculation()
        {
            if (ModelState.IsValid)
            {

                switch (MathOperation.Operator)
                {

                    /*
                    Plus
                    Minus
                    Times
                    Divided By
                    */

                    case "Plus":
                        Model.MathOperation.Result =
                        MathOperation.LeftOperand + MathOperation.RightOperand;
                        break;

                    case "Minus":
                        MathOperation.Result =
                        MathOperation.LeftOperand - MathOperation.RightOperand;
                        break;

                    case "Times":
                        MathOperation.Result =
                        MathOperation.LeftOperand * MathOperation.RightOperand;
                        break;

                    case "Divided By":
                        //do not allow divide by zero
                        if (MathOperation.RightOperand == 0)
                        {

                            return View("Error");
                        }
                        MathOperation.Result =
                        MathOperation.LeftOperand / MathOperation.RightOperand;
                        break;

                }

            }
        }
        public IActionResult ShowCalculationResults()
            {
                switch(model.MathOperation.Operator){
                    
                    case "Plus":
                        MathOperation.Result = 
                        MathOperation.LeftOperand + MathOperation.RightOperand;
                        break;

                    case "Minus":
                        MathOperation.Result = 
                        MathOperation.LeftOperand - MathOperation.RightOperand;
                        break;


                    case "Times":
                        MathOperation.Result = 
                        MathOperation.LeftOperand * MathOperation.RightOperand;
                        break;

                    case "Divided by":
                    // if(model.MathOperation.RightOperand == 0)
                    //     {
                            
                    //         return View("Error: Can't divide by 0");
                    //     }   
                        MathOperation.Result = 
                        MathOperation.LeftOperand / MathOperation.RightOperand;
                        break;
    }
}


[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
    }
}
