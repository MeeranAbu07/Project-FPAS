using FPAS.BussinessRepositroy.IBussinessRepositroy;
using FPAS.Model;
using FPAS.Model.Entites;
using FPAS.Model.Request;

namespace FPAS.BussinessRepositroy
{
    public class EmployeeProfileBr : IEmployeeProfileBr
    {
        private readonly FPASDbContext mContext;

        public EmployeeProfileBr(FPASDbContext context)
        {
            mContext = context;
        }
        public async Task<string> CreateEmployeeProfile(EmployeeProfileRequest request)
        {
            try
            {
                EmployeeProfile employeeProfile = new EmployeeProfile()
                {
                    Name = request.Name,
                    Age = request.Age,
                    EmployeeId = request.EmployeeId,
                    RoleId = request.RoleId,
                    PhoneNumber = request.PhoneNumber,
                    EmailAddress = request.EmailAddress,
                    FatherName = request.FatherName,
                    MotherName = request.MotherName,
                    State = request.State,
                    Address = request.Address,
                    Nationalatiy = request.Nationalatiy,
                    Distict = request.Distict,
                    DateOfJoinig = request.DateOfJoinig,
                };
                await mContext.EmployeeProfile.AddAsync(employeeProfile);
                await mContext.SaveChangesAsync();
                return employeeProfile.Name;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}
