using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
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

    protected override AbstractContext Context { get; }

    public PurchaseOrderDAO(AbstractContext context) {
        this.Context = context;
    }




}
