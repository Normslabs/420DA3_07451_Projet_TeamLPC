using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;


namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ClientService : AbstractDtoService<ClientsDTO, int> {

    protected override ClientsDAO Dao { get; }
    protected override ClientWindows DtoManagementWindow { get; }

    public ClientService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(facade);
        this.Dao = new ClientsDAO(context);
        this.DtoManagementWindow = new ClientWindows(facade);
    }
    public List<ClientsDTO> SearchClient(string filter) {
        return this.Dao.SearchClients(filter);
    }
    public ClientsDTO? GetClientId(int clientId) {
        return this.Dao.GetById(clientId);
    }

    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.Dao.GetClientShipmentOrder(id);
    }

    public List<ClientsDTO> GetAllClients() {
        return this.Dao.GetAllClients();
    }

    public override void Shutdown() {
        try {
            if (!this.DtoManagementWindow.IsDisposed) {
                this.DtoManagementWindow.Dispose();
            }
        } catch(Exception ex) {
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
