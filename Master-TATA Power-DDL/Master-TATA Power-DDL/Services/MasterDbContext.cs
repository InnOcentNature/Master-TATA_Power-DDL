using Master_TATA_Power_DDL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Services
{
    public class MasterDbContext :DbContext
    {
        public DbSet<Circle> Circles { get; set; }
    }
}