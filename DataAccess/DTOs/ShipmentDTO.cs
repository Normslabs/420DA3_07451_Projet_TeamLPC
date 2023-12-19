using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    [NotMapped]
    private static Random random = new Random();


    private static string RandomString(int length) {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public ShipmentDTO() : base() { 
        this.TrackingNumber = RandomString(15);
    }

    public ShipmentDTO(int ShippingId, ShipmentServiceEnum Service) {
        this.ShippingOrderID = ShippingId;
        this.Service = Service;
        this.TrackingNumber = RandomString(15);

        

    }

    protected ShipmentDTO(int Id, ShipmentServiceEnum Service, int ShippingId, string TrackNumber, byte[] RowVersion ) 
    {
        this.Id = Id;
        this.ShippingOrderID = ShippingId;
        this.TrackingNumber = TrackNumber;
        this.RowVersion = RowVersion;
        this.Service = Service;
    }



    public enum ShipmentServiceEnum 
    {
        PUROLATOR, CANADAPOST, FEDEX
    }





}
