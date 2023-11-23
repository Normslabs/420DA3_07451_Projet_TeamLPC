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



    public override ClientsDTO? GetById(int id) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(user => user.Id == id)
            .Include(user => user.ClientAdress)
            .SingleOrDefault();
    }
    public ClientsDTO? GetClientShipmentOrder(int id) {
        return this.Context.GetDbSet<ClientsDTO>()
            .Where(user => user.Id == id)
            .Include(user => user.ShipmentOrders)
            .SingleOrDefault();
    }


}



