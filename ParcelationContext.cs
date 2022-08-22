using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using tst.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tst
{

    public class ParcelationContext : DbContext
    {
        public ParcelationContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Parcelation> Parcelation { get; set; }
    

    }
}

