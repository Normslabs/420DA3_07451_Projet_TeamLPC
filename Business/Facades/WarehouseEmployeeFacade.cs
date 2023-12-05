using _420DA3_07451_Projet_Initial.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class WarehouseEmployeeFacade : AbstractFacade {
    public WarehouseEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) 
        : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
    }

    public override void Start() {
        throw new NotImplementedException();
    }
}
