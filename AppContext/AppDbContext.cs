using AmApp.Ext;
using AmApp.Models.Identity;
using AmApp.Models.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace AmApp.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<UserRole> UserRoles => Set<UserRole>();
        public DbSet<Pasport> Pasports => Set<Pasport>();
        public DbSet<Operation> Operations => Set<Operation>();
        public DbSet<OperRashod> OperRashods => Set<OperRashod>();
        public DbSet<FactZagot> FactZagots => Set<FactZagot>();
        public DbSet<FactWorker> FactWorkers => Set<FactWorker>();
        public DbSet<Zagot> Zagots => Set<Zagot>();
        public DbSet<Ceh> Cehs => Set<Ceh>();
        public DbSet<Tek> Teks => Set<Tek>();
        public DbSet<Splav> Splavs => Set<Splav>();
        public DbSet<TekOper> TekOpers => Set<TekOper>();
        public DbSet<NPlav> Nplavs => Set<NPlav>();
        public DbSet<GlobalOborud> GlobalOboruds => Set<GlobalOborud>();
        public DbSet<OperOborud> OperOboruds => Set<OperOborud>();
        public DbSet<AuthorizeMethodRole> AuthorizeMethodRoles => Set<AuthorizeMethodRole>();
        public DbSet<ZagotIn> ZagotsIn => Set<ZagotIn>();
        public DbSet<ZagotOut> ZagotsOut => Set<ZagotOut>();

        public AppDbContext() => Database.EnsureCreated();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=proizv_data_base.db");
            //optionsBuilder.UseJet("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DB\\DBAccess.mdb; Jet OLEDB:Database Password=1234;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZagotIn>()
                .HasAlternateKey(e => new { e.Id, e.ZagotId, e.OperRashodId });
            modelBuilder.Entity<ZagotOut>()
                .HasAlternateKey(e => new { e.Id, e.ZagotId, e.FactZagotId });

            base.OnModelCreating(modelBuilder);
        }
    }
}