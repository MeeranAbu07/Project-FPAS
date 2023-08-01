using FPAS.BussinessLogic.IBussinessLogic;
using FPAS.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FPAS.Controllers
{
    [Route("api/employeeprofile")]
    [ApiController]
    public class EmployeeProfileController : ControllerBase
    {
        private readonly IEmployeeProfileBl mEmployeeProfileBl;

        public EmployeeProfileController(IEmployeeProfileBl employeeProfileBl)
        {
            mEmployeeProfileBl = employeeProfileBl;
        }
        [HttpPost("createEmployeeProfile")]
        public async Task<IActionResult> CreateEmployeeProfile([FromBody] EmployeeProfileRequest request)
        {
            string result = await mEmployeeProfileBl.CreateEmployeeProfile(request);
            return result != null ? Ok(result) : NoContent();

        }
    }
}
