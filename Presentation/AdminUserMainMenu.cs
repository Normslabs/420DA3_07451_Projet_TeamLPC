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
        this.ReloadEntrepotComboBox();
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

    #region Entrepot

    private void ReloadEntrepotComboBox() {
        Entrepot? selectedEntrepot = null;
        if (this.entrepotSelector.SelectedItem != null) {
            selectedEntrepot = (Entrepot) this.entrepotSelector.SelectedItem;
        }
        this.entrepotSelector.Items.Clear();
        List<Entrepot> entrepots = this.facade.GetService<EntrepotService>().GetAllEntrepot();
        foreach (Entrepot entrepot in entrepots) {
            _ = this.entrepotSelector.Items.Add(entrepot);
        }
        if (this.entrepotSelector.Items.Contains(selectedEntrepot)) {
            this.entrepotSelector.SelectedItem = selectedEntrepot;
        }

    }

    private void ActivateEntrepotManagementButtons() {
        this.viewEntrepotButton.Enabled = true;
        this.editEntrepotButton.Enabled = true;
        this.deleteEntrepotButton.Enabled = true;
    }

    private void DeactivateEntrepotManagementButtons() {
        this.viewEntrepotButton.Enabled = false;
        this.editEntrepotButton.Enabled = false;
        this.deleteEntrepotButton.Enabled = false;
    }

    private void CreateEntrepotButton_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<EntrepotService>().CreateNewDtoInstance();
        this.ReloadEntrepotComboBox();
    }

    private void EntrepotSelector_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem != null) {
            this.ActivateEntrepotManagementButtons();
        } else {
            this.DeactivateEntrepotManagementButtons();
        }
    }

    private void ViewEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'entrepot selectionner.");
        } else {
            Entrepot selectedEntrepot = (Entrepot) this.entrepotSelector.SelectedItem;
            _ = this.facade.GetService<EntrepotService>().DisplayDtoInstance(selectedEntrepot);

        }
    }

    private void EditEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'entrepot selectionner.");
        } else {
            Entrepot selectedEntrepot = (Entrepot) this.entrepotSelector.SelectedItem;
            _ = this.facade.GetService<EntrepotService>().UpdateDtoInstance(selectedEntrepot);
            this.ReloadEntrepotComboBox();
        }
    }

    private void DeleteEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem is null) {
            _ = MessageBox.Show("Pas d'entrepot selectionner.");
        } else {
            Entrepot selectedEntrepot = (Entrepot) this.entrepotSelector.SelectedItem;
            _ = this.facade.GetService<EntrepotService>().DeleteDtoInstance(selectedEntrepot);
            this.ReloadEntrepotComboBox();
        }


    }


    #endregion

    #region Adresse


    private void AdresseFiltreTextBox_TextChanged(object sender, EventArgs e) 
    {
        this.AdresseListBox.DataSource = this.facade.GetService<AdresseService>().SearchAdresse(this.AdresseFiltreTextBox.Text);
    }

    private void AdresseListBox_SelectedIndexChanged(object sender, EventArgs e) 
    {
        if (this.AdresseListBox != null) {
            this.createAdresseButton.Enabled = true;
            this.AdresseEditButton.Enabled = true;
            this.AdresseViewButton.Enabled = true;
            this.AdresseDeleteButton.Enabled = true;
        } 
        else 
        {
            this.createAdresseButton.Enabled = true;
            this.AdresseEditButton.Enabled = false;
            this.AdresseViewButton.Enabled = false;
            this.AdresseDeleteButton.Enabled = false;
        }
    }

    private void CreateAdresseButton_Click(object sender, EventArgs e) 
    {
        _ = this.facade.GetService<AdresseService>().CreateNewDtoInstance();
    }

    private void AdresseViewButton_Click(object sender, EventArgs e)
    {
        if(this.AdresseListBox != null) 
        {
            Adresse selectedAdresse = (Adresse) this.AdresseListBox.SelectedItem;
            _ = this.facade.GetService<AdresseService>().DisplayDtoInstance(selectedAdresse);
        } 
        else 
        {
            _ = MessageBox.Show("Pas d'adresse selectionné");
        }
    }

    private void AdresseEditButton_Click(object sender, EventArgs e) 
    {
        if (this.AdresseListBox != null) {
            Adresse selectedAdresse = (Adresse) this.AdresseListBox.SelectedItem;
            _ = this.facade.GetService<AdresseService>().UpdateDtoInstance(selectedAdresse);
        } 
        else 
        {
            _ = MessageBox.Show("Pas d'adresse selectionné");
        }
    }

    private void AdresseDeleteButton_Click(object sender, EventArgs e) 
    {
        if (this.AdresseListBox != null) {
            Adresse selectedAdresse = (Adresse) this.AdresseListBox.SelectedItem;
            _ = this.facade.GetService<AdresseService>().DisplayDtoInstance(selectedAdresse);
        } 
        else 
        {
            _ = MessageBox.Show("Pas d'adresse selectionné");
        }
    }

    #endregion

    #region Clients
    private void QuitButton_Click(object sender, EventArgs e) {
        this.facade.ExitApplication();
    }

    private void Clientpanel4_Paint(object sender, PaintEventArgs e) {

    }

    private void createClientbutton1_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ClientService>().CreateNewDtoInstance();
    }

    private void filterClienttextBox1_TextChanged(object sender, EventArgs e) {
        this.ClientslistBox1.DataSource = this.facade.GetService<ClientService>().SearchClient(this.filterClienttextBox1.Text);
    }

    private void ClientslistBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void viewClientbutton1_Click(object sender, EventArgs e) {
        ClientsDTO selectClient = (ClientsDTO) this.ClientslistBox1.SelectedItem;
        _ = this.facade.GetService<ClientService>().DisplayDtoInstance(selectClient);

    }

    private void deletebutton_Click(object sender, EventArgs e) {
        ClientsDTO selectedClient = (ClientsDTO) this.ClientslistBox1.SelectedItem;
        _ = this.facade.GetService<ClientService>().DeleteDtoInstance(selectedClient);
    }

    private void editClientbutton_Click(object sender, EventArgs e) {
        ClientsDTO selectedClient = (ClientsDTO) this.ClientslistBox1.SelectedItem;
        _ = this.facade.GetService<ClientService>().UpdateDtoInstance(selectedClient);
    }

    #endregion

}
