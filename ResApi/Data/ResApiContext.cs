using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResApi;

namespace ResApi.Data
{
    public class ResApiContext : DbContext
    {
        public ResApiContext (DbContextOptions<ResApiContext> options)
            : base(options)
        {
        }

        public DbSet<ResApi.User> User { get; set; }
    }
}
