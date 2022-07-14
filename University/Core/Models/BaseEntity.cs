using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class BaseEntity
    {
        [Key]
        public int      Id        { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; }
        public bool     IsDeleted { get; set; }
    }
}