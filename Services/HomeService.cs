using harvesterRPG.Models;
using harvesterRPG.Repository;
using harvesterRPG.Repository.Interfaces;
using harvesterRPG.Services.Interfaces;

namespace harvesterRPG.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }


        public List<JobItem> teste(string dices, string climate) {
            return _homeRepository.teste(dices, climate);
        }
    }
}
