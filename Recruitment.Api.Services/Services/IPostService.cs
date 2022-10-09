using Recruitment.Api.Core.Entities;
using Recruitment.Shared.Core.Dto;

namespace Recruitment.Api.Services.Services;

public interface IPostService
{
    Task<JobPostDto> GetJobPost(Guid id);
    Task<IEnumerable<JobPostDto>> GetJobPosts();
    Task<IEnumerable<JobPostDto>> GetJobPosts(IList<Tag> tags);
    Task<IEnumerable<JobPostDto>> GetJobPostsByCompanyId(Guid companyId);
    Task<IEnumerable<JobPostDto>> GetJobPostByAgentId(Guid id);
    Task<JobPostDto> CreateJobPost(CreateJobPostDto post);
    Task<JobPostDto> UpdateJobPost(UpdateJobPostDto updatePost);
}