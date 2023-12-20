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
public class AdresseDAO : AbstractDao<Adresse, int>{

    protected override AbstractContext Context { get; }

    public AdresseDAO(AbstractContext context) {
        this.Context = context;
    }

    public List<Adresse> SearchAdresse(string Filter) 
    { 
       return this.Context.GetDbSet<Adresse>()
       .Where(adresse => adresse.Id.ToString().StartsWith(Filter) || (adresse.NumeroCivique != null && adresse.NumeroCivique.StartsWith(Filter)))
       .ToList();   
    }

    

}
