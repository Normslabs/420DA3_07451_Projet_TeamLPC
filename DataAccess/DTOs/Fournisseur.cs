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


    public int AdresseId { get; set; } 

    public int ContactId { get; set; } 

    public List<Produit> Produit { get; set; } = null!;

    public byte[] RowVersion { get; set; } = null!;

    public Adresse SupplierAdresse { get; set; } = null!;


    public string SupplierName { get; set; } = null!;


    public const int SUPPLIER_NAME_MAXLENGHT = 100;




    #region Constructeur
    public Fournisseur() : base() {
        
    }

    public Fournisseur(int AdresseId, int ContactId, string SupplierName) {
        this.AdresseId = AdresseId;
        this.ContactId = ContactId;
        this.SupplierName = SupplierName;
        
    }

    protected Fournisseur(int Id, int AdresseId, int ContactId, byte[] RowVersion, string SupplierName) {
        this.Id = Id;
        this.AdresseId = AdresseId;
        this.ContactId = ContactId;
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
