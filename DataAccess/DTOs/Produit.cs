using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Produit : AbstractDTO<int> {
    public string? Description { get; set; }
    public bool DoAutoRestock { get; set; }
    public int InstockQuantity { get; set; }
    public string? Name { get; set; }
    public ClientsDTO? ClientsDTO { get; set; }
    public int ClientsDTOId { get; set; }
    public List<PurchaseOrder>? PurchaseOrders { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public List<ShipmentOrderDTO>? ShipmentOrderDTOs { get; set; }
    public Fournisseur? Fournisseur { get; set; }
    public string? SupplierCode { get; set; }
    public int SupplierID { get; set; }
    public int TargetStockQuantity { get; set; }
    public long UpcCode { get; set; }
    public decimal? WeightInKg { get; set; }

    public Produit(int id, long upcCode, string name, string description, string supplierCode, bool doAutoRestock, int inStockQuantity, int targetStockQuantity, decimal weightInKg, int supplierId) {
        this.Id = id;
        this.UpcCode = upcCode;
        this.Name = name;
        this.Description = description;
        this.SupplierCode = supplierCode;
        this.DoAutoRestock = doAutoRestock;
        this.InstockQuantity = inStockQuantity;
        this.TargetStockQuantity = targetStockQuantity;
        this.WeightInKg = weightInKg;
        this.SupplierID = supplierId;

    }

    public Produit(long upcCode, string name, string description, string supplierCode, bool doAutoRestock, int inStockQuantity, int  targetStockQuantity, decimal weightInKg, int ownerClientId, int supplierId) {
        this.UpcCode = upcCode;
        this.Name = name;
        this.Description = description;
        this.SupplierCode = supplierCode;
        this.DoAutoRestock = doAutoRestock;
        this.InstockQuantity = inStockQuantity;
        this.TargetStockQuantity = targetStockQuantity;
        this.WeightInKg = weightInKg;
        this.ClientsDTOId = ownerClientId;
        this.SupplierID = supplierId;

    }
}
