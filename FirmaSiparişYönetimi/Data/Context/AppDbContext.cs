using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {


        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }


   

    }

}