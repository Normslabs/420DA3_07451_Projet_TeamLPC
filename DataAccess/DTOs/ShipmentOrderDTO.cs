using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipmentOrderDTO : AbstractDTO<int> {

    /// <summary>
    /// Declaration des propriete
    /// </summary>
    public const int ADRESSCIVIQUE_MAX_LENGHT = 48;
    public const int CONCTACT_MAX_LENGHT = 48;
    public const int CODEPOSTAL_MAX_LENGHT = 7;

    public ClientsDTO Clients { get; set; } = null!;

    public int ClientsId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateShipped { get; set; }

    public string DestinationCivicAdress { get; set; } = null!;

    public string DestinationContact { get; set; } = null!;

    public string DestinationPostalCode { get; set; } = null!;

    public Entrepot EntrepotOriginal { get; set; } = null!;

    public int EntrepotOriginalId { get; set; }

    public List<ShippingOrderProducts> AssociationsProduits { get; set; } = new List<ShippingOrderProducts>();

    public byte[] RowVersion { get; set; }

    public ShipmentDTO? Shipment { get; set; } = null!;
    public int? ShipmentId { get; set; }
    public ShippingOrderStatusEnum Status { get; set; }

    public Utilisateur? EmployeEntrepot { get; set; } = null!;

    public int? EmployeEntrepotId { get; set; }

    /// <summary>
    /// Declaration du Constructeur vide pour EntityFramework
    /// </summary>
    public ShipmentOrderDTO() { }
    /// <summary>
    /// Constructeur avec les parametre pour initialiser une instance de ShipmentOrderDTO
    /// </summary>
    /// <param name="id"></param>
    /// <param name="status"></param>
    /// <param name="destinationContact"></param>
    /// <param name="destinationCivicAdress"></param>
    /// <param name="destinationPostalCode"></param>
    /// <param name="clientId"></param>
    /// <param name="entrepotOriginalId"></param>
    /// <param name="employeEntrepotId"></param>
    /// <param name="shipmentId"></param>
    /// <param name="dateCreated"></param>
    /// <param name="dateShipped"></param>
    /// <param name="RowVersion"></param>
    public ShipmentOrderDTO(int id, ShippingOrderStatusEnum status, string destinationContact, string destinationCivicAdress, string destinationPostalCode, int clientId, int entrepotOriginalId, int? employeEntrepotId, int? shipmentId, DateTime dateCreated, DateTime? dateShipped, byte[] RowVersion) {
        this.Id = id;
        this.Status = status;
        this.DestinationContact = destinationContact;
        this.DestinationCivicAdress = destinationCivicAdress;
        this.DestinationPostalCode = destinationPostalCode;
        this.ClientsId = clientId;
        this.EntrepotOriginalId = entrepotOriginalId;
        this.EmployeEntrepotId = employeEntrepotId;
        this.ShipmentId = shipmentId;
        this.DateCreated = dateCreated;
        this.DateShipped = dateShipped;
        this.RowVersion = RowVersion;
    }
    /// <summary>
    /// Autre Constructeur
    /// </summary>
    /// <param name="destinationContact"></param>
    /// <param name="destinationCivicAdress"></param>
    /// <param name="destinationPostalCode"></param>
    /// <param name="clientId"></param>
    /// <param name="entrepotOriginalId"></param>
    public ShipmentOrderDTO(string destinationContact, string destinationCivicAdress, string destinationPostalCode, int clientId, int entrepotOriginalId) {
        this.DestinationContact = destinationContact;
        this.DestinationCivicAdress= destinationCivicAdress;
        this.DestinationPostalCode = destinationPostalCode;
        this.ClientsId = clientId;
        this.EntrepotOriginalId= entrepotOriginalId;
    }

    /// <summary>
    /// Retourne une représentation sous forme de chaine de la commande d'expedition
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return
               "ID: " + this.Id.ToString() + " " +
               "Client ID: " + this.ClientsId.ToString() + " " +
               "Entrepot Original ID " + this.EntrepotOriginalId.ToString() + " " +
               "Employe Entrepot ID: " + this.EmployeEntrepotId.ToString() + " " +
               "Shipment ID: " + this.ShipmentId.ToString() + " " +
               "Status: " + this.Status.ToString() + " " +
               "Date Created: " + this.DateCreated.ToString() + " " +
               "Date Shipped: " + this.DateShipped.ToString() + " " +
               "Row Version: " + BitConverter.ToString(this.RowVersion);

}
    /// <summary>
    /// Fait en sorte que commande soit considere comme complétée.
    /// </summary>
    public void SetCompleted() {
        this.Status = ShippingOrderStatusEnum.COMPLETED;
    }
    /// <summary>
    ///Fait en sorte que commande soit considere comme emballer. 
    /// </summary>
    public void SetPackaged() {
        this.Status = ShippingOrderStatusEnum.PACKAGED;
    }
    /// <summary>
    /// Asigner la commande a un employe d'entrepot
    /// </summary>
    /// <param name="employee"></param>
    public void AssignToWarehouseEmployee(Utilisateur employee) {
        this.EmployeEntrepot = employee;
        this.EmployeEntrepot.Id = employee.Id;
    }

    /// <summary>
    /// Retourner l'adresse de l'entrepot associer a la commande
    /// </summary>
    /// <returns></returns>
    public Adresse GetOriginAdress() {
        return this.EntrepotOriginal.AdresseEntrepot;
    }

    /// <summary>
    /// Validation pour la longueur de l'adresse civique
    /// </summary>
    /// <param name="adressecivique"></param>
    /// <returns></returns>
    public static bool ValiderAdresseCivique(string adressecivique) {
        return adressecivique.Length <= ADRESSCIVIQUE_MAX_LENGHT;
    }
    /// <summary>
    /// Validation pour la longueur du contact destinataire
    /// </summary>
    /// <param name="contactdestinataire"></param>
    /// <returns></returns>
    public static bool ValiderContactDestinataire(string contactdestinataire) {
        return contactdestinataire.Length <= CONCTACT_MAX_LENGHT;
    }
    /// <summary>
    /// Validation de la longueur du codepostal
    /// </summary>
    /// <param name="codepostal"></param>
    /// <returns></returns>
    public static bool ValidervCodePostal(string codepostal) {
        return codepostal.Length <= CODEPOSTAL_MAX_LENGHT;
    }


}
