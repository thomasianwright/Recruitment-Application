using AutoMapper;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Shared.Core.Dto;

namespace Recruitment.Api.Services.Services;

public class PostService
{
    private readonly IPostsRepository _postRepository;
    private readonly IAgentRepository _agentRepository;
    private readonly ITagRepository _tagRepository;
    private readonly IMapper _mapper;

    public PostService(IPostsRepository postRepository,
        IAgentRepository agentRepository,
        ITagRepository tagRepository,
        IMapper mapper)
    {
        _postRepository = postRepository;
        _agentRepository = agentRepository;
        _tagRepository = tagRepository;
        _mapper = mapper;
    }

    public async Task<JobPostDto> GetJobPost(Guid id)
    {
        var jobPost = await _postRepository.GetJobPost(id);

        var jobPostDto = _mapper.Map<JobPostDto>(jobPost);

        return jobPostDto;
    }

    public async Task<IEnumerable<JobPostDto>> GetJobPosts()
    {
        var jobPosts = await _postRepository.GetJobPosts();

        var jobPostDtos = _mapper.Map<IEnumerable<JobPostDto>>(jobPosts);

        return jobPostDtos;
    }

    public async Task<IEnumerable<JobPostDto>> GetJobPosts(IList<Tag> tags)
    {
        var jobPosts = await _postRepository.GetJobPosts(tags);

        var jobPostDtos = _mapper.Map<IEnumerable<JobPostDto>>(jobPosts);

        return jobPostDtos;
    }

    public async Task<IEnumerable<JobPostDto>> GetJobPostsByCompanyId(Guid companyId)
    {
        var jobPosts = await _postRepository.GetJobPostsByCompanyId(companyId);

        var jobPostDtos = _mapper.Map<IEnumerable<JobPostDto>>(jobPosts);

        return jobPostDtos;
    }

    public async Task<IEnumerable<JobPostDto>> GetJobPostByAgentId(Guid id)
    {
        var jobPosts = await _postRepository.GetJobPostsByAgentId(id);

        var jobPostDtos = _mapper.Map<IEnumerable<JobPostDto>>(jobPosts);

        return jobPostDtos;
    }

    public async Task<JobPostDto> CreateJobPost(CreateJobPostDto post)
    {
        var agents = await _agentRepository.GetAgents(post.AgentIds);
        var accountManager = await _agentRepository.GetAgent(post.AccountManagerId);
        var tags = await _tagRepository.GetTags(post.Tags);
        
        var newJobPost = _mapper.Map<JobPost>(post);

        newJobPost.Id = Guid.NewGuid();
        newJobPost.Agents = agents.ToList();
        newJobPost.AccountManager = accountManager;
        newJobPost.AccountManagerId = post.AccountManagerId;
        newJobPost.CreatedAt = DateTime.Now;
        newJobPost.Tags = tags.ToList();

        return _mapper.Map<JobPostDto>(newJobPost);
    }

    // public async Task<JobPostDto> UpdateJobPost(UpdateJobPostDto updatePost)
    // {
    //     
    // }
}