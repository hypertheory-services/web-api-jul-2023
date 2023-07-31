

using Microsoft.AspNetCore.Mvc;

namespace EmployeesHrApi.Controllers;

public class EmployeesController : ControllerBase
{

    // GET /employees
    [HttpGet("/employees")]
    public async Task<ActionResult> GetEmployeesAsync()
    {
        return Ok("Tacos are good, I might have some for lunch");
    }


}
