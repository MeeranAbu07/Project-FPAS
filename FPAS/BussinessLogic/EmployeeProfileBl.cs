using FPAS.BussinessLogic.IBussinessLogic;
using FPAS.BussinessRepositroy;
using FPAS.BussinessRepositroy.IBussinessRepositroy;

namespace FPAS.BussinessLogic
{
    public class EmployeeProfileBl : IEmployeeProfileBl
    {
        private readonly IEmployeeProfileBr mEmployeeProfileBr;

        public EmployeeProfileBl(IEmployeeProfileBr employeeProfileBr)
        {
            mEmployeeProfileBr = employeeProfileBr;
        }
    }
}
