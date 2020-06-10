using EFStudy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudy.EF
{
    public class MysqlDbContext : DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
        {

        }

        public DbSet<address> addresses { get; set; }
    }
}
