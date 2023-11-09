using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Role : AbstractDTO<int> {

    public const int ADMINISTRATOR_ROLE_ID = 1;
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;


    public string RoleName { get; set; } = null!;
    public string? RoleDescription { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    public List<Utilisateur> UtplisateursPossedantRole { get; set; } = null!;


    public Role() : base() { }

    public Role(string roleName) : this() {
        this.RoleName = roleName;
    }

    public Role(string roleName, string? roleDescription)
        : this(roleName) {
        this.RoleDescription = roleDescription;
    }

    protected Role(int id, string roleName, string? roleDescription, byte[] rowVersion)
        : this(roleName, roleDescription) {
        this.Id = id;
        this.RowVersion = rowVersion;
    }
}
