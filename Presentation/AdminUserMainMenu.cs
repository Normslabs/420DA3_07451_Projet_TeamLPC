using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_07451_Projet_Initial.Presentation;
internal partial class AdminUserMainMenu : Form {
    private readonly AdminFacade facade;

    public AdminUserMainMenu(AdminFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.ReloadUserCombobox();
    }


    #region Section Utilisateurs

    private void ReloadUserCombobox() {
        Utilisateur? selectedUser = null;
        if (this.userSelector.SelectedItem != null) {
            selectedUser = (Utilisateur) this.userSelector.SelectedItem;
        }
        this.userSelector.Items.Clear();
        List<Utilisateur> utilisateurs = this.facade.GetService<UtilisateurService>().GetAllUtilisateurs();
        foreach (Utilisateur user in utilisateurs) {
            _ = this.userSelector.Items.Add(user);
        }
        if (this.userSelector.Items.Contains(selectedUser)) {
            this.userSelector.SelectedItem = selectedUser;
        }
    }

    private void ActivateUserManagementButtons() {
        this.viewUserButton.Enabled = true;
        this.editUserButton.Enabled = true;
        this.deleteUserButton.Enabled = true;
    }

    private void DeactivateUserManagementButtons() {
        this.viewUserButton.Enabled = false;
        this.editUserButton.Enabled = false;
        this.deleteUserButton.Enabled = false;
    }

