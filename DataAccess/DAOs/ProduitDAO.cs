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
    protected override AbstractContext Context { get; }

    public ProduitDAO(AbstractContext context) {
        this.Context = context;
    }

    //public Produit GetByProductName(string productName) {
    //    Produit product = this.Context.GetDbSet<Produit>()

    //    .Single(p => p.Name == productName);

    //    return product ?? throw new InvalidOperationException($"No product found with name: {productName}");

    //}


    public (Produit product, int quantity) GetByProductNameWithQuantity(string productName) {
        Produit? result = this.Context.GetDbSet<Produit>()
            .SingleOrDefault(p => p.Name == productName);

        return result == null
            ? throw new InvalidOperationException($"No product found with name: {productName}")
            : ((Produit product, int quantity)) (result, result.InstockQuantity);
    }



    //public Produit GetByUpcCode(int upcCode) {
    //    Produit produit = this.Context.GetDbSet<Produit>()
    //        .Single(u => u.UpcCode == upcCode);

    //    return produit ?? throw new InvalidOperationException($"No product found with UPC code: {upcCode}");
    //}

    public (Produit product, int quantity) GetByUpcCodeWithQuantity(int upcCode) {
        Produit? result = this.Context.GetDbSet<Produit>()
            .SingleOrDefault(u => u.UpcCode == upcCode);

        return result == null
            ? throw new InvalidOperationException($"No product found with UPC code: {upcCode}")
            : ((Produit product, int quantity)) (result, result.InstockQuantity);
    }



}