using System.ComponentModel.DataAnnotations;

namespace ExpenseInAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Borrower { get; set; }

        [Required]
        public string Lender { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
    }
}
