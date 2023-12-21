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

    /// <summary>
    /// Contexte de la base de donne 
    /// </summary>
    protected override AbstractContext Context { get; }
    /// <summary>
    /// Initialisation du contexte dans la classe ShipmentOrdersDAO
    /// </summary>
    /// <param name="context"></param>
    public ShipmentOrdersDAO(AbstractContext context) {

        this.Context = context;
    }
    /// <summary>
    /// Obtient la liste des nouvelle commande pour un entrepot specifique 
    /// </summary>
    /// <param name="entrepotId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status == ShippingOrderStatusEnum.NEW && order.EntrepotOriginalId == entrepotId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
            .Include(so => so.Shipment)
            .ToList();
    }
    /// <summary>
    /// Obtien la liste des commande incomplete assigner a un employe de bureau attitre
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int userId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status != ShippingOrderStatusEnum.COMPLETED && order.EmployeEntrepotId == userId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
            .Include(so => so.Shipment)
            .ToList();
    }

    /// <summary>
    /// Obtien la liste des commande selon le client specifique 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int id) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(client => client.ClientsId == id)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
            .Include(so => so.Shipment)
            .ToList();

    }
    /// <summary>
    /// Obtien toute les commande avec d'autre details
    /// </summary>
    /// <returns></returns>
    public override List<ShipmentOrderDTO> GetAll() {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
            .Include(so => so.Shipment)
            .ToList();
    }
    /// <summary>
    /// Obtien la commande selon l'id donne
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public override ShipmentOrderDTO? GetById(int identifier) {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
            .Include(so => so.Shipment)
            .Where(so => so.Id == identifier)
            .SingleOrDefault();
    }

    public List<ShipmentOrderDTO> SearchShipmentOrderProduct(string filter) {
       
    }
}
