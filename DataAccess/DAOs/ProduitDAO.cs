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


    public Produit GetByProductName(string productName) {
        Produit product = this.Context.GetDbSet<Produit>()
            .Include(p => p.InstockQuantity)  
            .Single(p => p.Name == productName);

        return product ?? throw new InvalidOperationException($"No product found with name: {productName}");
    }



    //public Produit GetByUpcCode(int upcCode) {
    //    Produit produit = this.Context.GetDbSet<Produit>()
    //        .Single(u => u.UpcCode == upcCode);

    //    return produit ?? throw new InvalidOperationException($"No product found with UPC code: {upcCode}");
    //}

    public Produit GetByUpcCodeWithQuantity(int upcCode) {
        Produit? result = this.Context.GetDbSet<Produit>()
            .Include(p => p.InstockQuantity)
            .Single(u => u.UpcCode == upcCode);

        return result ?? throw new InvalidOperationException($"No product found with UPC code: {upcCode}");
    }





}