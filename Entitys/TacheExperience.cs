using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("taches_experiences")]
    public class TacheExperience
    {
        public int id { get; init; }
        public int experience { get; init; }
        public string tache { get; init; }
    }
}
