using Microsoft.EntityFrameworkCore;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Api.EntityFramework.MSSQL.Data;

namespace Recruitment.Api.EntityFramework.MSSQL;

public class TagsRepository : ITagRepository
{
    private readonly ApiContext _context;

    public TagsRepository(ApiContext context)
    {
        _context = context;
    }
    
    public async Task<Tag?> GetTag(Guid id)
    {
        return await _context.Tags.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Tag>> GetTags()
    {
        return await _context.Tags.ToListAsync();
    }

    public async Task<IEnumerable<Tag>> GetTags(IList<Guid> tagIds)
    {
        return _context.Tags.Where(tag => tagIds.Contains(tag.Id));
    }
}