using Microsoft.AspNetCore.Mvc;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Api.Services.Services;

namespace Recruitment.Api.Controllers;

[ApiController]
[Route("posts")]
public class JobPostController : ControllerBase
{
    private readonly IPostService _postService;

    public JobPostController(IPostService postService)
    {
        _postService = postService;
    }
    
    /// <summary>
    /// Gets a job post by id
    /// </summary>
    /// <param name="id">job post id</param>
    /// <returns><see cref="JobPostDto"/></returns>
    public async Task<ActionResult<JobPost?>> GetJobPost([FromQuery] Guid id)
    {
        try
        {
            var post = await _postService.GetJobPost(id);

            return Ok(post);
        }
        catch(Exception e)
        {
            return BadRequest();
        }
    }
}