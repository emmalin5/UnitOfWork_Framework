using System.ComponentModel.DataAnnotations;

namespace FinprintProject.Models.BaseEntities
{
    public class BaseEntity
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }
    }
}
