using FinprintProject.Models.BaseEntities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinprintProject.Models.StudentRegistration
{
    public class FingerprintRegister : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        [ValidateNever]
        public StudentRegister StudentRegister { get; set; }


    }
}
