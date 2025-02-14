namespace GoldyGopher.Models;
using System.ComponentModel.DataAnnotations;

public class NumberInput
{
    [Required]
    [Range(0, 900000, ErrorMessage = "Lower Number must be between 0 and 900000.")]
    public int LowerNumber { get; set; }

    [Required]
    [Range(21, 1000000, ErrorMessage = "Upper Number must be between 21 and 1000000.")]
    public int UpperNumber { get; set; }
}

