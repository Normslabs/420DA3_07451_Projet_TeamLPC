using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Diagnostics;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Classe service du fournisseur
/// </summary>
public class FournisseurService : AbstractDtoService<Fournisseur, int> {


    /// <summary>
    /// Déclaration du fournisseur data access ainsi que la fenetre de management
    /// </summary>
    protected override FournisseurDAO Dao { get; }
    protected override FournisseurWindow DtoManagementWindow { get; }

    /// <summary>
    /// Déclaration du constructeur de la facade abstractcontext pour la service de fournisseur
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public FournisseurService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new FournisseurDAO(context);
        this.DtoManagementWindow = new FournisseurWindow(facade);
    }

    /// <summary>
    /// Déclaration de la fonction shutdown permettant de fermer le managementwindow
    /// </summary>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    /// <summary>
    /// Déclaration de la fonction permettant de retourner un fournisseur par son Id
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public Fournisseur? GetFournisseurById(int identifier) {
        return this.Dao.GetById(identifier);
    }

    /// <summary>
    /// Déclaration de la liste permettant la recherche d'un fournisseur en particulier
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<Fournisseur> SearchFournisseur(string filter) {
        return this.Dao.SearchFournisseur(filter);
    }


    /// <summary>
    /// Déclaration de la liste permettant de retourner tous les fournisseurs
    /// </summary>
    /// <returns></returns>
    public List<Fournisseur> GetAllFournisseur() {
        return this.Dao.GetAll();
    }



}
