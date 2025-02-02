﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class WarehouseEmployeeFacade : AbstractFacade {

    public PurchaseOrderService PurchaseOrderService { get; set; }
    public ShipmentOrderService ShipmentOrderService { get; set; }
    private readonly AppDbContext facadeContext;
    private EmployeEntrepotMainMenu EmployeEntrepotMainMenu { get; set; }




    public WarehouseEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService)
        : base(parentApp, loginService) {
        this.facadeContext = new AppDbContext();
        this.PurchaseOrderService = new PurchaseOrderService(this, this.facadeContext);
        this.ShipmentOrderService = new ShipmentOrderService(this, this.facadeContext);
        this.EmployeEntrepotMainMenu = new EmployeEntrepotMainMenu(this);
    }

    public override void Start() {

        Application.Run(this.EmployeEntrepotMainMenu);
    }



}
