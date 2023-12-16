using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class CourseMaster
{
    [JsonPropertyName("courseId")]
    public int CourseId { get; set; }
    [JsonPropertyName("courseName")]

    public string? CourseName { get; set; }
    [JsonPropertyName("courseDuration")]

    public decimal? CourseDuration { get; set; }
    [JsonPropertyName("updatedDttm")]

    public DateTime? UpdatedDttm { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("classMasters")]

    public virtual ICollection<ClassMaster> ClassMasters { get; set; } = new List<ClassMaster>();

    [JsonPropertyName("subscriptionMasters")]
    public virtual ICollection<SubscriptionMaster> SubscriptionMasters { get; set; } = new List<SubscriptionMaster>();
}
