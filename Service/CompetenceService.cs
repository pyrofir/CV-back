using CV_back.Entitys;
using CV_back.Repository;

namespace CV_back.Service
{

    public interface ICompetenceService
    {
        List<Competence> GetAll();
    }

    public class CompetenceService : ICompetenceService
    {
        private CompetenceRepository _repo;

        public CompetenceService(CompetenceRepository repo)
        {
            _repo = repo;
        }


        public List<Competence> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
