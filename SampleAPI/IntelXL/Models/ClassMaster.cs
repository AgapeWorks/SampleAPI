using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class ClassMaster
{
    [JsonPropertyName("classId")]
    public int ClassId { get; set; }

    [JsonPropertyName("className")]
    public string ClassName { get; set; } = null!;
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("courseId")]
    public int CourseId { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("course")]
    public virtual CourseMaster? Course { get; set; }

    [JsonPropertyName("subjectMasters")]
    public virtual ICollection<SubjectMaster> SubjectMasters { get; set; } = new List<SubjectMaster>();
    [JsonPropertyName("subscriptionMasters")]
    public virtual ICollection<SubscriptionMaster> SubscriptionMasters { get; set; } = new List<SubscriptionMaster>();
}
