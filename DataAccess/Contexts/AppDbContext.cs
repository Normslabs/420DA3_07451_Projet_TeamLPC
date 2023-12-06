using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts;
internal class AppDbContext : AbstractContext {


    public DbSet<Utilisateur> Utilisateurs { get; set; }

    public DbSet<Role> Roles { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase"].ConnectionString
            ?? throw new Exception("Missing required connection string setting key [ProjectDatabase].");

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(connString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        #region Utilisateur et Role (Prof) - pas touche :P

        // Utilisateur
        _ = modelBuilder.Entity<Utilisateur>()
            .ToTable("Utilisateurs")
            .HasKey(user => user.Id);

        _ = modelBuilder.Entity<Utilisateur>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.Id)
            .HasColumnName("Id")
            .HasColumnType("int");
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.Username)
            .HasColumnName("Username")
            .HasColumnType("nvarchar(32)");
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnType("nvarchar(128)");
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.EntrepotDeTravailId)
            .HasColumnName("EntrepotId")
            .HasColumnType("int")
            .IsRequired(false);
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2(7)")
            .HasDefaultValueSql("getdate()");
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.RowVersion)
            .HasColumnName("Version")
            .HasColumnType("rowversion")
            .IsRowVersion();


        // Role
        _ = modelBuilder.Entity<Role>()
            .ToTable("Roles")
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName("Id")
            .HasColumnType("int");
        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RoleName)
            .HasColumnName("Name")
            .HasColumnType("nvarchar(64)");
        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RoleDescription)
            .HasColumnName("Description")
            .HasColumnType("nvarchar(256)")
            .IsRequired(false);
        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName("Version")
            .HasColumnType("rowversion")
            .IsRowVersion();


        // Relation N-à-N entre Utilisateur et Role
        _ = modelBuilder.Entity<Utilisateur>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.UtilisateursPossedantRole);

        #endregion

        #region Adresse et Entrepot 

        #endregion







    }

}
