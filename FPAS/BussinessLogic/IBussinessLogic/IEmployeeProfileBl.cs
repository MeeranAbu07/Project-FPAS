using FPAS.Model.Request;

namespace FPAS.BussinessLogic.IBussinessLogic
{
    public interface IEmployeeProfileBl
    {
        Task<string> CreateEmployeeProfile(EmployeeProfileRequest request);
    }
}
