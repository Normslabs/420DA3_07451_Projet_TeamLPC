using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Adresse : AbstractDTO<int> {
  
    public Fournisseur? AdresseFournisseur { get; set; } = null!;
    public Entrepot? AdresseEntrepot { get; set; } = null!;
    public  string Ville { get; set; } = null!;
    public  string NumeroCivique { get; set; } = null!;
    public ClientsDTO? Client { get; set; } = null!;
    public string Pays { get; set; } = null!;
    public string CodePostal { get; set; } = null!;
    public string Province { get; set; } = null!;
    public byte[] Rowversion { get; set; } = null!;
    public string Rue { get; set; } = null!;



    public Adresse( string ville, string numerocivique,
        string pays, string postalCode, string province, string rue) {
     
        this.Ville = ville;
        this.NumeroCivique = numerocivique;
        this.Pays = pays;
        this.CodePostal = postalCode;
        this.Province = province;
        this.Rue = rue;

    }

    protected Adresse(int id, string ville, string numerocivique, 
        string pays, string postalCode, string province, byte[] rowversion, string rue) {

        this.Id = id;
        this.Ville = ville;
        this.NumeroCivique = numerocivique;
        this.Pays = pays;
        this.CodePostal = postalCode;
        this.Province = province;
        this.Rowversion = rowversion;
        this.Rue = rue;

    }



}
