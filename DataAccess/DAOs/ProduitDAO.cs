using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// creation de GetByProductName()
namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ProduitDAO : AbstractDao<Produit, int> {
    protected override AbstractContext Context { get; }

    public ProduitDAO(AbstractContext context) {
        this.Context = context;
    }


}