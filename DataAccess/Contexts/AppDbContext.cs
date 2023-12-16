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
            .HasColumnType($"nvarchar({Utilisateur.USERNAME_MAX_LENGTH})");
        _ = modelBuilder.Entity<Utilisateur>()
            .Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnType($"nvarchar({Utilisateur.PASSWORDHASH_MAX_LENGTH})");
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
            .HasColumnType($"nvarchar({Role.ROLENAME_MAX_LENGTH})");
        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RoleDescription)
            .HasColumnName("Description")
            .HasColumnType($"nvarchar({Role.ROLEDESC_MAX_LENGTH})")
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






        #region Client et ShippingOrder (Djibril)


        _ = modelBuilder.Entity<ClientsDTO>()
            .ToTable("Clients")
            .HasKey(client => client.Id);

        _= modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Id)
            .HasColumnName("Id")
            .HasColumnType("int");
        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Nom)
            .HasColumnName("Nom")
            .HasColumnType("nvarchar(48)");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Prenom)
            .HasColumnName("Prenom")
            .HasColumnType("nvarchar(48)");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Courriel)
            .HasColumnName("Courriel")
            .HasColumnType("nvarchar(128)");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Telephone)
            .HasColumnName("Telephone")
            .HasColumnType("bigint");

        _ = modelBuilder.Entity<ClientsDTO>()
           .Property(client => client.AsignedWarehouseID)
           .HasColumnName("AsignedWarehouseID")
           .HasColumnType("int");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.ClientAdressId)
            .HasColumnName("ClientAdressId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.CompanyName)
            .HasColumnName("CompanyName")
            .HasColumnType("nvarchar(50)");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnType("rowversion")
            .IsRowVersion();

        // Relation de Clients

        _ = modelBuilder.Entity<ClientsDTO>()
            .HasOne(client => client.AsignedWarehouse)
            .WithMany(entrepot => entrepot.Clients)
            .HasForeignKey("AsignedWarehouseID");

        _ = modelBuilder.Entity<ClientsDTO>()
            .HasOne(client => client.ClientAdress)
            .WithOne(adresse => adresse.Client)
            .HasForeignKey("ClientAdressId");

        _ = modelBuilder.Entity<ClientsDTO>()
            .HasMany(client => client.Produit)
            .WithOne(produit => produit.ClientsDTO)
            .HasForeignKey("ClientsDTOId");
        _ = modelBuilder.Entity<ClientsDTO>()
            .HasMany(client => client.ShipmentOrders)
            .WithOne(shipmentorder => shipmentorder.Clients)
            .HasForeignKey("ClientsId");



        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .ToTable("ShipmentOrder")
            .HasKey(shipmentorder => shipmentorder.Id);

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

        // dATE CREATED ET DATE SHIPPED QUESTION

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.ClientsId)
            .HasColumnName("ClientsId")
            .HasColumnType("int");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationCivicAdress)
            .HasColumnName("DestinationCivicAdress")
            .HasColumnType("nvarchar(128)");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationContact)
            .HasColumnName("DestinationContact")
            .HasColumnType("nvarchar(128)");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationPostalCode)
            .HasColumnName("DestinationPostalCode")
            .HasColumnType("nvarchar(128)");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.EntrepotOriginal)
            .HasColumnName("EntrepotOriginal")
            .HasColumnType("nvarchar(128)");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnType("rowversion")
            .IsRowVersion();
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.ShipmentId)
            .HasColumnName("ShipmentId")
            .HasColumnType("int");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.EmployeEntrepotId)
            .HasColumnName("EmployeEntrepotId")
            .HasColumnType ("int");


        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmento => shipmento.Clients)
            .WithMany(clients => clients.ShipmentOrders)
            .HasForeignKey("ClientsId");


        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmentO => shipmentO.EntrepotOriginal)
            .WithMany(entrepot => entrepot.ShipmentOrder)
            .HasForeignKey("EntrepotOriginalId");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasMany(shipmentO => shipmentO.Produits)
            .WithMany(produit => produit.ShipmentOrderDTOs);

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmento => shipmento.EmployeEntrepot);

            //Pas sure pour EmployeEntrepot a reverifier a le prof 


        #endregion
    }

}
