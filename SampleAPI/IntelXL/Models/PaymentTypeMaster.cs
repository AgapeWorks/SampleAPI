using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IntelXLDataAccess.Models;

public partial class PaymentTypeMaster
{
    [JsonPropertyName("paymentId")]
    public int PaymentId { get; set; }

    [JsonPropertyName("paymentType")]
    public string? PaymentType { get; set; }

    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }

    [JsonPropertyName("paymentStatus")]
    public string? PaymentStatus { get; set; }

    [JsonPropertyName("updatedDttm")]
    public DateTime UpdatedDttm { get; set; }    
}
