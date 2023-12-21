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

    public UtilisateurService UtilisateurService { get; set; }
    public RoleService RoleService { get; set; }
    public FournisseurService FournisseurService { get; set; }
    public ShipmentService ShipmentService { get; set; }
    public AdresseService AdresseService { get; set; }
    public EntrepotService EntrepotService { get; set; }
    public ProduitService ProduitService { get; set; }
    public PurchaseOrderService PurchaseOrderService { get; set; }
    public ShipmentOrderService ShipmentOrderService { get; set; }
    public ClientService ClientService { get; set; }
    
    
    // TODO: @Everyone: ajoutez des propriétés pour vos services ici

    public AdminFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.facadeContext = new AppDbContext();
        this.UtilisateurService = new UtilisateurService(this, this.facadeContext);
        this.RoleService = new RoleService(this, this.facadeContext);
        this.FournisseurService = new FournisseurService(this, this.facadeContext);
        this.ShipmentService = new ShipmentService(this, this.facadeContext);
        this.AdresseService = new AdresseService(this, this.facadeContext);
        this.EntrepotService = new EntrepotService(this, this.facadeContext);
        this.ProduitService = new ProduitService(this, this.facadeContext);
        this.PurchaseOrderService = new PurchaseOrderService(this, this.facadeContext);
        this.ShipmentOrderService = new ShipmentOrderService(this, this.facadeContext);
        this.ClientService = new ClientService(this, this.facadeContext);

        
        this.mainMenu = new AdminUserMainMenu(this);
    }

    public override void Start() {
        Application.Run(this.mainMenu);
    }

    public void ExitApplication() {
        this.ParentApplication.Shutdown();
    }
}
