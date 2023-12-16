using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class UserPayment
{
    [JsonPropertyName("paymentId")]
    public int PaymentId { get; set; }

    [JsonPropertyName("appUserId")]
    public int AppUserId { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = "UnPaid";

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("paymentDate")]
    public DateTime PaymentDate { get; set; }

    [JsonPropertyName("response")]
    public string? Response { get; set; }

    [JsonPropertyName("recurringMethod")]
    public string RecurringMethod { get; set; } = "Month";

    [JsonPropertyName("appUser")]
    public virtual AppUser? AppUser { get; set; }
}
