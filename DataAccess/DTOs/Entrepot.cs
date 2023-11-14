using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Entrepot : AbstractDTO<int> {

    public int EntrepotID { get; set; } 
    public string NomEntrepoT { get; set; }
    public Adresse AdresseEntrepot { get; set; }
    public List<Utilisateur> Utilisateur { get; set; }
    public List<ShipmentOrderDTO> ShipmentOrder { get; set; }
    public List<PurchaseOrder> PurchaseOrders { get; set; }
    public List<ClientsDTO> Clients { get; set; }
    public byte[] RowVersion { get; set; } = null!;

}
