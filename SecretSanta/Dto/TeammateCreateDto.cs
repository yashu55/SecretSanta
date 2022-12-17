using System.ComponentModel.DataAnnotations;

namespace SecretSanta.Dto
{
    public class TeammateCreateDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
