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
/// Classe d'accès aux données pour les entités <see cref="Utilisateur"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{DtoType, DtoIdType}"/>.
/// </remarks>
public class UtilisateurDAO : AbstractDao<Utilisateur, int> {
    protected override AbstractContext Context { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte EF Core utilisé par le DAO.</param>
    public UtilisateurDAO(AbstractContext context) {
        this.Context = context;
    }

    /// <summary>
    /// <inheritdoc/>
    /// Charge hâtivement les rôles des utilisateurs.
    /// </summary>
    /// <returns>La liste de tous les utilisateurs.</returns>
    public override List<Utilisateur> GetAll() {
        return this.Context.GetDbSet<Utilisateur>()
            .Include(user => user.Roles)
            .ToList();
    }

    /// <summary>
    /// <inheritdoc/>
    /// Charge hâtivement les rôles (<see cref="Utilisateur.Roles"/>) et l'entrepot 
    /// de travail (<see cref="Utilisateur.EntrepotDeTravail"/>) de l'utilisateur.
    /// </summary>
    /// <param name="identifier">L'Id de l'utilisateur à obtenir.</param>
    /// <returns>L'<see cref="Utilisateur"/> trouvé ou <see langword="null"/> si aucun utilisateur correspondant trouvé.</returns>
    public override Utilisateur? GetById(int identifier) {
        return this.Context.GetDbSet<Utilisateur>()
            .Where(user => user.Id == identifier)
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .SingleOrDefault();
    }

    /// <summary>
    /// Obtient l'instance de <see cref="Utilisateur"/> dont le <see cref="Utilisateur.Username"/> correspond
    /// à <paramref name="username"/>. Charge hâtivement les rôles (<see cref="Utilisateur.Roles"/>) et 
    /// l'entrepot de travail (<see cref="Utilisateur.EntrepotDeTravail"/>) de l'utilisateur.
    /// </summary>
    /// <param name="username">Le nom d'utilisateur de l'utilisateur à obtenir.</param>
    /// <returns>L'<see cref="Utilisateur"/> trouvé ou <see langword="null"/> si aucun utilisateur correspondant trouvé.</returns>
    public Utilisateur? GetByUsername(string username) {
        return this.Context.GetDbSet<Utilisateur>()
            .Where(user => user.Username == username)
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .SingleOrDefault();
    }

    /// <summary>
    /// Méthode de recherche d'utilisateurs par nom de rôle
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<Utilisateur> SearchUsersByRoleName(string filter) {
        return this.Context.GetDbSet<Utilisateur>()
            .Include(user => user.Roles)
            .Where(user => user.Roles.Any(
                role => role.RoleName.StartsWith(filter)
                )
            ).ToList();
    }

    /// <summary>
    /// Retourne la liste de tous les employés d'entrepôt.
    /// </summary>
    /// <returns></returns>
    public List<Utilisateur> GetEmployesDEntrepot() {
        return this.Context.GetDbSet<Utilisateur>()
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .Where(user => user.Roles.Any(role => role.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID))
            .ToList();
    }

    /// <summary>
    /// Retourne tous les employés d'entrepôt travaillant dans un entrepot spécifié en paramètre.
    /// </summary>
    /// <param name="entrepot"></param>
    /// <returns></returns>
    public List<Utilisateur> GetEmployesDEntrepot(Entrepot entrepot) {
        return this.Context.GetDbSet<Utilisateur>()
            .Include(user => user.Roles)
            .Include(user => user.EntrepotDeTravail)
            .Where(user => 
                user.Roles.Any(role => role.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID) 
                && user.EntrepotDeTravail != null && user.EntrepotDeTravail.Id == entrepot.Id)
            .ToList();
    }
}
