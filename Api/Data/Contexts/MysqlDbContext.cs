using Api.Areas.User.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Contexts
{
    public class MysqlDbContext : IdentityDbContext
    {
        private DbSet<User> Users { get; set; }

        public MysqlDbContext(DbContextOptions<MysqlDbContext> opts) : base(opts)
        {
        }
    }
}