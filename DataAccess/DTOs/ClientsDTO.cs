using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientsDTO : AbstractDTO<int> {

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



    public virtual Entrepot AsignedWarehouse { get; set; } = null!;
    public virtual Adresse ClientAdress { get; set; } = null!;
    public virtual List<Produit> Produit { get; set; } = new List<Produit>();
    public virtual List<ShipmentOrderDTO> ShipmentOrders { get; set; } = new List<ShipmentOrderDTO>();


    public ClientsDTO() { }

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

    public static bool ValiderNomClient(string nom) {
        return nom.Length <= NAME_MAX_LENGTH;
    }

    public static bool ValiderPrenomClient(string prenom) {
        return prenom.Length <= PRENOM_MAX_LENGTH;
    }

    public static bool ValiderTelephoneClient(long telephone) {
        return telephone <= TELEPHONE_MAX_LENGTH;
    }

    public static bool ValiderEmailClient(string email) {
        return email.Length <= COURRIEL_MAX_LENGTH;
    }

    public static bool ValideCompanyName(string companyName) {
        return companyName.Length <= COMPANYNAME_MAX_LENGTH;
    }
}






