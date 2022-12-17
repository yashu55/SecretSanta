using System.ComponentModel.DataAnnotations;

namespace SecretSanta.Dto
{
    public class TeammateUpdateDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
