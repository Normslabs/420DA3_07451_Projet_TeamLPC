using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class WarehouseEmployeeFacade : AbstractFacade {

    public PurchaseOrderService PurchaseOrderService { get; set; }
    public ShipmentOrderService ShipmentOrderService { get; set; }
    private readonly AppDbContext facadeContext;




    public WarehouseEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.PurchaseOrderService = new PurchaseOrderService(this, this.facadeContext);
        this.ShipmentOrderService = new ShipmentOrderService(this, this.facadeContext);
    }

    public override void Start() {
        throw new NotImplementedException();
    }


    
}
