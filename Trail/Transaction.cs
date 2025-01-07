using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trail
{
    public class Transaction
    {
        [Key]
        public int TransactionID {  get; set; }

        public int CategoryID { get; set; }


        public Category? Category { get; set; }

        [Column(TypeName = "nVarchar(50)")]
        public string? TransactionNote { get; set; }

        public double Amount { get; set; }


        public DateTime DateTime { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryWithIcon
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.CategoryName;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0");
            }
        }

    }
}
