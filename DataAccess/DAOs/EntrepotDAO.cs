using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class EntrepotDAO : AbstractDao<Entrepot, int> {

    protected override AbstractContext Context { get; }

    public EntrepotDAO(AbstractContext context) 
    { 
       this.Context = context;
    }

    public override List<Entrepot> GetAll() {
        return this.GetAllWithAddress();
    }

    public override Entrepot? GetById(int identifier) {
        return this.GetById(identifier);
    }

    public List<Entrepot> GetAllWithAddress() {
        return this.Context.GetDbSet<Entrepot>()
            .Include(entrepot => entrepot.AdresseEntrepot)
            .ToList();
    }

    public Entrepot? GetEntrepotByIdWithAddress(int id) {
        return this.Context.GetDbSet<Entrepot>()
            .Where(entrepot => entrepot.Id == id)
            .Include(entrepot => entrepot.AdresseEntrepot) 
            .SingleOrDefault();
    }


}
