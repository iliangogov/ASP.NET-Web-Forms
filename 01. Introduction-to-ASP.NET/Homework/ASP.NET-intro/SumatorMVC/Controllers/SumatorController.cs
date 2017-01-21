using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumatorMVC.Controllers
{
    public class SumatorController : Controller
    {
        public ActionResult Sumator(double? firstNumber, double? secondNumber)
        {
            this.ViewBag.Message = "Sumator MVC demo: ";

            try
            {
                double result = firstNumber.Value + secondNumber.Value;

                this.ViewBag.firstNumber = firstNumber.ToString();
                this.ViewBag.secondNumber = secondNumber.ToString();
                this.ViewBag.Sum = result.ToString();

                return this.View();
            }
            catch (Exception)
            {
                this.ViewBag.Sum = "Enter valid numbers";
                this.ViewBag.firstNumber = 0d;
                this.ViewBag.secondNumber = 0d;
                return this.View();
            }
        }
    }
}