using SecretSanta.Models;

namespace SecretSanta.Data
{
    public interface ITeammateRepo
    {
        public Task<IEnumerable<Teammate>> GetAllTeammates();
        public Task<Teammate> UdpateTeammate();
        public Task<Teammate> GetTeammateById(int id);
        
        //not async
        public void RemoveTeammate();
    }
}
