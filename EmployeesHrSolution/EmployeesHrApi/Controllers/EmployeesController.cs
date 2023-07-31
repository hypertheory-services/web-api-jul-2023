

using Microsoft.AspNetCore.Mvc;

namespace EmployeesHrApi.Controllers;

public class EmployeesController : ControllerBase
{

    // GET /employees
    [HttpGet("/employees")]
    public async Task<ActionResult> GetEmployeesAsync()
    {
        // TODO: Get Back to This
        return Ok("Tacos are good, I might have some for lunch");
    }


}
