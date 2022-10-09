using Microsoft.EntityFrameworkCore;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Api.EntityFramework.MSSQL.Data;

namespace Recruitment.Api.EntityFramework.MSSQL.Repositories;

public class TagsRepository : ITagRepository
{
    private readonly ApiContext _context;

    public TagsRepository(ApiContext context)
    {
        _context = context;
    }

    public async Task<Tag?> GetTag(Guid id)
    {
        return await _context.Tags.Include(x => x.JobPosts)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Tag>> GetTags()
    {
        return _context.Tags.AsEnumerable();
    }

    public async Task<IEnumerable<Tag>> GetTags(IList<Guid> tagIds)
    {
        return _context.Tags.Where(tag => tagIds.Contains(tag.Id));
    }

    public async Task<Tag> CreateTag(Tag tag)
    {
        var entity = await _context.AddAsync(tag);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task<Tag> UpdateTag(Tag tag)
    {
        var entity = _context.Tags.Update(tag);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task DeleteTag(Guid id)
    {
        var tag = await GetTag(id);

        _context.Remove(tag);

        await _context.SaveChangesAsync();
    }
}