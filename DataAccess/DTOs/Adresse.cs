using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe Adresse <br/>
/// Représentation d'une adresse du système
/// </summary>
/// <remarks>
/// <para>
/// Héritage de <see cref="AbstractDTO{int}"/>
/// </para>
public class Adresse : AbstractDTO<int> {
    public const int MAX_NUMEROCIVIQUE_LENGTH = 8;
    public const int MAX_PAYS_LENGTH = 42;
    public const int MAX_CODEPOSTAL_LENGTH = 6;
    public const int MAX_PROVINCE_LENGTH = 38;
    public const int MAX_RUE_LENGTH = 25;
    public const int MAX_VILLE_LENGTH = 25;


    public string Ville { get; set; } = null!;
    public string NumeroCivique { get; set; } = null!;
    public string Pays { get; set; } = null!;
    public string CodePostal { get; set; } = null!;
    public string Province { get; set; } = null!;
    public byte[] Rowversion { get; set; } = null!;
    public string Rue { get; set; } = null!;


    public virtual Fournisseur? AdresseFournisseur { get; set; } = null!;
    public virtual Entrepot? AdresseEntrepot { get; set; } = null!;
    public virtual ClientsDTO? Client { get; set; } = null!;


    /// <summary>
    /// Constructeur vide
    /// </summary>
    public Adresse() : base(){ 
    
    
    }

    /// <summary>
    /// Constructeur utilisable dans les services
    /// </summary>
    /// <param name="ville">ville de l'adresse</param>
    /// <param name="numerocivique">Le numerique civique de l'adresse</param>
    /// <param name="pays">Le pays ou ce trouve l'adresse</param>
    /// <param name="postalCode">Le code postal de la region de l'adresse</param>
    /// <param name="province">La province ou ce trouve l'adresse</param>
    /// <param name="rue">La rue ou ce trouve l'adresse/param>
    public Adresse( string ville, string numerocivique,
        string pays, string postalCode, string province, string rue) {
     
        this.Ville = ville;
        this.NumeroCivique = numerocivique;
        this.Pays = pays;
        this.CodePostal = postalCode;
        this.Province = province;
        this.Rue = rue;

    }

    /// <summary>
    /// Constructeur utilisable dans les services
    /// </summary>
    /// <param name="ville">ville de l'adresse</param>
    /// <param name="numerocivique">Le numerique civique de l'adresse</param>
    /// <param name="pays">Le pays ou ce trouve l'adresse</param>
    /// <param name="postalCode">Le code postal de la region de l'adresse</param>
    /// <param name="province">La province ou ce trouve l'adresse</param>
    /// <param name="rue">La rue ou ce trouve l'adresse/param>
    /// <param name="rowversion">Une signature de validation anti-concurence/param>
    protected Adresse(int id, string ville, string numerocivique, 
        string pays, string postalCode, string province, byte[] rowversion, string rue) {

        this.Id = id;
        this.Ville = ville;
        this.NumeroCivique = numerocivique;
        this.Pays = pays;
        this.CodePostal = postalCode;
        this.Province = province;
        this.Rowversion = rowversion;
        this.Rue = rue;

    }

    /// <summary>
    /// Vérifie si la longueur du numero civique d'une adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="numerocivique">Le numero civique de l'adresse a valider</param>
    /// <returns><see langword="true"/> si le nom du numero civique potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderNumeroCivique(string numerocivique) 
    {
        return numerocivique.Length <= MAX_NUMEROCIVIQUE_LENGTH;
    }

    /// <summary>
    /// Vérifie si la longueur du code postal d'une adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="postalCode">Le code postal de l'adresse a potentiel a valider</param>
    /// <returns><see langword="true"/> si le nom du code postal potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderCodePostal(string postalCode) 
    {
        return postalCode.Length <= MAX_CODEPOSTAL_LENGTH;
    }

    /// <summary>
    /// Vérifie si la longueur du pays d'une adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="pays">Le code postal de l'adresse a potentiel a valider</param>
    /// <returns><see langword="true"/> si le nom du code postal potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderPays(string pays) 
    {
        return pays.Length <= MAX_PAYS_LENGTH;
    }

    /// <summary>
    /// Vérifie si la longueur de la privince ou se trouve l'adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="province">La province de l'adresse a potentiel a valider</param>
    /// <returns><see langword="true"/> si le nom de la province de l'adresse potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderProvince( string province) 
    { 
       return province.Length <= MAX_PROVINCE_LENGTH;
    }

    /// <summary>
    /// Vérifie si la longueur du nom rue d'une adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="rue">La rue de l'adresse a potentiel a valider</param>
    /// <returns><see langword="true"/> si le nom de la rue potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderRue(string rue) 
    {
       return rue.Length <= MAX_RUE_LENGTH;
    }

    /// <summary>
    /// Vérifie si la longueur du nom de la ville d'une adresse potentielle (lors de la création/modification d'une adresse) est valide.
    /// </summary>
    /// <param name="ville">La ville de l'adresse a potentiel a valider</param>
    /// <returns><see langword="true"/> si le nom de la ville potentiel est valide, <see langword="false"/> sinon.</returns>
    public static bool ValiderVille(string ville) 
    {
        return ville.Length <= MAX_VILLE_LENGTH;
    }



}
