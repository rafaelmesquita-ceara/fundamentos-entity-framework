using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key] // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity
        public int Id { get; set; }

        [Required] // NOT NULL
        [MaxLength(80)] // NVARCHAR(80)
        [Column("Name", TypeName = "NVARCHAR")]
        public string? Name { get; set; }

        [Required] // NOT NULL
        [MaxLength(80)] // NVARCHAR(80)
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }
    }
}