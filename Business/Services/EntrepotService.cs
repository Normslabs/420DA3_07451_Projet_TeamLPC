using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class EntrepotService : AbstractDtoService<Entrepot, int> {

    protected override EntrepotDAO  Dao { get; }

    protected override EntrepotManagementForm DtoManagementWindow { get; }

    public EntrepotService(AbstractFacade facade, AbstractContext context) {

        facade.RegisterDependent(this);
        this.Dao = new EntrepotDAO(context);
        this.DtoManagementWindow = new EntrepotManagementForm(facade);   
        
    }

    public override void Shutdown() {
        this.DtoManagementWindow.Dispose();
    }



}
