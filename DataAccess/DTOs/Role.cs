using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe Utilisateur<br/>
/// Représentation d'un rôle (type d'emploi des utilisateurs) du système.
/// </summary>
/// <remarks>
/// <para>
/// Hérite de <see cref="AbstractDTO{int}"/>.
/// </para>
/// <para>
/// Possèdent une <see cref="List{T}">liste</see> d'<see cref="Utilisateur">utilisateurs</see> qui possèdent le rôle.
/// </para>
/// </remarks>
public class Role : AbstractDTO<int> {
    /// <summary>
    /// Identifiant interne du rôle associé aux administrateurs.
    /// </summary>
    public const int ADMINISTRATOR_ROLE_ID = 1;
    /// <summary>
    /// Identifiant interne du rôle associé aux employés de bureau.
    /// </summary>
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    /// <summary>
    /// Identifiant interne du rôle associé aux exployés d'entrepôt.
    /// </summary>
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;


    public string RoleName { get; set; } = null!;
    public string? RoleDescription { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Les utilisateurs qui possèdent le rôle.
    /// </summary>
    public List<Utilisateur> UtilisateursPossedantRole { get; set; } = null!;


    /// <summary>
    /// Constructeur vide
    /// </summary>
    public Role() : base() { }

    /// <summary>
    /// Constructeur utilisable dans les services.
    /// </summary>
    /// <param name="roleName">Le nom du rôle.</param>
    public Role(string roleName) : this() {
        this.RoleName = roleName;
    }

    /// <summary>
    /// Constructeur utilisable dans les services.
    /// </summary>
    /// <param name="roleName">Le nom du rôle.</param>
    /// <param name="roleDescription">La description du rôle</param>
    public Role(string roleName, string? roleDescription = null)
        : this(roleName) {
        this.RoleDescription = roleDescription;
    }

    /// <summary>
    /// Constructeur réservé pour EF Core (NE PAS UTILISER).
    /// </summary>
    /// <param name="id">L'identifiant interne du rôle</param>
    /// <param name="roleName">Le nom du rôle.</param>
    /// <param name="roleDescription">La description du rôle</param>
    /// <param name="rowVersion">Une signature anti-concurrence.</param>
    protected Role(int id, string roleName, string? roleDescription, byte[] rowVersion)
        : this(roleName, roleDescription) {
        this.Id = id;
        this.RowVersion = rowVersion;
    }
}
