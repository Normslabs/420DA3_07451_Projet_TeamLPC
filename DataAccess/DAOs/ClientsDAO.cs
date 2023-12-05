using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
 public class ClientsDAO : AbstractDao<ClientsDTO, int> {

    protected override AbstractContext Context { get; }

    public ClientsDAO(AbstractContext context) {
        this.Context = context;
    }

    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(user => user.Id == id)
            .Include(user => user.ShipmentOrders)
            .SingleOrDefault();
    }

    public ClientsDTO? GetClientById(int clientId) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(client => client.Id == clientId)
            .Include(client => client.ClientAdress)
            .Include(client => client.ShipmentOrders)
            .Include(client => client.Produit)
            .SingleOrDefault();
    }

    public List<ClientsDTO> GetAllClients() {
        return this.Context.GetDbSet<ClientsDTO>()
            .Include(client => client.ClientAdress)
            .Include(client => client.ShipmentOrders)
            .Include(client => client.Produit)
            .ToList();
    }

}



