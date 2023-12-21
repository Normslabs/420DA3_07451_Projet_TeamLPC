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

/// <summary>
/// Classe d'accès aux données pour les entités <see cref="Entrepot"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{DtoType, DtoIdType}"/>.
/// </remarks>
public class EntrepotDAO : AbstractDao<Entrepot, int> {

    protected override AbstractContext Context { get; }


    // <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte EF Core utilisé par le DAO.</param>
    public EntrepotDAO(AbstractContext context) 
    { 
       this.Context = context;
    }

    /// <summary>
    /// <inheritdoc/>
    /// Charge les adresses des entrepots.
    /// </summary>
    /// <returns>La liste de tous les adresses des entrepots.</returns>
    public override List<Entrepot> GetAll() {
        return this.GetAllWithAddress();
    }

    /// <summary>
    /// <inheritdoc/>
    /// Charge les adresses  par Id 
    /// 
    /// 
    /// <param name="identifier">L'Id de l'enbtrepot à obtenir.</param>
    /// <returns>L'<see cref="Entrepot"/> trouvé ou <see langword="null"/> si aucun entrpot correspondant trouvé.</returns>
    public override Entrepot? GetById(int identifier) {
        return this.GetById(identifier);
    }


    /// <summary>
    /// <inheritdoc/>
    /// Charge les adresses de entrepots
    /// </summary>
    /// <returns>La liste de tous les entrepots </returns>
    public List<Entrepot> GetAllWithAddress() {
        return this.Context.GetDbSet<Entrepot>()
            .Include(entrepot => entrepot.AdresseEntrepot)
            .ToList();
    }

    /// <summary>
    /// <inheritdoc/>
    /// Charge les adresses de entrepots parf Id 
    /// </summary>
    /// <returns>La liste de tous les entrepots  par Id </returns>
    public Entrepot? GetEntrepotByIdWithAddress(int id) {
        return this.Context.GetDbSet<Entrepot>()
            .Where(entrepot => entrepot.Id == id)
            .Include(entrepot => entrepot.AdresseEntrepot) 
            .SingleOrDefault();
    }


}
