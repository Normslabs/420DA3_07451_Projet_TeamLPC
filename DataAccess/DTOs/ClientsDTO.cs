using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientsDTO : AbstractDTO<int> {
    /// <summary>
    /// Declaration des propriete
    /// </summary>
    public const int NAME_MAX_LENGTH = 24;
    public const int PRENOM_MAX_LENGTH = 24;
    public const int COURRIEL_MAX_LENGTH = 128;
    public const int TELEPHONE_MAX_LENGTH = 10;
    public const int COMPANYNAME_MAX_LENGTH = 50;
 
    public int AsignedWarehouseID { get; set; }
    public int ClientAdressId { get; set; }
    public string CompanyName { get; set; } = null!;
    public byte[] RowVersion { get; set; } = null!;

    public string Nom {  get; set; } = null!;
    public string Prenom { get; set; } = null!;
    public string Courriel { get; set; } = null!;
    public long Telephone { get; set; }

    /// <summary>
    /// Propriete d'autre classe 
    /// </summary>

    public virtual Entrepot AsignedWarehouse { get; set; } = null!;
    public virtual Adresse ClientAdress { get; set; } = null!;
    public virtual List<Produit> Produit { get; set; } = new List<Produit>();
    public virtual List<ShipmentOrderDTO> ShipmentOrders { get; set; } = new List<ShipmentOrderDTO>();

    /// <summary>
    /// Constructeur vide pour Entity Framework
    /// </summary>
    public ClientsDTO() { }

    /// <summary>
    /// Constructeur avec des parametres pour initialiser les instance de ClientDTO
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="asignedWarehouseID"></param>
    /// <param name="clientAdressId"></param>
    /// <param name="companyName"></param>
    /// <param name="rowVersion"></param>
    /// <param name="nom"></param>
    /// <param name="prenom"></param>
    /// <param name="courriel"></param>
    /// <param name="telephone"></param>
   public ClientsDTO(int Id, int asignedWarehouseID, int clientAdressId, string companyName, byte[] rowVersion,  string nom, string prenom, string courriel, int telephone) {
        this.Id = Id;
        this.AsignedWarehouseID = asignedWarehouseID;
        this.ClientAdressId = clientAdressId;
        this.CompanyName = companyName;
        this.RowVersion = rowVersion;
        this.Nom = nom;
        this.Prenom = prenom;
        this.Courriel = courriel;
        this.Telephone = telephone;
    }
    /// <summary>
    /// Validation de la longueur du Nom Client
    /// </summary>
    /// <param name="nom"></param>
    /// <returns></returns>
    public static bool ValiderNomClient(string nom) {
        return nom.Length <= NAME_MAX_LENGTH;
    }
    /// <summary>
    /// Validation de la longueur du Prenom Client
    /// </summary>
    /// <param name="prenom"></param>
    /// <returns></returns>
    public static bool ValiderPrenomClient(string prenom) {
        return prenom.Length <= PRENOM_MAX_LENGTH;
    }
    /// <summary>
    /// Validation de la longueur du Telephone Client
    /// </summary>
    /// <param name="telephone"></param>
    /// <returns></returns>
    public static bool ValiderTelephoneClient(long telephone) {
        return telephone <= TELEPHONE_MAX_LENGTH;
    }
    /// <summary>
    /// Validation de la longueur du Courriel Client
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool ValiderEmailClient(string email) {
        return email.Length <= COURRIEL_MAX_LENGTH;
    }
    /// <summary>
    /// Validation de la longueur du nom de la compagnie Client
    /// </summary>
    /// <param name="companyName"></param>
    /// <returns></returns>
    public static bool ValideCompanyName(string companyName) {
        return companyName.Length <= COMPANYNAME_MAX_LENGTH;
    }
}






