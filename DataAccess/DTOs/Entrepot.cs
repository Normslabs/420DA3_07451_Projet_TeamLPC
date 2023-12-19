using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Entrepot : AbstractDTO<int> {

    public const int MAX_NOMENTREPOT_LENGTH = 25;
   

    public string NomEntrepot { get; set; } = null!;
    public Adresse AdresseEntrepot { get; set; } = null!;
    public List<Utilisateur> Utilisateur { get; set; } = null!;
    public List<ShipmentOrderDTO> ShipmentOrder { get; set; } = null!;
    public List<PurchaseOrder> PurchaseOrders { get; set; } = null!;
    public List<ClientsDTO> Clients { get; set; } = null!;
    public byte[] RowVersion { get; set; } = null!;


    public Entrepot() { }

    public Entrepot(string nomEntrepot) { 
    this.NomEntrepot = nomEntrepot;
    
    }


    protected Entrepot(int id, string nomEntrepot, Adresse adresseEntrepot, List<Utilisateur> utilisateur, List<ShipmentOrderDTO> shipmentOrder, 
        List<PurchaseOrder> purchaseOrder, List<ClientsDTO> clients, byte[] rowversion  ) {
       
        this.Id = id;
        this.NomEntrepot = nomEntrepot;
        this.AdresseEntrepot = adresseEntrepot;
        this.Utilisateur = utilisateur;
        this.ShipmentOrder = shipmentOrder;
        this.PurchaseOrders = purchaseOrder;
        this.Clients = clients;
        this.RowVersion = rowversion;

    }

    public static bool ValiderNomEntrepot(string nomEntrepot) 
    {
        return nomEntrepot.Length <= MAX_NOMENTREPOT_LENGTH;
    }

}
