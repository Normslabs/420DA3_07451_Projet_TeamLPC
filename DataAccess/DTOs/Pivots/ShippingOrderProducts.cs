using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
public class ShippingOrderProducts {
    public int ProduitId;
    public int ShipmentOrderDTOId;
    public int Quantite;


    public Produit Produit;

    public ShipmentOrderDTO ShipmentOrderDTO;

    public ShippingOrderProducts() {

    }

    public ShippingOrderProducts(int produitId, int shipmentOrderDTOId, int quantite) {
        this.ProduitId = produitId;
        this.ShipmentOrderDTOId = shipmentOrderDTOId;
        this.Quantite = quantite;
    }   
}
