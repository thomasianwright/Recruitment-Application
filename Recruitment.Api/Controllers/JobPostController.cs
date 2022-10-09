using Microsoft.AspNetCore.Mvc;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;

namespace Recruitment.Api.Controllers;

[ApiController]
[Route("posts")]
public class JobPostController : ControllerBase
{
    /// <summary>
    /// Gets a job post by id
    /// </summary>
    /// <param name="id">job post id</param>
    /// <returns><see cref="JobPostDto"/></returns>
    public async Task<ActionResult<JobPost?>> GetJobPost([FromQuery] Guid id)
    {
        
        return Ok();
    }
}