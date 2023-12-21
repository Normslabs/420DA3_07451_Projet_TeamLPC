using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class AdminFacade : AbstractFacade {
    private readonly AdminUserMainMenu mainMenu;
    private readonly AppDbContext facadeContext;

    private UtilisateurService UtilisateurService { get; set; }
    private RoleService RoleService { get; set; }

    // declaration du service fournisseur dans la facade admin
    private FournisseurService FournisseurService { get; set; }
    // declaration du service shipment dans la facade admin
    private ShipmentService ShipmentService { get; set; }
    
    
    // TODO: @Everyone: ajoutez des propriétés pour vos services ici

    public AdminFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.facadeContext = new AppDbContext();
        this.UtilisateurService = new UtilisateurService(this, this.facadeContext);
        this.RoleService = new RoleService(this, this.facadeContext);
        //Ajout du service fournisseur dans la facade admin
        this.FournisseurService = new FournisseurService(this, this.facadeContext);
        // ajout du service shipment dans la facade admin
        this.ShipmentService = new ShipmentService(this, this.facadeContext);

        // TODO: @Everyone: initialisez vos services ici

        
        this.mainMenu = new AdminUserMainMenu(this);
    }

    public override void Start() {
        Application.Run(this.mainMenu);
    }

    public void ExitApplication() {
        this.ParentApplication.Shutdown();
    }
}
