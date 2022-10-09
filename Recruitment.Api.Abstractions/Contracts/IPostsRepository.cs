using Recruitment.Api.Core.Entities;

namespace Recruitment.Api.Abstractions.Contracts;

public interface IPostsRepository
{
    Task<JobPost?> GetJobPost(Guid id);
    Task<IEnumerable<JobPost?>> GetJobPosts();
    Task<IEnumerable<JobPost?>> GetJobPosts(IList<Tag> tags);
    Task<IEnumerable<JobPost?>> GetJobPostsByCompanyId(Guid companyId);
    Task<IEnumerable<JobPost>> GetJobPostsByAgentId(Guid agentId);
    Task<JobPost> AddJobPost(JobPost jobPost);
    Task<JobPost> UpdateJobPost(JobPost jobPost);
    Task DeleteJobPost(Guid id);
}