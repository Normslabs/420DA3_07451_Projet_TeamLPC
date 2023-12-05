using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business;
internal class GestionEntrepotApplication : AbstractApplication {
    public const string DATETIME_DISPLAY_FORMAT = "yyyy/MM/dd HH:mm:ss.ffffff";
    private LoginFacade LoginFacade { get; set; }
    public AbstractFacade? RuntimeFacade { get; private set; }

    public GestionEntrepotApplication() {
        AppDbContext context = new AppDbContext();
        this.LoginFacade = new LoginFacade(this, context);

    }

    public override void Start() {
        // Start() of the login facade will force login form to show up and the user
        // to authenticate.
        this.LoginFacade.Start();

        Utilisateur loggedInUser = this.LoginFacade.GetLoginService().GetLoggedInUser();

        Role userRole;

        bool isRoleValid = false;
        while (!isRoleValid) {
            if (loggedInUser.Roles.Count > 1) {
                // user has multiple roles, handle this case.
                userRole = this.LoginFacade.GetService<LoginService>().SelectUserRole(loggedInUser);
            } else {
                userRole = loggedInUser.Roles.Single();
            }

            switch (userRole.Id) {
                case Role.ADMINISTRATOR_ROLE_ID:
                    isRoleValid = true;
                    this.RuntimeFacade = new AdminFacade(this, this.LoginFacade.GetLoginService());
                    break;
                case Role.OFFICE_EMPLOYEE_ROLE_ID:
                    isRoleValid = true;
                    this.RuntimeFacade = new OfficeEmployeeFacade(this, this.LoginFacade.GetLoginService());
                    break;
                case Role.WAREHOUSE_EMPLOYEE_ROLE_ID:
                    isRoleValid = true;
                    this.RuntimeFacade = new WarehouseEmployeeFacade(this, this.LoginFacade.GetLoginService());
                    break;
                default:
                    throw new Exception($"Le role [{userRole.RoleName}] n'est pas supporté.");
            }
        }

        this.RuntimeFacade?.Start();

    }

    public override void Shutdown() {
        base.Shutdown();
        Application.Exit();
    }
}
