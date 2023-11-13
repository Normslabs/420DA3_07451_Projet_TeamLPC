using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientsDTO {

    public string ID { get; set; } = null!;
    public string? CompagnyName { get; set; } 
    //public string? Adesse {  get; set; }
    //public string? Entrepot { get; set; }
    public string? Name { get; set; }
    public string? Prenom {  get; set; }
    public string? Courriel { get; set; }
    public string? Telephone { get; set; }


    public ClientsDTO() { }

    public ClientsDTO(string iD, string? compagnyName, string? name, string? prenom, string? courriel, string? telephone) {
        this.ID = iD;
        this.CompagnyName = compagnyName;
        this.Name = name;
        this.Prenom = prenom;
        this.Courriel = courriel;
        this.Telephone = telephone;
    }
}
