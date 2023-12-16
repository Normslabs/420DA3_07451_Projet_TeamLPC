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
    private AdminFacade facade;

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

    private void QuitButton_Click(object sender, EventArgs e) {
        this.facade.ExitApplication();
    }
}
