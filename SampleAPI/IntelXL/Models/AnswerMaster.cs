using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class AnswerMaster
{
    [JsonPropertyName("answerId")]
    public int AnswerId { get; set; }

    [JsonPropertyName("answer")]
    public string Answer { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("questionMasters")]
    public virtual ICollection<QuestionMaster> QuestionMasters { get; set; } = new List<QuestionMaster>();
}
