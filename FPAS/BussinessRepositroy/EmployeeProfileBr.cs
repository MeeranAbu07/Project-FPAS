using FPAS.BussinessRepositroy.IBussinessRepositroy;
using FPAS.Model;

namespace FPAS.BussinessRepositroy
{
    public class EmployeeProfileBr : IEmployeeProfileBr
    {
        private readonly FPASDbContext mContext;

        public EmployeeProfileBr(FPASDbContext context)
        {
            mContext = context;
        }
    }
}
