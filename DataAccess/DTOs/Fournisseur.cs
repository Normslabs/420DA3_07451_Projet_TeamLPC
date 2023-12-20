 using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentDTO;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Fournisseur : AbstractDTO<int> {



    public const int PRENOMCONTACT_MAX_LENGHT = 20;
    public const int NOMCONTACT_MAX_LENGHT = 20;
    public const int SUPPLIER_NAME_MAXLENGHT = 100;
    public const int ADRESSECONTACT_MAX_LENGHT = 80;
    public const int EMAILCONTACT_MAX_LENGHT = 128;


    public int AdresseId { get; set; } 

    public byte[] RowVersion { get; set; } = null!;

    public string PrenomContact { get; set; }

    public string NomContact { get; set; }
    public string AdresseContact { get; set; }
    public string EmailContact { get; set; }

    public string SupplierName { get; set; } = null!;



    public Adresse SupplierAdresse { get; set; } = null!;
    // Manquait propriété de navigation - Prof
    public List<Produit> ProduitsFournis { get; set; } = new List<Produit>();




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
