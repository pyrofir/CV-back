using CV_back.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;


namespace CV_back.data
{
    //Tables de la database utilisé par les repository
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<TypeExperience> TypeExperiences { get; set; }
        public DbSet<TacheExperience> TachesExperiences { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<TypeDeCompetence> TypeDeCompetences { get; set; }
        public DbSet<CompetenceDeProjet> CompetencesDeProjet { get; set; }
        public DbSet<Formation> Formations { get; set; }
    }
}
