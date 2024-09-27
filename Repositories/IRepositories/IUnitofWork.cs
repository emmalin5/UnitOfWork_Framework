namespace FinprintProject.Repository.IRepository
{
    public interface IUnitofWork: IDisposable
    {
        IFingerprintRegisterRepository Fingerprints { get; set; }
        IStudentRegisterRepository Students { get; }
    }
}
