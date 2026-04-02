using ECommerceOrderApi.Models;
using FluentValidation;

namespace ECommerceOrderApi.Validators;

public class UpdateOrderStatusRequestValidator : AbstractValidator<UpdateOrderStatusRequest>
{
    private static readonly string[] AllowedStatuses =
    [
        "Pending",
        "Confirmed",
        "Packed",
        "Shipped",
        "Delivered",
        "Cancelled"
    ];

    public UpdateOrderStatusRequestValidator()
    {
        RuleFor(request => request.Status)
            .Must(status => AllowedStatuses.Contains(status?.Trim(), StringComparer.OrdinalIgnoreCase))
            .WithMessage("Status must be Pending, Confirmed, Packed, Shipped, Delivered, or Cancelled.");
    }
}
