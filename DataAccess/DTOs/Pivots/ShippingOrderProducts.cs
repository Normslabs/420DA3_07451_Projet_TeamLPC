namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
public class ShippingOrderProducts {
    public int ProduitId { get; set; }
    public int ShipmentOrderDTOId { get; set; }
    public int Quantite { get; set; }


    public virtual Produit Produit { get; set; } = null!;

    public virtual ShipmentOrderDTO ShipmentOrderDTO { get; set; } = null!;

    public ShippingOrderProducts() {

    }

    public ShippingOrderProducts(int produitId, int shipmentOrderDTOId, int quantite) {
        this.ProduitId = produitId;
        this.ShipmentOrderDTOId = shipmentOrderDTOId;
        this.Quantite = quantite;
    }
}
