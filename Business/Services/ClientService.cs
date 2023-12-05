using System;
using System.Collections.Generic;
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
    
    public ClientService(AbstractFacade facade, AbstractContext context) {
        this.dao = new ClientsDAO(context);

    }
    
    public ClientsDTO GetClientId(int clientId) {
        return this.dao.GetById(clientId);
    }

    public ClientsDTO GetClientShipmentOrder(int id) {
        return this.dao.GetClientShipmentOrder(id);
    }

    public ClientsDTO CreateClient(ClientsDTO clients) {
        return this.dao.Create(clients);
    }

    public ClientsDTO DeleteClient(ClientsDTO clients) {
        return this.dao.Delete(clients);
    }
    public ClientsDTO UpdateClient(ClientsDTO clients) {
        return this.dao.Update(clients);
    }


}
