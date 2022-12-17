using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;
using SecretSanta.Models;

namespace SecretSanta.Data
{
    public class TeammateRepo  : ITeammateRepo
    {

        private readonly ApplicationDbContext _context;
        public TeammateRepo(ApplicationDbContext context) {
            _context = context;
        }
        //get lost of all the teammates
        async public Task<IEnumerable<Teammate>> GetAllTeammates() {
            return await _context.Teammates.ToListAsync();
        }
        //get one teammate on id
        async public Task<Teammate> GetTeammateById(int id) { 
            return await _context.Teammates.FirstOrDefaultAsync(t => t.Id == id);
        }
        //update
        public async Task<Teammate> UdpateTeammate()
        {
            throw new NotImplementedException();
        }

        public void RemoveTeammate()
        {
            throw new NotImplementedException();
        }

         
            
        
    }
}
