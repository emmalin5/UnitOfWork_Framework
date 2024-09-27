using FinprintProject.Data;
using FinprintProject.Models.StudentRegistration;
using FinprintProject.Repositories;
using FinprintProject.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;

namespace FinprintProject.Repository
{
    public class FingerprintRegisterRepository : Repository<FingerprintRegister>, IFingerprintRegisterRepository
    {
        private readonly ApplicationDbContext _context;
        public FingerprintRegisterRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}
