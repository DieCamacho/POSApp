using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace POSApp.Models
{
    public class UnitOfMeasurements
    {
        [Key]
        [Required]
        public int MeasureID { get; set; }

        [Display(Name = "Measure Code")]
        [StringLength(10, MinimumLength = 3)]
        public string MeasureCode { get; set; }
    }
}