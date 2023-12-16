using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class QuestionMaster
{
    [JsonPropertyName("questionId")]
    public int QuestionId { get; set; }

    [JsonPropertyName("question")]
    public string Question { get; set; } = null!;

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("subTopicId")]
    public int SubTopicId { get; set; }

    [JsonPropertyName("answerId")]
    public int? AnswerId { get; set; }
    [JsonPropertyName("isVerified")]
    public bool IsVerified { get; set; } = false;
    public virtual ICollection<AnnimationMaster> AnnimationMasters { get; set; } = new List<AnnimationMaster>();
    [JsonPropertyName("answer")]
    public virtual AnswerMaster? Answer { get; set; }

    [JsonPropertyName("choiceMasters")]
    public virtual ICollection<ChoiceMaster> ChoiceMasters { get; set; } = new List<ChoiceMaster>();

    [JsonPropertyName("subTopic")]
    public virtual SubTopicMaster? SubTopic { get; set; }
}
