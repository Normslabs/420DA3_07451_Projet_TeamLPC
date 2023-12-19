using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ShipmentService : AbstractDtoService<ShipmentDTO, int> {

    protected override ShipmentWindow DtoManagementWindow { get; }

    protected override ShipmentDAO Dao { get; }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }


    public ShipmentService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ShipmentDAO(context);
        this.DtoManagementWindow = new ShipmentWindow(facade);
    }



    public ShipmentDTO GetShipmentById(int identifier) {
        return this.Dao.GetById(identifier);
    }


    public List<ShipmentDTO> SearchShipment(string filter) {
        return this.Dao.SearchShipment(filter);
    }
 
}
