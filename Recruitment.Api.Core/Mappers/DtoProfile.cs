using AutoMapper;
using Recruitment.Api.Core.Entities;
using Recruitment.Shared.Core.Dto;
using Recruitment.Shared.Core.Enum;

namespace Recruitment.Api.Core.Mappers;

public class DtoProfile : Profile
{
    public DtoProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<JobPost, JobPostDto>()
            .ForMember(x => x.Applicants, expression =>
            {
                expression.MapFrom((post, dto, count) =>
                {
                    var appCount = post.Applicants.Count(x => x.CurrentStatus != ApplicationStatus.Declined);

                    return appCount;
                });
            });

        CreateMap<Tag, TagDto>();
        CreateMap<Company, CompanyDto>();
        CreateMap<UserApplication, UserApplicationDto>();
        CreateMap<Agent, AgentDto>();
    }
}