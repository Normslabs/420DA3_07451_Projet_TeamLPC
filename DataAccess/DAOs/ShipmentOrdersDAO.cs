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

public class ShipmentOrdersDAO : AbstractDao<ShipmentOrderDTO , int> {


    protected override AbstractContext Context { get; }

    public ShipmentOrdersDAO(AbstractContext context) { 
    
     this.Context = context; 
    }

    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status == ShippingOrderStatusEnum.NEW && order.EntrepotOriginalId == entrepotId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.ShipmentOrderDTO)
            .Include(so => so.Shipment)
            .ToList();
    }

    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int userId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status != ShippingOrderStatusEnum.COMPLETED && order.EmployeEntrepotId == userId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.ShipmentOrderDTO)
            .Include(so => so.Shipment)
            .ToList();
    }
    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int id) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(client => client.ClientsId == id)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.ShipmentOrderDTO)
            .Include(so => so.Shipment)
            .ToList();

    }

    public override List<ShipmentOrderDTO> GetAll() {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot) 
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.ShipmentOrderDTO)
            .Include(so => so.Shipment)
            .ToList();
    }

    public override ShipmentOrderDTO? GetById(int identifier) {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.ShipmentOrderDTO)
            .Include(so => so.Shipment)
            .Where(so => so.Id == identifier)
            .SingleOrDefault();
    }
}
