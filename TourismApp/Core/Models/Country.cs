using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }
    }
}