using System.ComponentModel.DataAnnotations;

namespace SecretSanta.Models
{
    public class Teammate
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        
    }
}
