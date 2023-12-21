using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// creation de GetByProductName()
namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ProduitDAO : AbstractDao<Produit, int> {

    /// <summary>
    /// Declaration AbstractDbContext
    /// </summary>
    protected override AbstractContext Context { get; }
    /// <summary>
    /// Contructeur de app DbContext
    /// </summary>
    /// <param name="context"></param>
    public ProduitDAO(AbstractContext context) {
        this.Context = context;
    }
    /// <summary>
    /// Methode pour aller prendre tout les produits ainsi que leur fournissuers
    /// </summary>
    /// <param name="productName"></param>
    /// <returns></returns>
    public Produit GetByProductNameWithFournisseur(string productName) {
        return this.Context.GetDbSet<Produit>()
            .Include(p => p.Fournisseur)
            .Single(p => p.Name == productName);

    }
    /// <summary>
    /// Methode pour aller prendre le UPC code d'un produit avec sa quantite en meme temps
    /// </summary>
    /// <param name="upcCode"></param>
    /// <returns></returns>
    public Produit GetByUpcCodeWithQuantity(int upcCode) {
        return this.Context.GetDbSet<Produit>()
            .Include(p => p.InstockQuantity)
            .Single(u => u.UpcCode == upcCode);
    }





}