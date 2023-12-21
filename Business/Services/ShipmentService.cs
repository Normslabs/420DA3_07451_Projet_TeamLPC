using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Classe de service pour le shipment 
/// </summary>
public class ShipmentService : AbstractDtoService<ShipmentDTO, int> {


    /// <summary>
    /// Declaration du window ainsi que du data access
    /// </summary>
    protected override ShipmentWindow DtoManagementWindow { get; }

    protected override ShipmentDAO Dao { get; }


    /// <summary>
    /// declaration de la fonction pour fermer le management window
    /// </summary>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    /// <summary>
    /// Déclaration du constructeur de la facade dans le service
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public ShipmentService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ShipmentDAO(context);
        this.DtoManagementWindow = new ShipmentWindow(facade);
    }


    /// <summary>
    /// Déclaration de la fonction retournant le shipment par le Id
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public ShipmentDTO? GetShipmentById(int identifier) {
        return this.Dao.GetById(identifier);
    }

    /// <summary>
    /// Déclaration de la liste permettant de rechercher un shipment en particulier
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<ShipmentDTO> SearchShipment(string filter) {
        return this.Dao.SearchShipment(filter);
    }

}
