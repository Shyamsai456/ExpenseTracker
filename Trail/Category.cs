using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Trail
{
    public class Category
    {
        [Key]
        public int CategoryID {  get; set; }

        [Required]
        [Column(TypeName = "nVarchar(50)")]
        public string CategoryName { get; set; }

        [AllowNull]
        [Column(TypeName = "nVarchar(50)")]
        public string CategoryDescription { get; set; } = null;

        [Column(TypeName = "nVarchar(50)")]
        [AllowNull]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nVarchar(10)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? CategoryWithIcon
        {
            get
            {
                return this.Icon + " " + this.CategoryName;
            }
        }
    }
}
