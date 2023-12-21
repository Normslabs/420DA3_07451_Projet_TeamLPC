using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Produit : AbstractDTO<int> {
    public const int UPCCODE_MIN = 0;
    public const int NAME_MAX_LENGTH = 128;
    public const int INSTOCK_MIN_QTY = 0;
    public const int SUPPLIERCODE_MAX_LENGTH = 4;


    public string Name { get; set; }//
    public string? Description { get; set; }//
    public bool DoAutoRestock { get; set; }///////////
    public int InstockQuantity { get; set; }//
    public int TargetStockQuantity { get; set; }//
    public string? SupplierCode { get; set; }
    public long UpcCode { get; set; }//
    public decimal? WeightInKg { get; set; }//
    public int ClientsDTOId { get; set; }//
    public int FournisseurId { get; set; }//
    public byte[] RowVersion { get; set; } = null!;


    public ClientsDTO ClientsDTO { get; set; } = null!;//
    public Fournisseur Fournisseur { get; set; } = null!;//
    public List<PurchaseOrder> PurchaseOrders {get; set;} = new List<PurchaseOrder>();
    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();//


    #region Constructeur
    protected Produit(int id, long upcCode, string name, string description, string supplierCode, bool doAutoRestock, int inStockQuantity, int targetStockQuantity, decimal weightInKg, byte[] rowVersion, int fournisseurId) {
        this.Id = id;
        this.UpcCode = upcCode;
        this.Name = name;
        this.Description = description;
        this.SupplierCode = supplierCode;
        this.DoAutoRestock = doAutoRestock;
        this.InstockQuantity = inStockQuantity;
        this.TargetStockQuantity = targetStockQuantity;
        this.WeightInKg = weightInKg;
        this.RowVersion = rowVersion;
        this.FournisseurId = fournisseurId;
    }



    public Produit(long upcCode, string name, string description, string supplierCode, bool doAutoRestock, int inStockQuantity, int  targetStockQuantity, decimal weightInKg, int ownerClientId) {
        this.UpcCode = upcCode;
        this.Name = name;
        this.Description = description;
        this.SupplierCode = supplierCode;
        this.DoAutoRestock = doAutoRestock;
        this.InstockQuantity = inStockQuantity;
        this.TargetStockQuantity = targetStockQuantity;
        this.WeightInKg = weightInKg;
        this.ClientsDTOId = ownerClientId;

    }

    public Produit() {

    }
    #endregion


    #region Methode de validation

    public static bool ValiderUPCCode(int upcCode) {
        return upcCode >= UPCCODE_MIN;

    }

    public static bool ValiderName(string name) {
        return name.Length <= NAME_MAX_LENGTH;

    }

    public static bool ValiderInStock(int inStockQuantity) {
        return inStockQuantity >= INSTOCK_MIN_QTY;
    
    }

    public static bool ValiderSupplierCode(string suppliercode) {
        return suppliercode.Length <= SUPPLIERCODE_MAX_LENGTH;
    }

    #endregion
}
