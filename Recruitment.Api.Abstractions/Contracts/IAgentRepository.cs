using Recruitment.Api.Core.Entities;

namespace Recruitment.Api.Abstractions.Contracts;

public interface IAgentRepository
{
    Task<Agent> GetAgent(Guid id);
    Task<IEnumerable<Agent>> GetAgents(IList<Guid> ids);
    Task<IEnumerable<Agent>> GetAgents();
    Task<Agent> CreateAgent(Agent agent);
    Task<Agent> UpdateAgent(Agent agent);
    Task DeleteAgent(Guid id);
}