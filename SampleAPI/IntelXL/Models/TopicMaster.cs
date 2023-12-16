using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class TopicMaster
{
    [JsonPropertyName("topicId")]
    public int TopicId { get; set; }

    [JsonPropertyName("topic")]
    public string Topic { get; set; } = null!;

    [JsonPropertyName("unitId")]
    public int UnitId { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("subTopicMasters")]
    public virtual ICollection<SubTopicMaster> SubTopicMasters { get; set; } = new List<SubTopicMaster>();

    [JsonPropertyName("unit")]
    public virtual UnitMaster? Unit { get; set; }
}
