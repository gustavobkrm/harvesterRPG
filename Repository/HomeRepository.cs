using harvesterRPG.Models;
using harvesterRPG.Repository.Interfaces;

namespace harvesterRPG.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;

        public HomeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<JobItem> teste(string dices, string climate)
        {
            var dicesArray = dices.Split(' ');
            var query = _context.jobItems
            .Where(j => dicesArray.Contains(j.ItemDices.ToString()) && j.Climate == climate)
            .ToList();

            return query;
        }
    }
}
