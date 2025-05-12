using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("competences")]
    public class Competence
    {
        public int id { get; init; }
        public int type { get; init; }
        public int note { get; init; }
        public string name { get; init; }
    }
}
