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
public class AdresseService : AbstractDtoService<Adresse, int> {
    protected override AdresseDAO Dao { get; }

    protected override AdresseManagementForm DtoManagementWindow { get; }


    public AdresseService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new AdresseDAO(context);
        this.DtoManagementWindow = new AdresseManagementForm(facade);
    }

    public List<Adresse> GetAllAddresses() {
        return this.Dao.GetAll();
    }

        
    public override void Shutdown() {
        throw new NotImplementedException();
    }
}
