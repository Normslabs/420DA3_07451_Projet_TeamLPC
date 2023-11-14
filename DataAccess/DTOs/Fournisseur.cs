using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Fournisseur : AbstractDTO<int> {


    public int AdressId { get; set; }

    public int ContactId { get; set; }

    public List<Product> Products { get; set; }

    public byte RowVersion { get; set; }

    public Adresse SupplierAdresse { get; set; } 

    public Contact SupplierContact { get; set; }

    public string SupplierName { get; set; }


}
