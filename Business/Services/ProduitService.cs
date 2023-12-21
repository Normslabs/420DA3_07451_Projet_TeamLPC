using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;



namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ProduitService : AbstractDtoService<Produit, int> {

    protected override ProduitDAO Dao {get;}
    protected override ProduitWindow DtoManagementWindow { get;}


    /// <summary>
    /// Declaration du constructeur de la facade abstractcontext pour le service de Produit
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public ProduitService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ProduitDAO(context);
        this.DtoManagementWindow = new ProduitWindow(facade);

    }
    /// <summary>
    /// Declaration de la methode shutdown qui permet de ferme le management window
    /// </summary>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    /// <summary>
    /// methode qui permet d'aller chercher les produit avec leur noms, avec leur fournisseurs
    /// </summary>
    /// <param name="productName"></param>
    /// <returns></returns>
    public List<Produit> GetProductsByName(string productName) {
        return this.Dao.GetByProductNameWithFournisseur(productName);
    }
    /// <summary>
    /// Methode qui permet d'aller prendre un Produit avec le UPC Code ainsi que la quantite du produit
    /// </summary>
    /// <param name="UPC"></param>
    /// <returns></returns>
    public Produit GetProductsByUPC(int UPC) {
        return this.Dao.GetByUpcCodeWithQuantity(UPC);
    }

}
