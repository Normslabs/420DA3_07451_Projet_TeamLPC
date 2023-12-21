using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
/// <summary>
/// Classe de produit, ce qui represente un produit.
/// </summary>

public class Produit : AbstractDTO<int> {
    public const int UPCCODE_MIN = 0;
    public const int UPCCODE_MAX = 1000000000;
    public const int NAME_MAX_LENGTH = 128;
    public const int INSTOCK_MIN_QTY = 0;
    public const int SUPPLIERCODE_MAX_LENGTH = 4;

    /// <summary>
    /// Declaration des propriete de la classe Produit
    /// </summary>
    public string Name { get; set; } = null!;
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

    /// <summary>
    /// Declaration des proprietes de navigation
    /// </summary>
    public virtual ClientsDTO ClientsDTO { get; set; } = null!;
    public virtual Fournisseur Fournisseur { get; set; } = null!;
    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
    public virtual List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();


    //Constructeur de la classe Produit
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

    //Constructeur de la classe Produit
    public Produit(long upcCode, string name, string description, string supplierCode, bool doAutoRestock, int inStockQuantity, int targetStockQuantity, decimal weightInKg, int ownerClientId) {
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
    //Constructeur vide de Produit pour recevoir n'importe quel parametre
    public Produit() {

    }
    #endregion


    #region Methode de validation
    //Validation du UPC Code fournis par l'utilisateur
    public static bool ValiderUPCCode(int upcCode) {
        return upcCode >= UPCCODE_MIN && upcCode <= UPCCODE_MAX;

    }
    //Validation de la propriete Name fournis par l'utilisateur
    public static bool ValiderName(string name) {
        return name.Length <= NAME_MAX_LENGTH;

    }
    //Validation de la quantite in stock fournis par l'utilisateur
    public static bool ValiderInStock(int inStockQuantity) {
        return inStockQuantity >= INSTOCK_MIN_QTY;

    }
    //Validation du supplier Code fournis par l'utilisateur
    public static bool ValiderSupplierCode(string suppliercode) {
        return suppliercode.Length <= SUPPLIERCODE_MAX_LENGTH;
    }

    #endregion

    public override string ToString() {
        return this.Id.ToString() + " - " + this.Name;
    }
}
