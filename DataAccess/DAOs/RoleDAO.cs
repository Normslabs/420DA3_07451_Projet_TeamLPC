using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class RoleDAO : AbstractDao<Role, int> {
    protected override AbstractContext Context { get; }

    public RoleDAO(AbstractContext context) { 
        this.Context = context;
    }

    public Role GetAdminRole() {
        return this.GetById(Role.ADMINISTRATOR_ROLE_ID) ?? throw new Exception("Role d'administrateur nonexistant.");
    }

    public Role GetOfficeEmployeeRole() {
        return this.GetById(Role.OFFICE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Role d'employé de bureau nonexistant.");
    }

    public Role GetWarehouseEmployeeRole() {
        return this.GetById(Role.WAREHOUSE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Role d'employe d'entrepôt nonexistant.");
    }

    public List<Role> SearchRole(string userInput) {
        return this.Context.GetDbSet<Role>().Where(
                role => role.RoleName.StartsWith(userInput) 
                || (role.RoleDescription != null && role.RoleDescription.StartsWith(userInput))
            ).ToList();
    }
}
