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

/*
PurchaseOrder:
GetIncompleteForWarehouse(intIdEntrepot OU objEntrepot) 
-> retrourne les purchase orders ou le statut n'Est pas 'completed' et ou l'entrepot de destination = valeur passée
*/
public class PurchaseOrderDAO : AbstractDao<PurchaseOrder, int> {
    /// <summary>
    /// Constructeur de AbstractContext
    /// </summary>
    protected override AbstractContext Context { get; }
    /// <summary>
    /// Constructeur de PurchaseOrderDAO
    /// </summary>
    /// <param name="context"></param>
    public PurchaseOrderDAO(AbstractContext context) {
        this.Context = context;
    }
    /// <summary>
    /// Methode pour retourner 
    /// </summary>
    /// <param name="IdEntrepot"></param>
    /// <returns></returns>
    public PurchaseOrder GetIncompleteForWarehouse(int IdEntrepot) {
        return this.Context.GetDbSet<PurchaseOrder>()
            .Where(po => po.Status != PurchaseOrderStatusEnum.Completed && po.DestinationWarehouseID == IdEntrepot )
            .First();
    }

    //ajouter au service
    public List<PurchaseOrder> SearchByProductName(string ProductName) {
        return this.Context.GetDbSet<PurchaseOrder>()
            .Include(po => po.Product)
            .Where(po => po.Product != null && po.Product.Name != null && po.Product.Name.StartsWith(ProductName))
            .ToList();
    }



}
