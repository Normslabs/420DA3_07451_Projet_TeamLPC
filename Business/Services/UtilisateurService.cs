using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Classe de services de gestion des entités de type <see cref="Utilisateur"/>
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDtoService{DtoType, DtoIdType}"/>.
/// </remarks>
public class UtilisateurService : AbstractDtoService<Utilisateur, int> {
    protected override UtilisateurDAO Dao { get; }

    protected override UtilisateurManagementForm DtoManagementWindow { get; }

    public UtilisateurService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(facade);
        this.Dao = new UtilisateurDAO(context);
        this.DtoManagementWindow = new UtilisateurManagementForm(facade);
    }

    public List<Utilisateur> GetAllUtilisateurs() {
        return this.Dao.GetAll();
    }

    public Utilisateur? FindUtilisateurByUsername(string username) {
        return this.Dao.GetByUsername(username);
    }

    public List<Utilisateur> SearchUsersByRoleName(string roleNameFilter) {
        return this.Dao.SearchUsersByRoleName(roleNameFilter);
    }

    public override void Shutdown() {
        try {
            if (!this.DtoManagementWindow.IsDisposed) {
                this.DtoManagementWindow.Dispose();
            }
        } catch (Exception ex) {
            Debug.WriteLine("Failed to dispose of DtoManagementWindow on shutdown (possible memory leak): " + ex.Message);
        }
    }
}
