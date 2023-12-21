using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
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
public partial class RoleManagementForm : Form, IDtoManagementView<Role> {

    // Champs/Propriétés
    private readonly AbstractFacade facade;
    private Role workingInstance = null!;
    private ViewIntentEnum workingIntent;

    private delegate void ThreadSafeUiDelegate();

    public RoleManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(Role blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.boutonAction.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(Role instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.boutonAction.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Role instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.boutonAction.Text = "Sauvegarder";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(Role instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.boutonAction.Text = "OK";
        return this.OpenFor(instance);
    }

    private void ActivateControls() {
        if (this.roleNameTextBox.InvokeRequired || this.roleDescriptionTextBox.InvokeRequired) {
            ThreadSafeUiDelegate asyncDelegate = new ThreadSafeUiDelegate(this.ActivateControls);
            _ = this.Invoke(asyncDelegate);
        } else {
            this.roleNameTextBox.Enabled = true;
            this.roleDescriptionTextBox.Enabled = true;
        }
    }

    private void DeactivateControls() {
        if (this.roleNameTextBox.InvokeRequired || this.roleDescriptionTextBox.InvokeRequired) {
            ThreadSafeUiDelegate asyncDelegate = new ThreadSafeUiDelegate(this.DeactivateControls);
            _ = this.Invoke(asyncDelegate);
        } else {
            this.roleNameTextBox.Enabled = false;
            this.roleDescriptionTextBox.Enabled = false;
        }
    }

    private DialogResult OpenFor(Role instance) {
        this.workingInstance = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
            default:
                this.DeactivateControls();
                break;
        }
        this.LoadRoleDataInControls(instance);
        return this.ShowDialog();
    }

    private void LoadRoleDataInControls(Role role) {
        this.idNumUpDown.Value = role.Id;
        this.roleNameTextBox.Text = role.RoleName;
        this.roleDescriptionTextBox.Text = role.RoleDescription;
    }

    private void SaveDataInInstance() {
        this.ValidateFields();
        this.workingInstance.RoleName = this.roleNameTextBox.Text;
        this.workingInstance.RoleName = this.roleDescriptionTextBox.Text;
    }

    private void ValidateFields() {
        if (!Role.ValidateRoleName(this.roleNameTextBox.Text)) {
            throw new Exception("Nom du role invalide");
        }
        if (!string.IsNullOrEmpty(this.roleDescriptionTextBox.Text) 
            && !Role.ValidateRoleDesc(this.roleDescriptionTextBox.Text)) {
            throw new Exception("Description du role invalide");
        }
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SaveDataInInstance();
                    break;
                case ViewIntentEnum.Deletion:
                case ViewIntentEnum.Visualization:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message);
            return;
        }
    }
}
