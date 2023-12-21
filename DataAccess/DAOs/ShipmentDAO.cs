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

/// <summary>
/// Classe representant le data access du shipment
/// </summary>
public class ShipmentDAO : AbstractDao<ShipmentDTO, int> {

    /// <summary>
    /// Déclaration du abstract
    /// </summary>
    protected override AbstractContext Context { get; }


    /// <summary>
    /// Constructeur du AbstractContext
    /// </summary>
    /// <param name="context"></param>
    public ShipmentDAO(AbstractContext context) {
        this.Context = context;
    }


    /// <summary>
    /// Constructeur pour le GetById
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public override ShipmentDTO? GetById(int identifier) {
        return this.Context.GetDbSet<ShipmentDTO>()
            .Where(user => user.Id == identifier)
            .Include(user => user.ShippingOrder)
            .SingleOrDefault();
    }


    /// <summary>
    /// Consctructeur pour la recherche filtré
    /// </summary>
    /// <param name="Filter"></param>
    /// <returns></returns>
    public List<ShipmentDTO> SearchShipment(string Filter) {
        return this.Context.GetDbSet<ShipmentDTO>()
            .Where(shipment => shipment.Id.ToString().StartsWith(Filter) || (shipment.TrackingNumber != null && shipment.TrackingNumber.StartsWith(Filter)))
            .ToList();
       
    }



  

}
