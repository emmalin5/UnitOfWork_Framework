using FinprintProject.Data;
using FinprintProject.Repository.IRepository;

namespace FinprintProject.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _context;
        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
          
        }
        public IFingerprintRegisterRepository Fingerprints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IStudentRegisterRepository Students => throw new NotImplementedException();
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}