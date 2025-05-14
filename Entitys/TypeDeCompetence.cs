using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("type_de_competences")]
    public class TypeDeCompetence
    {
        public int id { get; init; }
        public string type { get; init; }
    }
}
