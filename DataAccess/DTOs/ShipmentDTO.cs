using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.Identity.Client;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipmentDTO : AbstractDTO<int> {

    public byte[] RowVersion { get; set; } = null!;

    public ShipmentServiceEnum Service {  get; set; } 

    public ShipmentOrderDTO ShippingOrder { get; set; } = null!;

    public int? ShippingOrderID { get; set; } = null!;

    public string? TrackingNumber { get; set; } = null!;


    public ShipmentDTO() : base() { 

    }

    public ShipmentDTO(int ShippingId, ShipmentServiceEnum Service, string TrackNumber) {
        this.ShippingOrderID = ShippingId;
        this.Service = Service;
        this.TrackingNumber = TrackNumber;

    }

    public ShipmentDTO(int Id, ShipmentServiceEnum Service, int ShippingId, string TrackNumber, byte[] RowVersion ) 
    {
        this.Id = Id;
        this.ShippingOrderID = ShippingId;
        this.TrackingNumber = TrackNumber;
        this.RowVersion = RowVersion;
        this.Service = Service;
    }



    public enum ShipmentServiceEnum {
        PUROLATOR, CANADAPOST, FEDEX
    }





}
