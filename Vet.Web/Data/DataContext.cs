using Microsoft.EntityFrameworkCore;
using Vet.Web.Data.Entities;

namespace Vet.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Owner> Owners { get; set; }
    }
}
