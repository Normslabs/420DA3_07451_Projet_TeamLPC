using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _420DA3_07451_Projet_Initial.Business.Services;
public class PurchaseOrderService : AbstractDtoService<PurchaseOrder, int> {
    /// <summary>
    /// Déclaration du PurchaseOrderService data access ainsi que la fenetre de management
    /// </summary>
    protected override PurchaseOrderDAO Dao { get; }
    protected override PurchaseOrderForm DtoManagementWindow { get; }
    /// <summary>
    /// Declaration du constructeur 
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public PurchaseOrderService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new PurchaseOrderDAO(context);
        this.DtoManagementWindow = new PurchaseOrderForm(facade);
    }
    //Fonction shutdown pour fermer l'application
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    //Methode qui retourne tout les incompleted purchase order
    public PurchaseOrder GetPurchaseOrder(int id) {
        return this.Dao.GetIncompleteForWarehouse(id);
    }

}
