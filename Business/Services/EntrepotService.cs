using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Diagnostics;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class EntrepotService : AbstractDtoService<Entrepot, int> {

    protected override EntrepotDAO Dao { get; }

    protected override EntrepotManagementForm DtoManagementWindow { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="facade">La facade-utilisateur de l'exécution.</param>
    /// <param name="context">Le contexte EF Core de l'application.</param>
    public EntrepotService(AbstractFacade facade, AbstractContext context) {

        facade.RegisterDependent(this);
        this.Dao = new EntrepotDAO(context);
        this.DtoManagementWindow = new EntrepotManagementForm(facade);

    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public override void Shutdown() {
        this.DtoManagementWindow.Dispose();
    }

    /// <summary>
    /// Obtient de la base de données la liste de tous les <see cref="Entrepot"/> existants.
    /// </summary>
    /// <returns>La <see cref="List{Entrepot}"/> de tous les entrepots existants.</returns>
    public List<Entrepot> GetAllEntrepot() { 
        return this.Dao.GetAll();
    }


}
