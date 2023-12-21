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

    /// <summary>
    /// Obtient le contexte de la base de donne
    /// </summary>
    /// <param name="context"></param>
    protected override AbstractContext Context { get; }

    /// <summary>
    /// Initialisation du contexte dans la classe ClientDAO
    /// </summary>
    /// <param name="context"></param>
    public ClientsDAO(AbstractContext context) {
        this.Context = context;
    }
    /// <summary>
    /// Obtien le client avec ses ShipmentOrders selon l'identifiant
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(user => user.Id == id)
            .Include(user => user.ShipmentOrders)
            .SingleOrDefault();
    }
    /// <summary>
    /// Un fonction qui me retourne tout les clients avec leurs adresse , leur shipmentOrders et leurs produits
    /// </summary>
    /// <returns></returns>
    public List<ClientsDTO> GetAllClients() {
        return this.Context.GetDbSet<ClientsDTO>()
            .Include(client => client.ClientAdress)
            .Include(client => client.ShipmentOrders)
            .Include(client => client.Produit)
            .ToList();
    }

    /// <summary>
    /// Fonction qui recherche le client selon le filtre 
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<ClientsDTO> SearchClients(string filter) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(client => client.Id.ToString()
            .StartsWith(filter) || client.Nom.StartsWith(filter))
            .ToList();

    }
}



