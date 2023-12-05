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
public class ClientService: AbstractDtoService<ClientsDTO,int> { 

    protected override ClientsDAO dao { get; }
    protected override ClientWindows ClientDTOManagementWindow {  get; }

    public ClientService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(facade);
        this.dao = new ClientsDAO(context);
        this.ClientDTOManagementWindow = new ClientWindows(facade); 
    }
    
    public ClientsDTO? GetClientId(int clientId) {
        return this.dao.GetById(clientId);
    }

    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.dao.GetClientShipmentOrder(id);
    }

    public override void Shutdown() {
        try {
            if (!this.ClientDTOManagementWindow.IsDisposed) {
                this.ClientDTOManagementWindow.Dispose();
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
