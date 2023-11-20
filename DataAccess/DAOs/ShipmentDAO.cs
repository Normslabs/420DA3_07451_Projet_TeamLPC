using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ShipmentDAO : AbstractDao<ShipmentDTO, int> {


    protected override AbstractContext Context { get; }

    public ShipmentDAO(AbstractContext context) {
        this.Context = context;
    }

    public override ShipmentDTO? GetById(int identifier) {
        return this.Context.GetDbSet<ShipmentDTO>()
            .Where(user => user.Id == identifier)
            .Include(user => user.ShippingOrderID)
            .Include(user => user.Service)
            .Include(user => user.TrackingNumber)
            .SingleOrDefault();
    }

    public override List<ShipmentDTO> GetAll() {
        return this.Context.GetDbSet<ShipmentDTO>()
            .Include(user => user.ShippingOrderID)
            .ToList();
    }

  

}
