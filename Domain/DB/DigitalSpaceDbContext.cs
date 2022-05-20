using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DB
{
    public class DigitalSpaceDbContext : DbContext
    {
        public DigitalSpaceDbContext(DbContextOptions<DigitalSpaceDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Alquiler { get; set; }
    }
}
