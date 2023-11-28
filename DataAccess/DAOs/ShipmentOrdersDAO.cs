using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ShipmentOrdersDAO : AbstractDao<ShipmentOrderDTO, int> {

    protected override AbstractContext Context { get; }

    public ShipmentOrdersDAO(AbstractContext context) { 
    
     this.Context = context;
    }

    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status == ShippingOrderStatusEnum.NEW && order.EntrepotOriginalId == entrepotId)
            .ToList();
    }
    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int userId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status != ShippingOrderStatusEnum.COMPLETED && order.EmployeEntrepotId == userId)
            .ToList();
    }
    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int id) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(client => client.ClientsId == id)
            .Include(client => client.Shipment)
            .ToList();

    }
}
