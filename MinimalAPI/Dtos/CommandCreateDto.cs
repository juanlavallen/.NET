using System.ComponentModel.DataAnnotations;

namespace MinimalAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(5)]
        public string Plataform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}