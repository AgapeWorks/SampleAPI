using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class SubjectMaster
{
    [JsonPropertyName("subjectId")]
    public int SubjectId { get; set; }

    [JsonPropertyName("classId")]
    public int ClassId { get; set; }

    [JsonPropertyName("subjectName")]
    public string? SubjectName { get; set; }

    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;

    [NotMapped]
    [JsonPropertyName("subTopicCount")]
    public int subTopicCount { get; set; }

    [JsonPropertyName("class")]
    public virtual ClassMaster? Class { get; set; }

    [JsonPropertyName("unitMasters")]
    public virtual ICollection<UnitMaster> UnitMasters { get; set; } = new List<UnitMaster>();
}
