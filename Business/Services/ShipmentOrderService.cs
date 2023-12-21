using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;

namespace _420DA3_07451_Projet_Initial.Business.Services;
internal class ShipmentOrderService : AbstractDtoService<ShipmentOrderDTO, int>{
    /// <summary>
    /// Obtien l'acces au donne pour la classe ShipmentOrderDAO
    /// </summary>
    protected override ShipmentOrdersDAO Dao { get; }
    /// <summary>
    /// Obtien le forme ShipmentOrderWindows
    /// </summary>
    protected override ShipmentOrderWindows DtoManagementWindow {  get; }

    /// <summary>
    /// Initialisation de l'instance de la clasee ShipmentOrder
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public ShipmentOrderService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(facade);
        this.DtoManagementWindow = new ShipmentOrderWindows(facade);
        this.Dao = new ShipmentOrdersDAO(context);
    }
    /// <summary>
    /// Donne la liste de commande d'un client selon son Id
    /// </summary>
    /// <param name="clientid"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int clientid) {
        return this.GetClientShipmentOrderById(clientid);
    }
    /// <summary>
    /// Permet de recevoir la liste de toute les commandes
    /// </summary>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetAllShipmentOrders() {
        return this.Dao.GetAll();
    }
    /// <summary>
    /// Obtient la liste des commandes d'expedition incomplete assignee a une commande spécifie
    /// </summary>
    /// <param name="orderId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int orderId) {
        return this.GetIncompleteOrdersAssignedTo(orderId);
    }
    /// <summary>
    /// Obtien la liste des nouvelle commande selon l'entrepot specifier
    /// </summary>
    /// <param name="entrepotId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Dao.GetNewOrdersForWarehouse(entrepotId);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Shutdown() {
        try {
            if (!this.DtoManagementWindow.IsDisposed) {
                this.DtoManagementWindow.Dispose();
            }
        } catch (Exception ex) {
            Debug.WriteLine("Failed to dispose of DtoManagementWindow on shutdown (possible memory leak): " + ex.Message);
        }
    }


}
