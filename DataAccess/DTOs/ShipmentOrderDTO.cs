using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipmentOrderDTO : AbstractDTO<int> {
    public const int ADRESSCIVIQUE_MAX_LENGHT = 48;
    public const int CONCTACT_MAX_LENGHT = 48;
    public const int CODEPOSTAL_MAX_LENGHT = 7;


    public ShippingOrderStatusEnum Status { get; set; }
    public int ClientsId { get; set; }
    public int EntrepotOriginalId { get; set; }
    public int? EmployeEntrepotId { get; set; }
    public int? ShipmentId { get; set; }
    public string DestinationCivicAdress { get; set; } = null!;
    public string DestinationContact { get; set; } = null!;
    public string DestinationPostalCode { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateShipped { get; set; }
    public byte[] RowVersion { get; set; }


    public virtual ClientsDTO Clients { get; set; } = null!;
    public virtual Entrepot EntrepotOriginal { get; set; } = null!;
    public virtual ShipmentDTO? Shipment { get; set; } = null!;
    public virtual Utilisateur? EmployeEntrepot { get; set; } = null!;
    public virtual List<ShippingOrderProducts> AssociationsProduits { get; set; } = new List<ShippingOrderProducts>();


    public ShipmentOrderDTO() { }

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
    public ShipmentOrderDTO(string destinationContact, string destinationCivicAdress, string destinationPostalCode, int clientId, int entrepotOriginalId) {
        this.DestinationContact = destinationContact;
        this.DestinationCivicAdress= destinationCivicAdress;
        this.DestinationPostalCode = destinationPostalCode;
        this.ClientsId = clientId;
        this.EntrepotOriginalId= entrepotOriginalId;
    }


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

    public void SetCompleted() {
        this.Status = ShippingOrderStatusEnum.COMPLETED;
    }

    public void SetPackaged() {
        this.Status = ShippingOrderStatusEnum.PACKAGED;
    }

    public void AssignToWarehouseEmployee(Utilisateur employee) {
        this.EmployeEntrepot = employee;
        this.EmployeEntrepot.Id = employee.Id;
    }

    public Adresse GetOriginAdress() {
        return this.EntrepotOriginal.AdresseEntrepot;
    }

    public static bool ValiderAdresseCivique(string adressecivique) {
        return adressecivique.Length <= ADRESSCIVIQUE_MAX_LENGHT;
    }

    public static bool ValiderContactDestinataire(string contactdestinataire) {
        return contactdestinataire.Length <= CONCTACT_MAX_LENGHT;
    }

    public static bool ValidervCodePostal(string codepostal) {
        return codepostal.Length <= CODEPOSTAL_MAX_LENGHT;
    }


}
