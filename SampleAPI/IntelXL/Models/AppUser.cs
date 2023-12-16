using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class AppUser
{
    [JsonPropertyName("appUserId")]
    public int AppUserId { get; set; }
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
    [JsonPropertyName("password")]
    public string? Password { get; set; }
    [JsonPropertyName("appRoleId")]
    public int? AppRoleId { get; set; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("emailId")]
    public string? EmailId { get; set; }
    [JsonPropertyName("updatedDttm")]
    public DateTime? UpdatedDttm { get; set; }
    [JsonPropertyName("updatedBy")]
    public DateTime? UpdatedBy { get; set; }
    [JsonPropertyName("appRole")]
    public virtual AppRole? AppRole { get; set; }
    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;
    [JsonPropertyName("userSubscriptions")]
    public virtual ICollection<UserSubscription> UserSubscriptions { get; set; } = new List<UserSubscription>();
    [JsonPropertyName("userPayments")]
    public virtual ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();
    [JsonPropertyName("userLogin")]
    public virtual UserLogin? UserLogin { get; set; }
}

