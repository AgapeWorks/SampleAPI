using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class SubTopicMaster
{
    [JsonPropertyName("subTopicId")]
    public int SubTopicId { get; set; }
    [JsonPropertyName("subTopic")]
    public string SubTopic { get; set; } = null!;
    [JsonPropertyName("topicId")]
    public int TopicId { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("questionMasters")]
    public virtual ICollection<QuestionMaster> QuestionMasters { get; set; } = new List<QuestionMaster>();
    [JsonPropertyName("topic")]
    public virtual TopicMaster? Topic { get; set; }
}
