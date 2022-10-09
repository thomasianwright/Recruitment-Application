using Microsoft.EntityFrameworkCore;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Api.EntityFramework.MSSQL.Data;

namespace Recruitment.Api.EntityFramework.MSSQL.Repositories;

public class PostsRepository : IPostsRepository
{
    private readonly ApiContext _context;

    public PostsRepository(ApiContext context)
    {
        _context = context;
    }

    public async Task<JobPost?> GetJobPost(Guid id)
    {
        return await _context.JobPosts.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<IEnumerable<JobPost?>> GetJobPosts()
    {
        return Task.FromResult(_context.JobPosts.AsEnumerable());
    }

    public async Task<IEnumerable<JobPost?>> GetJobPosts(IList<Tag> tags)
    {
        return _context.JobPosts.Where(jp => jp != null && jp.Tags.Any(tags.Contains));
    }

    public async Task<IEnumerable<JobPost?>> GetJobPostsByCompanyId(Guid companyId)
    {
        return _context.JobPosts.Where(x => x.CompanyId == companyId);
    }

    public async Task<IEnumerable<JobPost>> GetJobPostsByAgentId(Guid agentId)
    {
        return _context.JobPosts.Where(x => x.Agents.Any(x => x.Id == agentId));
    }

    public async Task<JobPost> AddJobPost(JobPost jobPost)
    {
        var entity = await _context.AddAsync(jobPost);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task<JobPost> UpdateJobPost(JobPost jobPost)
    {
        var entity = _context.Update(jobPost);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task DeleteJobPost(Guid id)
    {
        var jp = await GetJobPost(id);

        _context.Remove(jp);

        await _context.SaveChangesAsync();
    }
}