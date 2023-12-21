using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class OfficeEmployeeFacade : AbstractFacade {
    private EmployeBureauMainMenu employeBureauMainMenu;
    private AppDbContext appDbContext;
    public OfficeEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.employeBureauMainMenu = new EmployeBureauMainMenu(this);
        this.appDbContext = new AppDbContext();
    }

    public override void Start() {
        Application.Run(this.employeBureauMainMenu);
    }
}
