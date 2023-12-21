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
/// Classe de Data access représentant le fournisseur
/// </summary>
public class FournisseurDAO : AbstractDao<Fournisseur, int> {


    /// <summary>
    /// Déclaration du abstractContext
    /// </summary>
    protected override AbstractContext Context { get; }


    /// <summary>
    /// Constructeur pour le abstractContext
    /// </summary>
    /// <param name="context"></param>
    public FournisseurDAO (AbstractContext context) {
        this.Context = context;
    }


    /// <summary>
    /// Constructeur pour le GetById de fournisseur
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public override Fournisseur? GetById(int identifier) {
        return this.Context.GetDbSet<Fournisseur>()
            .Where(user => user.Id == identifier)
            .SingleOrDefault();
    }


    /// <summary>
    /// constructeur pour la recherche filtré pour le fournisseur
    /// </summary>
    /// <param name="Filter"></param>
    /// <returns></returns>
    public List<Fournisseur> SearchFournisseur(string Filter) {
        return this.Context.GetDbSet<Fournisseur>()
            .Where(fournisseur => fournisseur.Id.ToString().StartsWith(Filter) || (fournisseur.SupplierName != null && fournisseur.SupplierName.StartsWith(Filter)))
            .ToList();

    }





}
