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

        // Adresse
       
        _ = modelBuilder.Entity<Adresse>()
            .ToTable("Adresse")
            .HasKey(adresse => adresse.Id); 

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse =>adresse.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Ville)
            .HasColumnName("Ville")
            .HasColumnType($"nvarchar({Adresse.MAX_VILLE_LENGTH})");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.NumeroCivique)
            .HasColumnName("NumeroCivique")
            .HasColumnType($"nvarchar({Adresse.MAX_NUMEROCIVIQUE_LENGTH})");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Pays)
            .HasColumnName("Pays")
            .HasColumnType($"nvarchar({Adresse.MAX_PAYS_LENGTH})");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.CodePostal)
            .HasColumnName("CodePostal")
            .HasColumnType($"nvarchar({Adresse.MAX_CODEPOSTAL_LENGTH})");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Province)
            .HasColumnName("Province")
            .HasColumnType($"nvarchar({Adresse.MAX_PROVINCE_LENGTH})");

         _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Rue)
            .HasColumnName("Rue")
            .HasColumnType($"nvarchar({Adresse.MAX_RUE_LENGTH})");

        // Entrepot

        _ = modelBuilder.Entity<Entrepot>()
            .ToTable("Entrepot")
            .HasKey(entrepot => entrepot.Id);

        _ = modelBuilder.Entity<Entrepot>()
            .Property(entrepot => entrepot.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Entrepot>()
           .Property(entrepot => entrepot.NomEntrepot)
           .HasColumnName("NomEntrepot")
           .HasColumnType($"nvarchar({Entrepot.MAX_NOMENTREPOT_LENGTH})");

        _ = modelBuilder.Entity<Entrepot>()
            .Property(entrepot => entrepot.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();

        // Relation 1-à-1 entre Entrepot et Adresse 

        _ = modelBuilder.Entity<Entrepot>()
           .HasOne(entrepot => entrepot.AdresseEntrepot)
           .WithOne(adresse => adresse.AdresseEntrepot);
















        #endregion








    }

}
