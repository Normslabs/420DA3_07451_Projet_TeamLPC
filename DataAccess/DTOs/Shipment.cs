using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.Identity.Client;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Shipment : AbstractDTO<int> {

    public byte RowVersion { get; set; } 

    public object Service {  get; set; } : ShipmentServiceEnum;

    public object  ShippingOrder { get; set; } : ShippingOrder;

    public int ShippingOrderID { get; set; } 

    public string TrackingNumber { get; set; } 

}
