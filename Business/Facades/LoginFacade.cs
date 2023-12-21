using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class LoginFacade : AbstractFacade {
    public UtilisateurService UtilisateurService { get; set; }
    public RoleService RoleService { get; set; }

    public new LoginService LoginService { get; set; }


#pragma warning disable CS0618 // Type or member is obsolete
    public LoginFacade(AbstractApplication parentApp, AppDbContext context)
        : base(parentApp, new LoginService()) {
        // ^^ fake login service passed to parent constructor.

        // replaced by real login service.
        this.LoginService = new LoginService(this);
        this.UtilisateurService = new UtilisateurService(this, context);
        this.RoleService = new RoleService(this, context);
    }
#pragma warning restore CS0618 // Type or member is obsolete

    public AbstractLoginService GetLoginService() {
        return this.LoginService;
    }

    public override void Start() {
        if (!this.GetService<LoginService>().RequireLoggedInUser()) {
            // here user is not logged in AND has cancelled trying to login.
            // close program since login is required.
            _ = MessageBox.Show("L'authentification est requise pour utiliser cette application. L'application va se terminer.",
                "Authentification Requise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.ParentApplication.Shutdown();
        }

        // at this point a use has logged in
        // Login facade start can terminate. Logged in user will be used by application
        // to start the real facades based on the logged in user's role
    }
}
