using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLiteEFsample.Models;

namespace SQLiteEFsample.Data
{
    public class MySqliteContext : DbContext
    {
        public MySqliteContext (DbContextOptions<MySqliteContext> options)
            : base(options)
        {
        }

        public DbSet<SQLiteEFsample.Models.Car> Car { get; set; } = default!;
    }
}
