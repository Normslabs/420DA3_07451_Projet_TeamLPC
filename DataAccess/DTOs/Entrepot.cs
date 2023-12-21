using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe Entrepot 
/// Representation d'une adresse (adresse  associer a un entrepot) du systeme
/// </summary>
/// <remarks>
/// <para>
/// Hérite de <see cref="AbstractDTO{int}"/>
/// </para>
/// <para>
/// Possedant une assoication avec un avec un <see cref="Adresse"/> qui determine l'adresse d'un entrepot
/// </para>
/// <para>
/// Possèdent une <see cref="List{T}">liste</see> d'<see cref="Utilisateur">utilisateur</see> qui possèdent un entrepot.
/// Possèdent une <see cref="List{T}">liste</see> d'<see cref="ShipmentOrder">shipmentOrder</see> qui possèdent un entrepot.
/// Possèdent une <see cref="List{T}">liste</see> d'<see cref="PurchaseOrders">purchaseOrders</see> qui possèdent un entrepot.
/// Possèdent une <see cref="List{T}">liste</see> d'<see cref="Clients">clients</see> qui possèdent un entrepot.
/// </para>
///
/// </remarks>
/// 
public class Entrepot : AbstractDTO<int> {

    public const int MAX_NOMENTREPOT_LENGTH = 25;
   

    public string NomEntrepot { get; set; } = null!;
    public int AdresseId { get; set; }
    public virtual Adresse AdresseEntrepot { get; set; } = null!;
    
    /// <summary>
    /// Les Utilisateurs qui possedent un entrepot
    /// </summary>
    public virtual List<Utilisateur> Utilisateur { get; set; } = null!;

    /// <summary>
    /// Les ShipmentOrder qui possèdent un entrepot.
    /// </summary>
    public virtual List<ShipmentOrderDTO> ShipmentOrder { get; set; } = null!;

    /// <summary>
    /// Les PurchaseOrder qui possèdent un entrepot.
    /// </summary>
    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = null!;

    /// <summary>
    /// Les Clients qui possèdent un entrepot.
    /// </summary>
    public virtual List<ClientsDTO> Clients { get; set; } = null!;
    public byte[] RowVersion { get; set; } = null!;



    /// <summary>
    /// Constructeur vide
    /// </summary>
    public Entrepot() : base(){ }

    /// <summary>
    /// Constructeur utilisable dans les services.
    /// </summary>
    /// <param name="nomEntrepot">Le nom de l'entrepot.</param>
    /// <param name="adresseId">L'identifiant de l'Adresse de l'Entrepôt</param>
    public Entrepot(string nomEntrepot, int adresseId) { 
        this.NomEntrepot = nomEntrepot;
        this.AdresseId = adresseId;
    }


    /// <summary>
    /// Constructeur réservé pour EF Core.
    /// </summary>
    /// <param name="id">L'identifiant interne du l'entrepot</param>
    /// <param name="nomEntrepot">Le nom de l'entrepot</param>
    /// <param name="adresseId">L'identifiant de l'Adresse de l'entrepôt</param>
    /// <param name="rowversion">Une signature anti-concurrence.</param>
    protected Entrepot(int id, string nomEntrepot, int adresseId, byte[] rowversion  ) {
       
        this.Id = id;
        this.NomEntrepot = nomEntrepot;
        this.AdresseId = adresseId;
        this.RowVersion = rowversion;

    }


    /// <summary>
    /// Vérifie si le nom de l'entrepot potentiel (lors de la création/modification d'un entrepot) est valide.
    /// </summary>
    /// <param name="nomEntrepot">Le nom d'entrepot potentiel à valider</param>
    /// <returns><see langword="true"/> si le nom de l'entrepot potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderNomEntrepot(string nomEntrepot) 
    {
        return nomEntrepot.Length <= MAX_NOMENTREPOT_LENGTH;
    }

}
