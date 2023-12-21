using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;


/// <summary>
/// Classe represantant un fournisseur
/// </summary>
public class Fournisseur : AbstractDTO<int> {


    /// <summary>
    /// Déclaration des mes constantes de validation pour le appDbContext
    /// </summary>
    public const int PRENOMCONTACT_MAX_LENGHT = 20;
    public const int NOMCONTACT_MAX_LENGHT = 20;
    public const int SUPPLIER_NAME_MAXLENGHT = 100;
    public const int TELEPHONECONTACT_MAX_LENGHT = 24;
    public const int EMAILCONTACT_MAX_LENGHT = 128;



    /// <summary>
    /// Déclaration de mes champs
    /// </summary>

    public string SupplierName { get; set; } = null!;
    public int AdresseId { get; set; }
    public string PrenomContact { get; set; } = null!;
    public string NomContact { get; set; } = null!;
    public string TelephoneContact { get; set; } = null!;
    public string EmailContact { get; set; } = null!;
    public byte[] RowVersion { get; set; } = null!;


    /// <summary>
    /// Déclaration des propriétés de navigation
    /// </summary>

    public virtual Adresse SupplierAdresse { get; set; } = null!;
    public virtual List<Produit> ProduitsFournis { get; set; } = new List<Produit>();




    #region Constructeur

    /// <summary>
    /// Constructeur par defaut
    /// </summary>
    public Fournisseur() : base() {

    }


    /// <summary>
    /// Constructeur manuel
    /// </summary>
    /// <param name="AdresseId"></param>
    /// <param name="PrenomContact"></param>
    /// <param name="NomContact"></param>
    /// <param name="AdresseContact"></param>
    /// <param name="EmailContact"></param>
    /// <param name="SupplierName"></param>
    public Fournisseur(int AdresseId, string PrenomContact, string NomContact, string telephoneContact, string EmailContact, string SupplierName) {
        this.AdresseId = AdresseId;
        this.PrenomContact = PrenomContact;
        this.NomContact = NomContact;
        this.TelephoneContact = telephoneContact;
        this.EmailContact = EmailContact;
        this.SupplierName = SupplierName;

    }

    /// <summary>
    /// Constructeur EF core
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="AdresseId"></param>
    /// <param name="PrenomContact"></param>
    /// <param name="NomContact"></param>
    /// <param name="AdresseContact"></param>
    /// <param name="EmailContact"></param>
    /// <param name="RowVersion"></param>
    /// <param name="SupplierName"></param>
    protected Fournisseur(int Id, int AdresseId, string PrenomContact, string NomContact, string telephoneContact, string EmailContact, byte[] RowVersion, string SupplierName) {
        this.Id = Id;
        this.AdresseId = AdresseId;
        this.PrenomContact = PrenomContact;
        this.NomContact = NomContact;
        this.TelephoneContact = telephoneContact;
        this.EmailContact = EmailContact;
        this.RowVersion = RowVersion;
        this.SupplierName = SupplierName;
    }

    #endregion

    public override string ToString() {
        return this.Id.ToString() + " - " + this.SupplierName;
    }

}
