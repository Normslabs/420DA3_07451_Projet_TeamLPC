using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
public class UtilisateursRoles {
    public int UtilisateurId { get; set; }
    public int RoleId { get; set; }
    public virtual Utilisateur Utilisateur { get; set; }
    public virtual Role Role { get; set; }
}
