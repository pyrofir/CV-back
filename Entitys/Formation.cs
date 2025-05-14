using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("formation")]
    public class Formation
    {
        public int id { get; init; }
        public string dates { get; init; }
        public string ecole { get; init; }
        public string specialisation { get; init; }
        public string? description { get; init; }
    }
}
