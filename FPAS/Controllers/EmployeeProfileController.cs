using FPAS.BussinessLogic.IBussinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FPAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeProfileController : ControllerBase
    {
        private readonly IEmployeeProfileBl mEmployeeProfileBl;

        public EmployeeProfileController(IEmployeeProfileBl employeeProfileBl)
        {
            mEmployeeProfileBl = employeeProfileBl;
        }
    }
}
