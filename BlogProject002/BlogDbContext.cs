using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject002
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("name = Blog")
        {

        }
        public DbSet<AdminInfo> AdminInfo { get; set; }
        public DbSet<EmpInfo> EmpInfo { get; set; }
        public DbSet<BlogInfo> BlogInfo { get; set; }
    }
}
