using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business.Facades;

/// <summary>
/// Classe de facade pour les employés de bureau
/// </summary>
internal class OfficeEmployeeFacade : AbstractFacade {
    private EmployeBureauMainMenu EmployeBureauMainMenu { get; set; }
    private readonly AppDbContext facadecontext;
    private ClientService ClientService { get; set; }
    private ShipmentOrderService ShipmentOrderService { get; set; }
    private AdresseService AdresseService { get; set; }
    private EntrepotService EntrepotService { get; set; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="loginService"></param>
    public OfficeEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService)
        : base(parentApp, loginService) {
        this.facadecontext = new AppDbContext();
        this.ClientService = new ClientService(this, this.facadecontext);
        this.ShipmentOrderService = new ShipmentOrderService(this, this.facadecontext);
        this.EmployeBureauMainMenu = new EmployeBureauMainMenu(this);
        this.AdresseService = new AdresseService(this, this.facadecontext);
        this.EntrepotService = new EntrepotService(this, this.facadecontext);

    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Start() {
        Application.Run(this.EmployeBureauMainMenu);
    }
}
