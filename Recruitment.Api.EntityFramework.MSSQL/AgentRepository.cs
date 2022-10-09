using Microsoft.EntityFrameworkCore;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.Core.Entities;
using Recruitment.Api.EntityFramework.MSSQL.Data;

namespace Recruitment.Api.EntityFramework.MSSQL;

public class AgentRepository : IAgentRepository
{
    private readonly ApiContext _context;

    public AgentRepository(ApiContext context)
    {
        _context = context;
    }
    
    public async Task<Agent> GetAgent(Guid id)
    {
        return await _context.Agents.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Agent>> GetAgents(IList<Guid> ids)
    {
        return _context.Agents.Where(x => ids.Contains(x.Id));
    }

    public async Task<IEnumerable<Agent>> GetAgents()
    {
        return _context.Agents.AsEnumerable();
    }
    

    public async Task<Agent> CreateAgent(Agent agent)
    {
        var entity = await _context.AddAsync(agent);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task<Agent> UpdateAgent(Agent agent)
    {
        var entity = _context.Agents.Update(agent);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task DeleteAgent(Guid id)
    {
        var agent = await GetAgent(id);

        _context.Remove(agent);

        await _context.SaveChangesAsync();
    }
}