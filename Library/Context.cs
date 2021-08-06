using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Library
{
    public class Context :DbContext
    {
        public Context() : base("DefaultConnection")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Progress> Progresses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        /// <summary>
        /// если нужно изменить настройки по умолчанию
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(20, 5));
        }
    }
}