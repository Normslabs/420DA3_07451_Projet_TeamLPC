﻿ using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentDTO;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Fournisseur : AbstractDTO<int> {


    public int AdresseId { get; set; } 

    public List<Produit> Produit { get; set; } = null!;

    public byte[] RowVersion { get; set; } = null!;

    public Adresse SupplierAdresse { get; set; } = null!;

    public string PrenomContact { get; set; }

    public string NomContact { get; set; }
    public string AdresseContact { get; set; }
    public string EmailContact { get; set; }




public string SupplierName { get; set; } = null!;


    public const int SUPPLIER_NAME_MAXLENGHT = 100;




    #region Constructeur
    public Fournisseur() : base() {
        
    }

    public Fournisseur(int AdresseId, string PrenomContact, string NomContact, string AdresseContact, string EmailContact, string SupplierName) {
        this.AdresseId = AdresseId;
        this.PrenomContact = PrenomContact;
        this.NomContact = NomContact;
        this.AdresseContact = AdresseContact;
        this.EmailContact = EmailContact;
        this.SupplierName = SupplierName;
        
    }

    protected Fournisseur(int Id, int AdresseId, string PrenomContact, string NomContact, string AdresseContact, string EmailContact, byte[] RowVersion, string SupplierName) {
        this.Id = Id;
        this.AdresseId = AdresseId;
        this.PrenomContact = PrenomContact;
        this.NomContact = NomContact;
        this.AdresseContact = AdresseContact;
        this.EmailContact = EmailContact;
        this.RowVersion = RowVersion;
        this.SupplierName = SupplierName;
    }

    #endregion



    #region Validation

    public static bool ValiderSupplierName (string SupplierName) {
        return SupplierName.Length <= SUPPLIER_NAME_MAXLENGHT;
    }


    #endregion



}
