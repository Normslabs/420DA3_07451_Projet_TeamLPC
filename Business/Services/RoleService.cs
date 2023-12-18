using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class RoleService : AbstractDtoService<Role, int> {
    protected override RoleDAO Dao { get; }

    protected override RoleManagementForm DtoManagementWindow { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="facade">La facade-utilisateur de l'exécution.</param>
    /// <param name="context">Le contexte EF Core de l'application.</param>
    public RoleService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new RoleDAO(context);
        this.DtoManagementWindow = new RoleManagementForm(facade);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    /// <summary>
    /// Obtient de la base de données la liste de tous les <see cref="Role"/> existants.
    /// </summary>
    /// <returns>La <see cref="List{Role}"/> de tous les roles existants.</returns>
    public List<Role> GetAllRoles() {
        return this.Dao.GetAll();
    }

    /// <summary>
    /// Recherche des <see cref="Role">Roles</see> par leur <see cref="Role.RoleName">Nom</see> et 
    /// leur <see cref="Role.RoleDescription">Description</see>.
    /// </summary>
    /// <remarks>
    /// Voir <see cref="RoleDAO.SearchRole(string)"/>.
    /// </remarks>
    /// <param name="userInput">Le filtre de recherche</param>
    /// <returns>La <see cref="List{Role}"/> des roles correspondants.</returns>
    public List<Role> SearchRole(string userInput) {
        return this.Dao.SearchRole(userInput);
    }

}
