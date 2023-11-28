using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;

/// <summary>
/// Classe d'accès aux données pour les entités <see cref="Role"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{DtoType, DtoIdType}"/>.
/// </remarks>
public class RoleDAO : AbstractDao<Role, int> {
    protected override AbstractContext Context { get; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte EF Core utilisé par le DAO.</param>
    public RoleDAO(AbstractContext context) { 
        this.Context = context;
    }

    /// <summary>
    /// Retourne le <see cref="Role"/> correspondant à la fonction d'administrateur.
    /// </summary>
    /// <remarks>
    /// Est basé sur l'identifiant spécifique pour les administrateurs défini 
    /// dans <see cref="Role.ADMINISTRATOR_ROLE_ID"/>.
    /// </remarks>
    /// <returns>Le <see cref="Role"/> des administrateurs.</returns>
    /// <exception cref="Exception">Si aucun <see cref="Role"/> avec un ID correspondant 
    /// à <see cref="Role.ADMINISTRATOR_ROLE_ID"/> n'est trouvé.</exception>
    public Role GetAdminRole() {
        return this.GetById(Role.ADMINISTRATOR_ROLE_ID) ?? throw new Exception("Role d'administrateur nonexistant.");
    }


    /// <summary>
    /// Retourne le <see cref="Role"/> correspondant à la fonction d'employé de bureau.
    /// </summary>
    /// <remarks>
    /// Est basé sur l'identifiant spécifique pour les employés de bureau défini 
    /// dans <see cref="Role.OFFICE_EMPLOYEE_ROLE_ID"/>.
    /// </remarks>
    /// <returns>Le <see cref="Role"/> des employés de bureau.</returns>
    /// <exception cref="Exception">Si aucun <see cref="Role"/> avec un ID correspondant 
    /// à <see cref="Role.OFFICE_EMPLOYEE_ROLE_ID"/> n'est trouvé.</exception>
    public Role GetOfficeEmployeeRole() {
        return this.GetById(Role.OFFICE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Role d'employé de bureau nonexistant.");
    }


    /// <summary>
    /// Retourne le <see cref="Role"/> correspondant à la fonction d'employé d'entrepôt.
    /// </summary>
    /// <remarks>
    /// Est basé sur l'identifiant spécifique pour les employés d'entrepôt défini 
    /// dans <see cref="Role.WAREHOUSE_EMPLOYEE_ROLE_ID"/>.
    /// </remarks>
    /// <returns>Le <see cref="Role"/> des employés d'entrepôt.</returns>
    /// <exception cref="Exception">Si aucun <see cref="Role"/> avec un ID correspondant 
    /// à <see cref="Role.WAREHOUSE_EMPLOYEE_ROLE_ID"/> n'est trouvé.</exception>
    public Role GetWarehouseEmployeeRole() {
        return this.GetById(Role.WAREHOUSE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Role d'employe d'entrepôt nonexistant.");
    }

    /// <summary>
    /// Recherche des <see cref="Role"/>s par leur <see cref="Role.RoleName">Nom</see> et 
    /// leur <see cref="Role.RoleDescription">Description</see>.
    /// </summary>
    /// <remarks>
    /// Retourne la liste de <see cref="Role"/> dont les valeurs de <see cref="Role.RoleName"/> 
    /// OU <see cref="Role.RoleDescription"/> commencent par la valeur de <paramref name="userInput"/>.
    /// </remarks>
    /// <param name="userInput"></param>
    /// <returns></returns>
    public List<Role> SearchRole(string userInput) {
        return this.Context.GetDbSet<Role>().Where(
                role => role.RoleName.StartsWith(userInput) 
                || (role.RoleDescription != null && role.RoleDescription.StartsWith(userInput))
            ).ToList();
    }
}
