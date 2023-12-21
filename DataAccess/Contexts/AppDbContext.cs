﻿using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts;
internal class AppDbContext : AbstractContext {

    // Entités
    public DbSet<Utilisateur> Utilisateurs { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Adresse> Adresses { get; set; }
    public DbSet<ClientsDTO> Clients { get; set; }
    public DbSet<Entrepot> Entrepots { get; set; }
    public DbSet<Fournisseur> Fournisseurs { get; set; }
    public DbSet<Produit> Produits { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<ShipmentDTO> Shipments { get; set; }
    public DbSet<ShipmentOrderDTO> ShipmentOrders { get; set; }

    // Pivots
    public DbSet<ShippingOrderProducts> ShippingOrderProducts { get; set; }


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
            .Property(entrepot => entrepot.AdresseId)
            .HasColumnName("AdresseId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Entrepot>()
           .Property(entrepot => entrepot.NomEntrepot)
           .HasColumnName("NomEntrepot")
           .HasColumnType($"nvarchar({Entrepot.MAX_NOMENTREPOT_LENGTH})");

        _ = modelBuilder.Entity<Entrepot>()
            .Property(entrepot => entrepot.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();



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
            .HasColumnType($"nvarchar({ClientsDTO.COMPANYNAME_MAX_LENGTH})");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Nom)
            .HasColumnName("Nom")
            .HasColumnType($"nvarchar({ClientsDTO.NAME_MAX_LENGTH})");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Prenom)
            .HasColumnName("Prenom")
            .HasColumnType($"nvarchar({ClientsDTO.PRENOM_MAX_LENGTH})");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Courriel)
            .HasColumnName("Courriel")
            .HasColumnType($"nvarchar({ClientsDTO.COURRIEL_MAX_LENGTH})");

        _ = modelBuilder.Entity<ClientsDTO>()
            .Property(client => client.Telephone)
            .HasColumnName("Telephone")
            .HasColumnType("bigint");


        // Relation de Clients


        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .ToTable("ShipmentOrder")
            .HasKey(shipmentorder => shipmentorder.Id);

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.ClientsId)
            .HasColumnName("ClientsId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationCivicAdress)
            .HasColumnName("DestinationCivicAdress")
            .HasColumnType($"nvarchar({ShipmentOrderDTO.ADRESSCIVIQUE_MAX_LENGHT})");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationContact)
            .HasColumnName("DestinationContact")
            .HasColumnType($"nvarchar({ShipmentOrderDTO.CONCTACT_MAX_LENGHT})");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DestinationPostalCode)
            .HasColumnName("DestinationPostalCode")
            .HasColumnType($"nvarchar({ShipmentOrderDTO.CODEPOSTAL_MAX_LENGHT})");

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
            .Property(shipmento => shipmento.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2(7)")
            .HasComputedColumnSql("getdate()");

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DateShipped)
            .HasColumnName("DateShipped")
            .HasColumnType("datetime2(7)");

        #endregion


        #region Produit et PurchaseOrder

        //Creation Produit

        _ = modelBuilder.Entity<Produit>()
            .ToTable("Produits")
            .HasKey(Produit => Produit.Id);

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.Name)
            .HasColumnName("Name")
            .HasColumnType($"nvarchar({Produit.NAME_MAX_LENGTH})");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.Description)
            .HasColumnName("Description")
            .HasColumnType("nvarchar(128)")
            .IsRequired(false);

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.DoAutoRestock)
            .HasColumnName("DoAutoRestock")
            .HasColumnType("bit");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.InstockQuantity)
            .HasColumnName("InstockQuantity")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.TargetStockQuantity)
            .HasColumnName("TargetStockQuantity")
            .HasColumnType("int");
        
        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.SupplierCode)
            .HasColumnName("SupplierCode")
            .HasColumnType($"nvarchar({Produit.SUPPLIERCODE_MAX_LENGTH})")
            .IsRequired(false);

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.UpcCode)
            .HasColumnName("UpcCode")
            .HasColumnType("bigint");

        _ = modelBuilder.Entity<Produit>()
           .Property(produit => produit.WeightInKg)
           .HasColumnName("WeightInKg")
           .HasColumnType("decimal(9,2)")
           .IsRequired(false);

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.ClientsDTOId)
            .HasColumnName("ClientsDTOId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.FournisseurId)
            .HasColumnName("DournisseurId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<Produit>()
            .Property(prod => prod.RowVersion)
            .HasColumnName("Version")
            .IsRowVersion();


        //Creation Purchase Order 

        _ = modelBuilder.Entity<PurchaseOrder>()
            .ToTable("PurchaseOrders")
            .HasKey(po => po.Id);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Id)
            .HasColumnName("Id")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Status)
            .HasColumnName("Status")
            .HasColumnType("nvarchar(16)");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.QuantityOrdered)
            .HasColumnName("QuantityOrdered")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.ProductId)
            .HasColumnName("ProductId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DestinationWarehouseID)
            .HasColumnName("DestinationWarehouseID")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2(7)")
            .HasComputedColumnSql("getdate()");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCompleted)
            .HasColumnName("DateCompleted")
            .HasColumnType("datetime2(7)")
            .IsRequired(false);


        #endregion


        #region Fournisseur et Shipment


        //Model builder permettant de créer la table pour Fournisseur et de creer les colonnes dans la base de donnée à l'aide d'une migration

        _ = modelBuilder.Entity<Fournisseur>()
            .ToTable("Fournisseurs")
            .HasKey(fournisseur => fournisseur.Id);

        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.Id)
            .HasColumnName("Id")
            .HasColumnType("int");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.SupplierName)
            .HasColumnName("NomFournisseur")
            .HasColumnType($"nvarchar({Fournisseur.SUPPLIER_NAME_MAXLENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.AdresseId)
            .HasColumnName ("AdresseId")
            .HasColumnType ("int");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.PrenomContact)
            .HasColumnName("PrenomContact")
            .HasColumnType($"nvarchar({Fournisseur.PRENOMCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.NomContact)
            .HasColumnName("NomContact")
            .HasColumnType ($"nvarchar({Fournisseur.NOMCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.AdresseContact)
            .HasColumnName("AdresseContact")
            .HasColumnType ($"nvarchar({Fournisseur.ADRESSECONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.EmailContact)
            .HasColumnName("EmailContact")
            .HasColumnType ($"nvarchar({Fournisseur.EMAILCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();



        //Model builder permettant de créer la table pour Fournisseur et de creer les colonnes dans la base de donnée à l'aide d'une migration


        _ = modelBuilder.Entity<ShipmentDTO>()
            .ToTable("Shipments")
            .HasKey(shipment => shipment.Id);

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property (shipment => shipment.Id)
            .HasColumnName ("Id")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property(shipment => shipment.Service)
            .HasColumnName("Service")
            .HasColumnType("nvarchar(30)");

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property(shipment => shipment.TrackingNumber)
            .HasColumnName("Tracking number")
            .HasColumnType("nvarchar(15)");

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property (shipment => shipment.ShippingOrderID)
            .HasColumnName("ShippingOrderId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property(shipment => shipment.RowVersion)
            .HasColumnName("Version")
            .IsRowVersion();


        #endregion


        #region Pivots

        _ = modelBuilder.Entity<ShippingOrderProducts>()
            .ToTable("ShippingOrderProducts")
            .HasKey(sop => new { sop.ProduitId, sop.ShipmentOrderDTOId });

        _ = modelBuilder.Entity<ShippingOrderProducts>()
            .Property(sop => sop.ProduitId)
            .HasColumnName("ProduitId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShippingOrderProducts>()
            .Property(sop => sop.ShipmentOrderDTOId)
            .HasColumnName("ShipmentOrderDTOId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<ShippingOrderProducts>()
            .Property(sop => sop.Quantite)
            .HasColumnName("Quantite")
            .HasColumnType("int");


        #endregion


        #region Relations

        // N-à-N entre Utilisateur et Role
        _ = modelBuilder.Entity<Utilisateur>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.UtilisateursPossedantRole);

        // 1-à-1 entre Entrepot et Adresse 
        _ = modelBuilder.Entity<Entrepot>()
           .HasOne(entrepot => entrepot.AdresseEntrepot)
           .WithOne(adresse => adresse.AdresseEntrepot)
           .HasForeignKey<Entrepot>(wh=>wh.AdresseId);

        // 1-à-N entre Client et Entrepot
        _ = modelBuilder.Entity<ClientsDTO>()
            .HasOne(client => client.AsignedWarehouse)
            .WithMany(entrepot => entrepot.Clients)
            .HasForeignKey(client => client.AsignedWarehouseID);

        // 1-à-1 entre Client et Entrepot
        _ = modelBuilder.Entity<ClientsDTO>()
            .HasOne(client => client.ClientAdress)
            .WithOne(adresse => adresse.Client)
            .HasForeignKey<ClientsDTO>(client => client.ClientAdressId);

        // N-à-1 entre produit et client
        _ = modelBuilder.Entity<ClientsDTO>()
            .HasMany(client => client.Produit)
            .WithOne(produit => produit.ClientsDTO)
            .HasForeignKey(produit => produit.ClientsDTOId);

        // N-à-1 entre ShipmentOrders et clients
        _ = modelBuilder.Entity<ClientsDTO>()
            .HasMany(client => client.ShipmentOrders)
            .WithOne(shipmentorder => shipmentorder.Clients)
            .HasForeignKey(so => so.ClientsId);

        // N-à-1 entre ShipmentOrders et entrepot
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmentO => shipmentO.EntrepotOriginal)
            .WithMany(entrepot => entrepot.ShipmentOrder)
            .HasForeignKey(so => so.EntrepotOriginalId);

        // 1-à-N entre ShipmentOrder et ShippingOrderProducts (pivot)
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasMany(shipmentO => shipmentO.AssociationsProduits)
            .WithOne(sop => sop.ShipmentOrderDTO)
            .HasForeignKey(sop => sop.ShipmentOrderDTOId);

        // 1-à-N entre Produit et ShippingOrderProducts (pivot)
        _ = modelBuilder.Entity<Produit>()
            .HasMany(produit => produit.ShippingOrderProducts)
            .WithOne(sop => sop.Produit)
            .HasForeignKey(sop => sop.ProduitId);

        // 1-à-N entre Utilisateur (employe d'entrepôt) et ShipmentOrders
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmento => shipmento.EmployeEntrepot)
            .WithMany(utilisateur => utilisateur.AssignedShipmentOrders)
            .HasForeignKey(so => so.EmployeEntrepotId);

        // 1-à-N entre Fournisseur et Produits
        _ = modelBuilder.Entity<Produit>()
            .HasOne(produit => produit.Fournisseur)
            .WithMany(fournisseur => fournisseur.ProduitsFournis)
            .HasForeignKey(produit => produit.FournisseurId);

        // 1-à-N entre Entrepot et PurchaseOrders
        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(po => po.DestinationWarehouse)
            .WithMany(wh => wh.PurchaseOrders)
            .HasForeignKey(po => po.DestinationWarehouseID);

        // 1-à-N entre Produit et PurchaseOrders
        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(po => po.Product)
            .WithMany(product => product.PurchaseOrders)
            .HasForeignKey(po => po.ProductId);

        // 1-à-1 entre Adresse et Fournisseur
        _ = modelBuilder.Entity<Fournisseur>()
            .HasOne(fournisseur => fournisseur.SupplierAdresse)
            .WithOne(adresse => adresse.AdresseFournisseur)
            .HasForeignKey<Fournisseur>(fourn => fourn.AdresseId);

        // 1-à-1 entre Shipment et ShippingOrder
        _ = modelBuilder.Entity<ShipmentDTO>()
            .HasOne(shipment => shipment.ShippingOrder)
            .WithOne(shipOrd => shipOrd.Shipment)
            .HasForeignKey<ShipmentDTO>(shipment => shipment.ShippingOrderID);


        #endregion

    }

}
