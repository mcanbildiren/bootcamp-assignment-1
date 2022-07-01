using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace bootcamp_assignment_1.Controllers
{
    public class Payment
    {
        public double Capital { get; set; }
        public int Date { get; set; }
        public double InterestRate { get; set; }
        public double Result { get; set; }
    }
    [Route("protein/api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet]
        public List<Payment> Get()
        {
            List<Payment> list = new();

            list.Add(new Payment { Capital = 10000, Date = 12, InterestRate = 1.5 });

            return new List<Payment>(list);
        }

        [HttpPost]
        public double Post(double capital, int date)
        {
            double interestRate = 0.15;

            double result = capital * (1 + interestRate) / date;

            return result;
        }
    }
}
