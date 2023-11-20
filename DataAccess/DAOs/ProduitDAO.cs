using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ProduitDAO : AbstractDao<Produit, int> {
    protected override AbstractContext Context { get; }

    public ProduitDAO(AbstractContext context) {
        this.Context = context;
    }

    public override List<Produit> GetAll() {
        return this.Context.GetDbSet<Produit>()
            .Include(user => user.UpcCode)
            .ToList();
    }

    public override Produit? GetById(int identifier) {
        return this.Context.GetDbSet<Produit>()
            .Where(user => user.Id == identifier)
            .Include(user => user.UpcCode)
            .Include(user => user.Name)
            .SingleOrDefault();
    }

    public Produit? GetByUsername(string username) {
        return this.Context.GetDbSet<Produit>()
            .Where(user => user.Name == username)
            .Include(user => user.Description)
            .Include(user => user.SupplierCode)
            .SingleOrDefault();
    }

}