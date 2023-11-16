using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class RoleService : AbstractDtoService<Role, int> {
    protected override RoleDAO Dao { get; }

    protected override IDtoManagementView<Role> DtoManagementWindow { get; }


    public RoleService(AbstractApplication parentApp, AbstractContext context) {
        parentApp.RegisterDependent(this);
        this.Dao = new RoleDAO(context);
    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }
}
