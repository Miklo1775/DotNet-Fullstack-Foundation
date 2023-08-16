using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETDemo.Controllers
{
    //below is an example of attribute routing
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Route("employees/all")]
        public string GetAllEmployees()
        {
            return "All Employees Here";
        }

        //below attribute shows route constraints after the semicolon
        [Route("emplyees/{id:int}")]
        public string GetEmployee(int id)
        {
            return "Employee with ID";
        }

        [Route("{id:int}")]
        public string GetEmployeeDetails(int id)
        {
            return "Employee details by id";
        }

        [Route("{name:alpha}")]
        public string GetEmployeeDetails(string name)
        {
            return name;
        }
    }
}
