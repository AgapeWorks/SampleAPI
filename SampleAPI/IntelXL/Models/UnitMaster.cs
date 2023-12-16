using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class UnitMaster
{
    [JsonPropertyName("unitId")]
    public int UnitId { get; set; }

    [JsonPropertyName("unitName")]
    public string? UnitName { get; set; }

    [JsonPropertyName("subjectid")]
    public int Subjectid { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("subject")]
    public virtual SubjectMaster? Subject { get; set; }

    [JsonPropertyName("topicMasters")]
    public virtual ICollection<TopicMaster> TopicMasters { get; set; } = new List<TopicMaster>();
}
