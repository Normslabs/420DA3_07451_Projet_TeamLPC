using System;
using System.Collections.Generic;
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

    protected override ShipmentOrdersDAO Dao { get; }

    public ShipmentOrderService(AbstractFacade facade, AbstractContext context) {

        this.Dao = new ShipmentOrdersDAO(context);
    }

    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int clientid) {
        return this.GetClientShipmentOrderById(clientid);
    }

    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int orderId) {
        return this.GetIncompleteOrdersAssignedTo(orderId);
    }

    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Dao.GetNewOrdersForWarehouse(entrepotId);
    }

    public ShipmentOrderDTO CreateShipmentOrder(ShipmentOrderDTO newShipmentOrder) {
        return this.Dao.Create(newShipmentOrder);
    }

    public ShipmentOrderDTO DeleteShipmentOrder(ShipmentOrderDTO shipmentOrder) {
        return this.Dao.Delete(shipmentOrder);
    }

    public ShipmentOrderDTO UpdateShipmentOrder(ShipmentOrderDTO shipmentOrder) {
        return this.Dao.Update(shipmentOrder);
    }
}
