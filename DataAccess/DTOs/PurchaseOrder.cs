using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
/// <summary>
/// Classe de PurchaseOrder, ce qui represente un purchase order.
/// </summary>
public class PurchaseOrder : AbstractDTO<int> {
    public const int QTY_ORDER_MIN = 0;

    /// <summary>
    /// Declaration des propriete de la classe Purchase Order
    /// </summary>
    public PurchaseOrderStatusEnum? Status { get; set; }
    public int QuantityOrdered { get; set; }
    public int ProductId { get; set; }
    public int DestinationWarehouseID { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateCompleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    /// <summary>
    /// Declaration des propriete de navigation
    /// </summary>

    public virtual Entrepot DestinationWarehouse { get; set; } = null!;//

    public virtual Produit Product { get; set; } = null!;//

    //Constructeur vide
    public PurchaseOrder() {

    }

    //Constructeur de la classe Purchase Order (EF Core)
    protected PurchaseOrder(int Id, PurchaseOrderStatusEnum Status, int destinationWarehouseId, int quantityOrdered, DateTime dateCreated, DateTime? dateCompleted, byte[] rowVersion) {
        this.Id = Id;
        this.Status = Status;
        this.DestinationWarehouseID = destinationWarehouseId;
        this.QuantityOrdered = quantityOrdered;
        this.DateCreated = dateCreated;
        this.DateCompleted = dateCompleted;
        this.RowVersion = rowVersion;
    }

    //
    public PurchaseOrder(int ProductId, int destinationWarehouseId, int quantityOrdered) {
        this.ProductId = ProductId;
        this.DestinationWarehouseID = destinationWarehouseId;
        this.QuantityOrdered = quantityOrdered;

    }

    //Validation de la QTY d'item que l'utilisateur va commander, elle ne peut pas etre en dessous de 0
    public static bool ValiderQTYOrder(int QTYOrdered) {
        return QTYOrdered >= QTY_ORDER_MIN;
    }

    //Transformer le format de purchase order a String 
    public override string ToString() {
        return
            "ID: " + this.Id.ToString() + "  " +
            "Product ID: " + this.ProductId.ToString() + " - " +
            "Warehouse ID: " + this.DestinationWarehouseID.ToString() + " - " +
            "Quantité commandé: " + this.QuantityOrdered.ToString() + " - " +
            "Date de la commande: " + this.DateCreated.ToString();
    }

}