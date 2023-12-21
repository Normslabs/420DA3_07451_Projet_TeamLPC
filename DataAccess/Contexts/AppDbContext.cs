﻿using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
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


        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2")
            .HasComputedColumnSql("getdate()");
        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .Property(shipmento => shipmento.DateShipped)
            .HasColumnName("DateShipped")
            .HasColumnType("datetime2");

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
            .HasMany(shipmentO => shipmentO.AssociationsProduits)
            .WithOne(sop => sop.ShipmentOrderDTO)
            .HasForeignKey(sop => sop.ShipmentOrderDTOId);

        _ = modelBuilder.Entity<ShipmentOrderDTO>()
            .HasOne(shipmento => shipmento.EmployeEntrepot);

        //Pas sure pour EmployeEntrepot a reverifier a le prof 



        //Creation Produit

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.Description)
            .IsRequired(false)
            .HasColumnName("Description")
            .HasColumnType("nvarchar(128)");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.DoAutoRestock)
            .HasColumnName("Description")
            .HasColumnType("bit");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.InstockQuantity)
            .HasColumnName("InStockQTY")
            .HasColumnType($"nvarchar({Produit.INSTOCK_MIN_QTY})");

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.Name)
            .HasColumnName("Name")
            .HasColumnType($"nvarchar({Produit.NAME_MAX_LENGTH})");


        _ = modelBuilder.Entity<Produit>()
           .Property(produit => produit.ClientsDTOId)
           .HasColumnName("ClientsDTOId")
           .HasColumnType("int");
        

        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.SupplierCode)
            .IsRequired(false)
            .HasColumnName("InStockQTY")
            .HasColumnType($"nvarchar({Produit.SUPPLIERCODE_MAX_LENGTH})");


        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.TargetStockQuantity)
            .HasColumnName("TargetStockQuantity")
            .HasColumnType("int");


        _ = modelBuilder.Entity<Produit>()
            .Property(produit => produit.UpcCode)
            .HasColumnName("UPCCode")
            .HasColumnType($"nvarchar({Produit.UPCCODE_MAX_LENGTH})");


        _ = modelBuilder.Entity<Produit>()
           .Property(produit => produit.WeightInKg)
           .HasColumnName("WeightInKg")
           .HasColumnType("int");

        _ = modelBuilder.Entity<Produit>()
            .HasMany(produit => produit.ShippingOrderProducts)
            .WithOne(sop => sop.Produit)
            .HasForeignKey(sop => sop.ProduitId);

        _ = modelBuilder.Entity<Produit>()
            .HasOne(produit => produit.Fournisseur)
            .WithMany(fournisseur => fournisseur.ProduitsFournis)
            .HasForeignKey(produit => produit.FournisseurId);

        //Creation Purchase Order 

        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(po => po.DestinationWarehouse)
            .WithMany(wh => wh.PurchaseOrders)
            .HasForeignKey(po => po.DestinationWarehouseID);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(po => po.Product)
            .WithMany(product => product.PurchaseOrders)
            .HasForeignKey(po => po.ProductId);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.ProductId)
            .HasColumnName("ProductId")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.QuantityOrdered)
            .HasColumnName("QuantityOrdered")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DestinationWarehouseID)
            .HasColumnName("DestinationWarehouseID")
            .HasColumnType("int");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCompleted)
            .IsRequired(false)
            .HasColumnName("DateCompleted")
            .HasColumnType("datetime2");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnType("datetime2")
            .HasComputedColumnSql("getdate()");

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Status)
            .HasColumnName("Status")
            .HasColumnType("nvarchar(16)");


        #endregion

        #region Fournisseur et Shipment


        // fournisseur 

        _ = modelBuilder.Entity<Fournisseur>()
            .ToTable("Fournisseur")
            .HasKey(fournisseur => fournisseur.Id);

        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.Id)
            .HasColumnName("Id")
            .HasColumnType("int");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.SupplierName)
            .HasColumnName("Nom du fournisseur")
            .HasColumnType($"nvarchar({Fournisseur.SUPPLIER_NAME_MAXLENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.AdresseId)
            .HasColumnName ("AdresseId")
            .HasColumnType ("int");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.PrenomContact)
            .HasColumnName("Prenom du Contact")
            .HasColumnType($"nvarchar({Fournisseur.PRENOMCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.NomContact)
            .HasColumnName("Nom du contact")
            .HasColumnType ($"nvarchar({Fournisseur.NOMCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.AdresseContact)
            .HasColumnName("Adresse du contact")
            .HasColumnType ($"nvarchar({Fournisseur.ADRESSECONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.EmailContact)
            .HasColumnName("Email du contact")
            .HasColumnType ($"nvarchar({Fournisseur.EMAILCONTACT_MAX_LENGHT}");


        _ = modelBuilder.Entity<Fournisseur>()
            .Property(fournisseur => fournisseur.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();


        _ = modelBuilder.Entity<Fournisseur>()
            .HasOne(fournisseur => fournisseur.SupplierAdresse)
            .WithOne(adresse => adresse.AdresseFournisseur)
            .HasForeignKey<Fournisseur>(fourn => fourn.AdresseId);


        // shipment 


        _ = modelBuilder.Entity<ShipmentDTO>()
            .ToTable("Shipment")
            .HasKey(shipment => shipment.Id);

        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property (shipment => shipment.Id)
            .HasColumnName ("Id")
            .HasColumnType("int");


        _ = modelBuilder.Entity<ShipmentDTO>()
            .Property (shipment => shipment.ShippingOrderID)
            .HasColumnName("ShippingOrderId")
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
            .HasOne(shipment => shipment.ShippingOrder)
            .WithOne(shipOrd => shipOrd.Shipment)
            .HasForeignKey<ShipmentDTO>(shipment => shipment.ShippingOrderID);

        #endregion
    }


}
