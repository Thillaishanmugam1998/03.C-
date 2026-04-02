using System.ComponentModel.DataAnnotations;

namespace ECommerceOrderApi.Models;

public class UpdateOrderStatusRequest
{
    [Required]
    [StringLength(20, MinimumLength = 3)]
    public string Status { get; set; } = string.Empty;
}
