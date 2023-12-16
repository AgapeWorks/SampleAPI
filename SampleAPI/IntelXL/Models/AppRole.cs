using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class AppRole
{
    [JsonPropertyName("appRoleId")]
    public int AppRoleId { get; set; }

    [JsonPropertyName("roleName")]
    public string RoleName { get; set; } = null!;

    [JsonPropertyName("updatedDttm")]
    public DateTime? UpdatedDttm { get; set; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; set; }
    [JsonPropertyName("status")]
    public bool Status { get; set; } = true;
    [JsonPropertyName("appUsers")]
    public virtual ICollection<AppUser> AppUsers { get; set; } = new List<AppUser>();  

}
