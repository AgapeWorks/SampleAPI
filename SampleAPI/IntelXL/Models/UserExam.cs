using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class UserExam
{
    [JsonPropertyName("userExamId")]
    public int UserExamId { get; set; }
    [JsonPropertyName("appUserId")]
    public int AppUserId { get; set; }
    [JsonPropertyName("questionId")]
    public int QuestionId { get; set; }
    [JsonPropertyName("answeredStatus")]
    public int AnsweredStatus { get; set; }
}
