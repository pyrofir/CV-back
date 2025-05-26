using CV_back.Entitys;
using CV_back.Repository;
using CV_back.ResponseModel;

namespace CV_back.Service
{
    //Service appelé par le contrôleur et qui va lui retourner les informations demandées en appelant les différents dépôts nécessaires et construisant la réponse
    public interface ICompetenceService
    {
        List<Competence> GetAll();
        List<SortCompetences> GetAllSort();
    }

    public class CompetenceService : ICompetenceService
    {
        private CompetenceRepository _repoCompetence;
        private TypeDeCompetenceRepository _repoTypeDeCompetence;

        public CompetenceService(CompetenceRepository repoCompetence, TypeDeCompetenceRepository repoTypeDeCompetence)
        {
            _repoCompetence = repoCompetence;
            _repoTypeDeCompetence = repoTypeDeCompetence;
        }


        public List<Competence> GetAll()
        {
            return _repoCompetence.GetAll();
        }

        public List<SortCompetences> GetAllSort() 
        {
            var rep = new List<SortCompetences>();
            
            var typeComp = _repoTypeDeCompetence.GetAll();

            foreach (var type in typeComp) 
            {
                rep.Add(new SortCompetences(type.type, _repoCompetence.GetByType(type.id)));
            }

            return rep;
        }
    }
}
