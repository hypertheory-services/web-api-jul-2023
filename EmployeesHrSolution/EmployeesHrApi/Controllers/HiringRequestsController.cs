using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeesHrApi.Data;
using EmployeesHrApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesHrApi.Controllers;

public class HiringRequestsController : ControllerBase
{
    private readonly EmployeeDataContext _context;
    private readonly IMapper _mapper;
    private readonly MapperConfiguration _mapperConfig;

    public HiringRequestsController(EmployeeDataContext context, IMapper mapper, MapperConfiguration mapperConfig)
    {
        _context = context;
        _mapper = mapper;
        _mapperConfig = mapperConfig;
    }

    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 10)]
    [HttpPost("/hiring-requests")]
    public async Task<ActionResult> AddHiringRequestAsync([FromBody] HiringRequestCreateRequest request)
    {
        // 1. Validate it a little? - if it isn't valid, send them a 400 (Bad Request)
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // 400
        }
        // 2. Save it to the database.

        var newHiringRequest = _mapper.Map<HiringRequests>(request);
        _context.HiringRequests.Add(newHiringRequest);
        
        await _context.SaveChangesAsync();
        
        var response = _mapper.Map<HiringRequestResponseModel>(newHiringRequest);
        return CreatedAtRoute("hiring-request#gethiringrequestbyidasync", new { id=response.Id }, response);
    }

    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 10)]
    [HttpGet("/hiring-requests/{id:int}", Name ="hiring-request#gethiringrequestbyidasync")]
    public async Task<ActionResult> GetHiringRequestByIdAsync(int id)
    {
        var hiringRequest = await _context.HiringRequests
            .Where(e => e.Id == id)
            .ProjectTo<HiringRequestResponseModel>(_mapperConfig)
            .SingleOrDefaultAsync(); 

        if(hiringRequest is not null)
        {
            return Ok(hiringRequest);
        } else
        {
            return NotFound();
        }
    }
}
