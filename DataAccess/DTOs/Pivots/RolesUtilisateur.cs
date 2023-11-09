using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;

/// <summary>
/// Classe pivot pour la relation plusieurs-à-plusieurs entre les entités <see cref="DTOs.Utilisateur"/> et <see cref="DTOs.Role"/>.
/// </summary>
public class RolesUtilisateur {

    public int RoleId { get; set; }
    public int UtilisateurId { get; set; }

    public Role Role { get; set; } = null!;
    public Utilisateur Utilisateur { get; set; } = null!;

}
