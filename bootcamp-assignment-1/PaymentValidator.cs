using FluentValidation;

namespace bootcamp_assignment_1
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(x => x.Capital).NotNull();
            RuleFor(x => x.Date).NotNull().LessThanOrEqualTo(120);
        }
    }
}
