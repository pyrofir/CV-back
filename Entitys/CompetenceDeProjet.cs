using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("competences_de_projet")]
    public class CompetenceDeProjet
    {
        public int id { get; init; }
        public int competence { get; init; } 

        public int projet { get; init; }
    }
}
