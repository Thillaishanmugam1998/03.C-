using ECommerceOrderApi.Models;
using FluentValidation;

namespace ECommerceOrderApi.Validators;

public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
{
    public CreateOrderRequestValidator()
    {
        RuleFor(request => request.CustomerName)
            .Must(name => !string.IsNullOrWhiteSpace(name))
            .WithMessage("CustomerName should not be empty or whitespace.");

        RuleFor(request => request.ProductName)
            .Must(name => !string.IsNullOrWhiteSpace(name))
            .WithMessage("ProductName should not be empty or whitespace.");

        RuleFor(request => request.TotalAmount)
            .GreaterThanOrEqualTo(request => request.Quantity * 100)
            .WithMessage("TotalAmount should be at least Quantity x 100 for this demo order system.");
    }
}
