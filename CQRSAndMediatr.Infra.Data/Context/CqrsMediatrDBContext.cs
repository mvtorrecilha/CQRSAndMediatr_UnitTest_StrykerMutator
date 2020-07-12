using CQRSAndMediatr.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndMediatr.Infra.Data.Context
{
    public class CqrsMediatrDBContext : DbContext
    {
        public CqrsMediatrDBContext(DbContextOptions<CqrsMediatrDBContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }

    }
}
