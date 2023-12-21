using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class OfficeEmployeeFacade : AbstractFacade {
    private EmployeBureauMainMenu employeBureauMainMenu { get; set; }
    private readonly AppDbContext facadecontext;
    private ClientService clientService { get; set; }
    private ShipmentOrderService shipmentorderservice { get; set; }
    private AdresseService adresseservice { get; set; }
    private EntrepotService entrepotservice { get; set; }


    public OfficeEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.facadecontext = new AppDbContext();
        this.clientService = new ClientService(this, this.facadecontext);
        this.shipmentorderservice = new ShipmentOrderService(this, this.facadecontext);
        this.employeBureauMainMenu = new EmployeBureauMainMenu(this);
        this.adresseservice = new AdresseService(this, this.facadecontext);
        this.entrepotservice = new EntrepotService(this, this.facadecontext);



    }

    public override void Start() {
        Application.Run(this.employeBureauMainMenu);
    }
}
