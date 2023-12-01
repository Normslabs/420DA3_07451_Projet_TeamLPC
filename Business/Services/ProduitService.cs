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
    protected ProduitWindow ProduitManagementWindow {get;}

    protected override IDtoManagementView<Produit> DtoManagementWindow {
        get {
            throw new NotImplementedException();
        }
    }

    public ProduitService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ProduitDAO(context);
        this.ProduitManagementWindow = new ProduitWindow(facade);

    }

    public override void Shutdown() {
        if (!this.ProduitManagementWindow.IsDisposed) {
            this.ProduitManagementWindow.Dispose();
        }
    }

    public Produit GetProductsByName(string productName) {
        return this.Dao.GetByProductNameWithFournisseur(productName);
    }

    public Produit GetProductsByUPC(int UPC) {
        return this.Dao.GetByUpcCodeWithQuantity(UPC);
    }

}
