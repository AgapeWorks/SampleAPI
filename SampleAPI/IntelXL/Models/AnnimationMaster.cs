namespace IntelXLDataAccess.Models;

public partial class AnnimationMaster
{
    public int AnnimationId { get; set; }

    public string? AnnimationUrl { get; set; }

    public string VideoUrl { get; set; } = null!;

    public int QuestionId { get; set; }

    public bool Status { get; set; } = true;

    public virtual QuestionMaster Question { get; set; } = null!;
}
