using FinprintProject.Models.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace FinprintProject.Models.StudentRegistration
{
    public class StudentRegister : BaseEntity
    {
        private string email;
        private string address;

        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }


    }
}
