using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace bootcamp_assignment_1.Controllers
{

    [Route("api/Payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet]
        public string Amounts(double capital, int date)
        {
            double interestRate = 0.15;
            double total = capital * (1 + interestRate);
            double interest = (capital * (1 + interestRate)) - capital;
            double monthly = capital * (1 + interestRate) / date;
            var result = "Total payment amount: " + Math.Round(total, 3) + " ₺" + "\nTotal interest amount: " + Math.Round(interest, 3) + " ₺" + "\nMonthly payment amount: " + Math.Round(monthly, 2) + " ₺";

            return result;
        }
    }
}
