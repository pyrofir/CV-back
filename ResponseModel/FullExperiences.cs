using CV_back.Entitys;

namespace CV_back.ResponseModel
{
    public class FullExperiences
    {
        public Experience experiences { get; }
        public List<Competence> competences { get; }
        public List<TacheExperience> taches { get; } 
        public string? type { get; }
        public FullExperiences(Experience _experiences, List<Competence> _competences, List<TacheExperience> _taches, string _type)
        {
            experiences = _experiences;
            competences = _competences;
            taches = _taches;
            type = _type;

        }
    }
}
