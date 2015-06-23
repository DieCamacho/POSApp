using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace POSApp.Models
{
    public class Products
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(60, MinimumLength = 3)]
        public string ProductName { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Created Date")]
        [StringLength(5)]
        public string Rating { get; set; }
        
    }

    
}