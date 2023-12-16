using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class ChoiceMaster
{
    [JsonPropertyName("choiceId")]
    public int ChoiceId { get; set; }

    [JsonPropertyName("choice")]
    public string? Choice { get; set; }
    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [JsonPropertyName("questionId")]
    public int QuestionId { get; set; }
    [JsonPropertyName("question")]
    public virtual QuestionMaster? Question { get; set; }
}
