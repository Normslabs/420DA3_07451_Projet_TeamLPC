using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class FournisseurService : AbstractDtoService<Fournisseur, int> {

    protected override AbstractDao<Fournisseur, int> Dao { get; }
    protected override FournisseurWindow DtoManagementWindow { get; }

    public FournisseurService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new FournisseurDAO(context);
        this.DtoManagementWindow = new FournisseurWindow(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public Fournisseur? GetFournisseurById(int identifier) {
        return this.Dao.GetById(identifier);
    }



}
