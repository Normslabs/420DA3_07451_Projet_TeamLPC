using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe Utilisateur<br/>
/// Représentation d'un utilisateur du système
/// </summary>
/// <remarks>
/// <para>
/// Hérite de <see cref="AbstractDTO{int}"/>.
/// </para>
/// <para>
/// Possèdent optionellement une association avec un <see cref="Entrepot"/> pour les utilisateurs étant des
/// employés d'entrepôt.<br/>
/// Possèdent une <see cref="List{T}">liste</see> de <see cref="Role">roles</see> déterminant leur catégorie d'emploi.
/// </para>
/// </remarks>
public class Utilisateur : AbstractDTO<int> {
    public const int USERNAME_MIN_LENGTH = 3;
    public const int USERNAME_MAX_LENGTH = 32;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 32;


    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public int? EntrepotDeTravailId { get; set; }
    public DateTime DateCreated { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    /// <summary>
    /// L'entrepôt où l'utilisateur travaille s'il-y-a lieu; sinon, <see langword="null"/>.
    /// </summary>
    public Entrepot EntrepotDeTravail { get; set; } = null!;
    /// <summary>
    /// La liste des rôles que l'utilisateur possède.
    /// </summary>
    public List<Role> Roles { get; set; } = null!;


    #region Constructeurs

    /// <summary>
    /// Constructeur vide
    /// </summary>
    public Utilisateur() : base() { }

    /// <summary>
    /// Constructeur utilisable dans les services
    /// </summary>
    /// <param name="username">Le nom d'utilisateur</param>
    /// <param name="passwordHash">Le mot de passe hashé de l'utilisateur</param>
    public Utilisateur(string username, string passwordHash) : base() {
        this.Username = username;
        this.PasswordHash = passwordHash;
    }

    /// <summary>
    /// Constructeur utilisable dans les services (avec spécification de la warehouse de travail)
    /// </summary>
    /// <param name="username">Le nom d'utilisateur</param>
    /// <param name="passwordHash">Le mot de passe hashé de l'utilisateur</param>
    /// <param name="entrepotDeTravailId">L'identifiant de l'entrepôt oè travaille l'utilisateur (ou null)</param>
    public Utilisateur(string username, string passwordHash, int? entrepotDeTravailId)
        : this(username, passwordHash) {
        this.EntrepotDeTravailId = entrepotDeTravailId;
    }

    /// <summary>
    /// Constructeur dédié pour EF Core (NE PAS UTILISER)
    /// </summary>
    /// <param name="id">L'identifiant de l'utilisateur</param>
    /// <param name="username">Le nom d'utilisateur</param>
    /// <param name="passwordHash">Le mot de passe hashé de l'utilisateur</param>
    /// <param name="entrepotDeTravailId">L'identifiant de l'entrepôt oè travaille l'utilisateur (ou null)</param>
    /// <param name="dateCreated">La date de création de l'utilisateur</param>
    /// <param name="rowVersion">Une signature de validation anti-concurrence</param>
    protected Utilisateur(int id, string username, string passwordHash, int? entrepotDeTravailId, DateTime dateCreated, byte[] rowVersion)
        : this(username, passwordHash, entrepotDeTravailId) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.RowVersion = rowVersion;
    }

    #endregion



    #region Methodes de validation

    /// <summary>
    /// Vérifie si un nom d'utilisateur potentiel (lors de la création/modification d'un utilisateur) est valide.
    /// </summary>
    /// <param name="username">Le nom d'utilisateur potentiel à valider</param>
    /// <returns><see langword="true"/> si le nom d'utilisateur potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderUsername(string username) {
        return username.Length >= USERNAME_MIN_LENGTH && username.Length <= USERNAME_MAX_LENGTH;
    }


    /// <summary>
    /// Vérifie si un mot de passe potentiel (lors de la création/modification d'un utilisateur) est valide.
    /// </summary>
    /// <param name="nonHashedPassword">Le mot de passe potentiel à valider</param>
    /// <returns><see langword="true"/> si le mot de passe potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValidatePassword(string nonHashedPassword) {
        return nonHashedPassword.Length >= PASSWORD_MIN_LENGTH && nonHashedPassword.Length <= PASSWORD_MAX_LENGTH;
    }

    #endregion
}
