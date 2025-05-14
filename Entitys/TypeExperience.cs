using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("type_experience")]
    public class TypeExperience
    {
        public int id { get; init; }
        public string type { get; init; }
    }
}
