using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Diagnostics;


namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ClientService : AbstractDtoService<ClientsDTO, int> {

    protected override ClientsDAO Dao { get; }
    protected override ClientWindows DtoManagementWindow { get; }

    /// <summary>
    /// Initialisation de l'instance de la clasee ClientService
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public ClientService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ClientsDAO(context);
        this.DtoManagementWindow = new ClientWindows(facade);
    }

    /// <summary>
    /// Recherche du client en fonction du filtre
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<ClientsDTO> SearchClient(string filter) {
        return this.Dao.SearchClients(filter);
    }

    /// <summary>
    /// Recevoir le client selon l'Id
    /// </summary>
    /// <param name="clientId"></param>
    /// <returns></returns>
    public ClientsDTO? GetClientId(int clientId) {
        return this.Dao.GetById(clientId);
    }

    /// <summary>
    /// Recevoir les clients avec ces commandes selon son identifiant
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.Dao.GetClientShipmentOrder(id);
    }

    /// <summary>
    /// Obtient la liste de tout les clients
    /// </summary>
    /// <returns></returns>
    public List<ClientsDTO> GetAllClients() {
        return this.Dao.GetAllClients();
    }

    /// <summary>
    /// <inheritdoc/> 
    /// </summary>
    public override void Shutdown() {
        try {
            if (!this.DtoManagementWindow.IsDisposed) {
                this.DtoManagementWindow.Dispose();
            }
        } catch (Exception ex) {
            Debug.WriteLine("Failed to dispose of DtoManagementWindow on shutdown (possible memory leak): " + ex.Message);
        }
    }
    //public ClientsDTO CreateClient(ClientsDTO clients) {
    //    return this.dao.Create(clients);
    //}

    //public ClientsDTO DeleteClient(ClientsDTO clients) {
    //    return this.dao.Delete(clients);
    //}
    //public ClientsDTO UpdateClient(ClientsDTO clients) {
    //    return this.dao.Update(clients);
    //}


}
