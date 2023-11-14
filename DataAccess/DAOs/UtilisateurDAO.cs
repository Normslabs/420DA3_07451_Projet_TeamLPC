using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class UtilisateurDAO : AbstractDao<Utilisateur, int> {
    protected override AbstractContext Context { get; }

    public UtilisateurDAO(AbstractContext context) {
        this.Context = context;
    }

    public override List<Utilisateur> GetAll() {
        return this.Context.GetDbSet<Utilisateur>()
            .Include(user => user.Roles)
            .ToList();
    }

    public override Utilisateur? GetById(int identifier) {
        return this.Context.GetDbSet<Utilisateur>()
            .Where(user => user.Id == identifier)
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .SingleOrDefault();
    }

    public Utilisateur? GetByUsername(string username) {
        return this.Context.GetDbSet<Utilisateur>()
            .Where(user => user.Username == username)
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .SingleOrDefault();
    }
}
