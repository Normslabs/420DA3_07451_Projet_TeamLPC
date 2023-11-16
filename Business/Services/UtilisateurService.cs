using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class UtilisateurService : AbstractDtoService<Utilisateur, int> {
    protected override UtilisateurDAO Dao { get; }

    protected override IDtoManagementView<Utilisateur> DtoManagementWindow { get; }

    public UtilisateurService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(facade);
        this.Dao = new UtilisateurDAO(context);

    }





    public override void Shutdown() {
        try {
            this.DtoManagementWindow.Dispose();
        } catch (Exception ex) {
            Debug.WriteLine("Failed to dispose of DtoManagementWindow on shutdown (possible memory leak): " + ex.Message);
        }
    }
}
