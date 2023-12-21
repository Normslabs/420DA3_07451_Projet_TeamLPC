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

    /// <summary>
    /// Classe d'accès aux données pour les entités <see cref="Adresse"/>.
    /// </summary>
    /// <remarks>
    /// Hérite de <see cref="AbstractDao{DtoType, DtoIdType}"/>.
    /// </remarks>
public class AdresseDAO : AbstractDao<Adresse, int>{

    protected override AbstractContext Context { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte EF Core utilisé par le DAO.</param>
    public AdresseDAO(AbstractContext context) {
        this.Context = context;
    }

    /// <summary>
    /// Méthode de recherche de l'adresse par Id
    /// </summary>
    /// <param name="Filter"></param>
    /// <returns></returns>
    public List<Adresse> SearchAdresse(string Filter) 
    { 
       return this.Context.GetDbSet<Adresse>()
       .Where(adresse => adresse.Id.ToString().StartsWith(Filter) || (adresse.NumeroCivique != null && adresse.NumeroCivique.StartsWith(Filter)))
       .ToList();   
    }

    

}
