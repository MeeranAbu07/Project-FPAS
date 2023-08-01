using FPAS.Model.Request;

namespace FPAS.BussinessRepositroy.IBussinessRepositroy
{
    public interface IEmployeeProfileBr
    {
        Task<string> CreateEmployeeProfile(EmployeeProfileRequest request);
    }
}
