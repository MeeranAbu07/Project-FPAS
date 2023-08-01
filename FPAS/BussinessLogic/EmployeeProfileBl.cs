using FPAS.BussinessLogic.IBussinessLogic;
using FPAS.BussinessRepositroy;
using FPAS.BussinessRepositroy.IBussinessRepositroy;
using FPAS.Model.Request;

namespace FPAS.BussinessLogic
{
    public class EmployeeProfileBl : IEmployeeProfileBl
    {
        private readonly IEmployeeProfileBr mEmployeeProfileBr;

        public EmployeeProfileBl(IEmployeeProfileBr employeeProfileBr)
        {
            mEmployeeProfileBr = employeeProfileBr;
        }
        public async Task<string> CreateEmployeeProfile(EmployeeProfileRequest request)
        {
            return await mEmployeeProfileBr.CreateEmployeeProfile(request);

        }
    }
}
