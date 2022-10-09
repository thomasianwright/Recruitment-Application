using Recruitment.Api.Core.Entities;

namespace Recruitment.Api.Abstractions.Contracts;

public interface ITagRepository
{
    Task<Tag?> GetTag(Guid id);
    Task<IEnumerable<Tag>> GetTags();
    Task<IEnumerable<Tag>> GetTags(IList<Guid> tagIds);
    Task<Tag> CreateTag(Tag tag);
    Task<Tag> UpdateTag(Tag tag);
    Task DeleteTag(Guid id);
}