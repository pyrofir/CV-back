using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("tache_experience")]
    public class TacheExperience
    {
        public int id { get; init; }
        public string type { get; init; }
    }
}
