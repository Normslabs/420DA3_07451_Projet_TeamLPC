using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientsDTO : AbstractDTO<int> {
    public Entrepot AsignedWarehouse { get; set; } = null!;
 
    public int  AsignedWarehouseID  { get; set; }

    public Adresse ClientAdress { get; set; } = null!;

    public int ClientAdressId { get; set; }

    public string CompanyName { get; set; } = null!;

    public List<Produit> Produit { get; set; } = null!;

    public byte[] RowVersion { get; set; } = null!;
  
    public List<ShipmentOrderDTO> ShipmentOrders { get; set; } = null!;

    public string Nom {  get; set; } = null!;
    public string Prenom { get; set; } = null!;

    public string Courriel { get; set; } = null!;
    public long Telephone { get; set; }


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
}






