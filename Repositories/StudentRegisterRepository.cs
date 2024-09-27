using FinprintProject.Data;
using FinprintProject.Models.StudentRegistration;
using FinprintProject.Repositories;
using FinprintProject.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinprintProject.Repository
{
    public class StudentRegisterRepository : Repository<StudentRegister>,IStudentRegisterRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRegisterRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        

    }
}
