using System.ComponentModel.DataAnnotations;

namespace ExpenseInAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Expense Name")]
        [Required]
        public string ExpenseName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public int Amount { get; set; }
    }
}