    private void CreateUserButton_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<UtilisateurService>().CreateNewDtoInstance();
        this.ReloadUserCombobox();
    }

    private void UserSelector_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.userSelector.SelectedItem != null) {
            this.ActivateUserManagementButtons();
        } else {
            this.DeactivateUserManagementButtons();
        }
    }

    private void ViewUserButton_Click(object sender, EventArgs e) {
        if (this.userSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'utilisateur sélectionné.");
        } else {
            Utilisateur selectedUser = (Utilisateur) this.userSelector.SelectedItem;
            _ = this.facade.GetService<UtilisateurService>().DisplayDtoInstance(selectedUser);
        }
    }

    private void EditUserButton_Click(object sender, EventArgs e) {
        if (this.userSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'utilisateur sélectionné.");
        } else {
            Utilisateur selectedUser = (Utilisateur) this.userSelector.SelectedItem;
            _ = this.facade.GetService<UtilisateurService>().UpdateDtoInstance(selectedUser);
            this.ReloadUserCombobox();
        }
    }

    private void DeleteUserButton_Click(object sender, EventArgs e) {
        if (this.userSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'utilisateur sélectionné.");
        } else {
            Utilisateur selectedUser = (Utilisateur) this.userSelector.SelectedItem;
            _ = this.facade.GetService<UtilisateurService>().DeleteDtoInstance(selectedUser);
            this.ReloadUserCombobox();
        }
    }

    #endregion


    #region Section Roles

    private void ReloadRolesCombobox() {
        Role? selectedRole = null;
        if (this.roleSelector.SelectedItem != null) {
            selectedRole = (Role) this.roleSelector.SelectedItem;
        }
        this.roleSelector.Items.Clear();
        List<Role> roles = this.facade.GetService<RoleService>().GetAllRoles();
        foreach (Role role in roles) {
            _ = this.roleSelector.Items.Add(role);
        }
        if (this.roleSelector.Items.Contains(selectedRole)) {
            this.roleSelector.SelectedItem = selectedRole;
        }
    }

    private void ActivateRoleManagementButtons() {
        this.roleViewButton.Enabled = true;
        this.editRoleButton.Enabled = true;
        this.deleteRoleButton.Enabled = true;
    }

    private void DeactivateRoleManagementButtons() {
        this.roleViewButton.Enabled = false;
        this.editRoleButton.Enabled = false;
        this.deleteRoleButton.Enabled = false;
    }

    private void CreateRoleButton_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<RoleService>().CreateNewDtoInstance();
        this.ReloadRolesCombobox();
    }

    private void RoleSelector_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.roleSelector.SelectedItem != null) {
            this.ActivateRoleManagementButtons();
        } else {
            this.DeactivateRoleManagementButtons();
        }

    }

    private void RoleViewButton_Click(object sender, EventArgs e) {
        if (this.roleSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas de role sélectionné.");
        } else {
            Role selectedRole = (Role) this.roleSelector.SelectedItem;
            _ = this.facade.GetService<RoleService>().DisplayDtoInstance(selectedRole);
        }
    }

    private void EditRoleButton_Click(object sender, EventArgs e) {
        if (this.roleSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas de role sélectionné.");
        } else {
            Role selectedRole = (Role) this.roleSelector.SelectedItem;
            _ = this.facade.GetService<RoleService>().UpdateDtoInstance(selectedRole);
            this.ReloadRolesCombobox();
        }
    }

    private void DeleteRoleButton_Click(object sender, EventArgs e) {
        if (this.roleSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas de role sélectionné.");
        } else {
            Role selectedRole = (Role) this.roleSelector.SelectedItem;
            _ = this.facade.GetService<RoleService>().DeleteDtoInstance(selectedRole);
            this.ReloadRolesCombobox();
        }
    }

    #endregion


    // TODO: @Everyone ajoutez vos propres sections ici

    #region Shipment
    private void ShipmentFiltreTextbox_TextChanged(object sender, EventArgs e) {
        this.ShipmentListBox.DataSource = this.facade.GetService<ShipmentService>().SearchShipment(this.ShipmentFiltreTextbox.Text);
    }

    private void ShipmentListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.ShipmentListBox.SelectedItem != null) {
            this.ShipmentCreateBtn.Enabled = true;
            this.ShipmentViewBtn.Enabled = true;
        } else {
            this.ShipmentCreateBtn.Enabled = true;
            this.ShipmentViewBtn.Enabled = false;
        }
    }

    private void ShipmentCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ShipmentService>().CreateNewDtoInstance();
    }

    private void ShipmentViewBtn_Click(object sender, EventArgs e) {
        if (this.ShipmentListBox != null) {
            ShipmentDTO selectedShipment = (ShipmentDTO) this.ShipmentListBox.SelectedItem;
            _ = this.facade.GetService<ShipmentService>().DisplayDtoInstance(selectedShipment);
        } else {
            _ = MessageBox.Show("Pas de shipment sélectionné");
        }


    }


    #endregion


    #region Fournisseur


    private void FournisseurFiltreTextBox_TextChanged(object sender, EventArgs e) {
        this.FournisseurListBox.DataSource = this.facade.GetService<FournisseurService>().SearchFournisseur(this.FournisseurFiltreTextBox.Text);
    }

    private void FournisseurListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.FournisseurListBox != null) {
            this.FournisseurCreateBtn.Enabled = true;
            this.FournisseurEditBtn.Enabled = true;
            this.FournisseurViewBtn.Enabled = true;
            this.FournisseurDeleteBtn.Enabled = true;
        } else {
            this.FournisseurCreateBtn.Enabled = true;
            this.FournisseurEditBtn.Enabled = false;
            this.FournisseurViewBtn.Enabled = false;
            this.FournisseurDeleteBtn.Enabled = false;
        }
    }

    private void FournisseurCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<FournisseurService>().CreateNewDtoInstance();
    }

    private void FournisseurViewBtn_Click(object sender, EventArgs e) {
        if (this.FournisseurListBox != null) {
            Fournisseur selectedFournisseur = (Fournisseur) this.FournisseurListBox.SelectedItem;
            _ = this.facade.GetService<FournisseurService>().DisplayDtoInstance(selectedFournisseur);
        } else {
            _ = MessageBox.Show("Pas de fournisseur sélectionné");
        }
    }

    private void FournisseurEditBtn_Click(object sender, EventArgs e) {
        if (this.FournisseurListBox != null) {
            Fournisseur selectedFournisseur = (Fournisseur) this.FournisseurListBox.SelectedItem;
            _ = this.facade.GetService<FournisseurService>().UpdateDtoInstance(selectedFournisseur);
        } else {
            _ = MessageBox.Show("Pas de fournisseur sélectionné");
        }
    }

    private void FournisseurDeleteBtn_Click(object sender, EventArgs e) {
        if (this.FournisseurListBox != null) {
            Fournisseur selectedFournisseur = (Fournisseur) this.FournisseurListBox.SelectedItem;
            _ = this.facade.GetService<FournisseurService>().DeleteDtoInstance(selectedFournisseur);
        } else {
            _ = MessageBox.Show("Pas de fournisseur sélectionné");
        }
    }


    #endregion 

    private void QuitButton_Click(object sender, EventArgs e) {
        this.facade.ExitApplication();
    }




}
