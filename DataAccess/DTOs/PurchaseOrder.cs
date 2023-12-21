﻿using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class PurchaseOrder : AbstractDTO<int> {
    public const int QTY_ORDER_MIN = 0;


    public PurchaseOrderStatusEnum? Status { get; set; }//
    public int QuantityOrdered { get; set; }//
    public int ProductId { get; set; }//
    public int DestinationWarehouseID { get; set; }//
    public DateTime DateCreated { get; set; }//
    public DateTime? DateCompleted { get; set; }//
    public byte[] RowVersion { get; set; } = null!;


    public virtual Entrepot DestinationWarehouse { get; set; } = null!;//
    public virtual Produit Product { get; set; } = null!;//

    protected PurchaseOrder(int Id, PurchaseOrderStatusEnum Status, int destinationWarehouseId, int quantityOrdered, DateTime dateCreated, DateTime? dateCompleted, byte[] rowVersion) {
        this.Id = Id;
        this.Status = Status;
        this.DestinationWarehouseID = destinationWarehouseId;
        this.QuantityOrdered = quantityOrdered;
        this.DateCreated = dateCreated;
        this.DateCompleted = dateCompleted;
        this.RowVersion = rowVersion;
    }

    public PurchaseOrder(int ProductId, int destinationWarehouseId, int quantityOrdered) { 
        this.ProductId = ProductId;
        this.DestinationWarehouseID = destinationWarehouseId;
        this.QuantityOrdered = quantityOrdered;
    
    }

    public override string ToString() {
        return
            "ID: " + this.Id.ToString() + "  " +
            "Product ID: " + this.ProductId.ToString() + " - " +
            "Warehouse ID: " + this.DestinationWarehouseID.ToString() + " - " +
            "Quantité commandé: " + this.QuantityOrdered.ToString() + " - " +
            "Date de la commande: " + this.DateCreated.ToString();
    }

    public PurchaseOrder() {

    }

    public static bool ValiderQTYOrder(int QTYOrdered) {
        return QTYOrdered >= QTY_ORDER_MIN;
    }
}