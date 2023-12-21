using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class AdresseService : AbstractDtoService<Adresse, int> {
    protected override AdresseDAO Dao { get; }

    protected override AdresseManagementForm DtoManagementWindow { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="facade">La facade de l'exécution.</param>
    /// <param name="context">Le contexte EF Core de l'application.</param>
    public AdresseService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new AdresseDAO(context);
        this.DtoManagementWindow = new AdresseManagementForm(facade);
    }

    /// <summary>
    /// Obtient de la base de données la liste de tous les <see cref="Adresse"/> existants.
    /// </summary>
    /// <returns>La <see cref="List{Adresse}"/> de tous les adresses existants.</returns>
    public List<Adresse> GetAllAddresses() {
        return this.Dao.GetAll();
    }

    /// <summary>
    /// Recherche des <see cref="Adresse">Roles</see> par leur <see cref="Adresse.NumeroCivique">Nom</see> et 
    /// leur <see cref="Adresse.Rue">Description</see>.
    /// </summary>
    /// <remarks>
    /// Voir <see cref="AdresseDAO.SearchAdresse(string)"/>.
    /// </remarks>
    /// <param name="filter">Le filtre de recherche</param>
    /// <returns>La <see cref="List{Adresse}"/> les adresses correspondants.</returns>
    public List<Adresse> SearchAdresse(string filter) { 
        return this.Dao.SearchAdresse(filter);
    }

    /// <summary>
    /// <inheritdoc/>
    /// Fonction pour le shutdown
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>  
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
}
