using Entitystudent.Model;
using Microsoft.EntityFrameworkCore;

namespace Entitystudent.Data
{
    public class Studentcontext:DbContext
    {
        public Studentcontext(DbContextOptions<Studentcontext> options):base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }
        public DbSet<Student> student { get; set; } 

    }
}
