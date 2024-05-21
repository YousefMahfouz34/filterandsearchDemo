using filterandsearchdemo.models;
using Microsoft.EntityFrameworkCore;

namespace filterandsearchdemo.context
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options):base(options) 
        {   
        }
        public DbSet<Empolyee> Empolyees { get; set;}
        public DbSet<Department> Departmentes { get; set;}  
    }
}
