using System.Collections.Generic;
using CV_back.Entitys;
using CV_back.Repository;
using CV_back.ResponseModel;

namespace CV_back.Service
{
    //Service appelé par le contrôleur et qui va lui retourner les informations demandées en appelant les différents dépôts nécessaires et construisant la réponse
    public interface IExperiencesService
    {
        List<FullExperiences> GetAll();
    }
    public class ExperiencesService : IExperiencesService
    {
        private ExperiencesRepository _repoExperiences;
        private TachesExperiencesRepository _repoTachesExperiences;
        private TypeExperienceRepository _repoTypeExperience;
        private CompetencesDeProjetRepository _repoCompetencesDeProjet;
        private CompetenceRepository _repoCompetence;

        public ExperiencesService(ExperiencesRepository repoExperiences, TachesExperiencesRepository repoTachesExperiences, TypeExperienceRepository repoTypeExperience, CompetencesDeProjetRepository repoCompetencesDeProjet, CompetenceRepository repoCompetence)
        {
            _repoExperiences = repoExperiences;
            _repoTachesExperiences = repoTachesExperiences;
            _repoTypeExperience = repoTypeExperience;
            _repoCompetencesDeProjet = repoCompetencesDeProjet;
            _repoCompetence = repoCompetence;
        }

        public List<FullExperiences> GetAll()
        {

            var rep = new List<FullExperiences>();

            var experiences = _repoExperiences.GetAll();



            foreach (var experience in experiences) 
            {
                List<int> competencesIds = _repoCompetencesDeProjet.GetByProject(experience.id);
                List<Competence> competence = _repoCompetence.GetByIds(competencesIds);
                List<TacheExperience> taches = _repoTachesExperiences.GetById(experience.id);
                string? type = _repoTypeExperience.GetById(experience.id)?.type;

                rep.Add(new FullExperiences(experience, competence,taches, type));

            }







            return rep;
        }
    }
}
