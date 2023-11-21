using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class UtilisateurManagementForm : Form, IDtoManagementView<Utilisateur> {
    private readonly AbstractFacade facade;
    private Utilisateur workingInstance;
    private ViewIntentEnum workingIntent;


    public UtilisateurManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(Utilisateur blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForVisualization(Utilisateur instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Utilisateur instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        return this.OpenFor(instance);
    }

    public DialogResult OpenForDeletion(Utilisateur instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        return this.OpenFor(instance);
    }

    private DialogResult OpenFor(Utilisateur instance) {
        this.workingInstance = instance;
            switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
            default:
                break;
        }
        return this.ShowDialog();
    }


    private void TextBox1_TextChanged(object sender, EventArgs e) {
        List<Role> list = this.facade.GetService<RoleService>().SearchRole(this.roleSearchBox.Text);
        this.LoadRolesListBox(list);
        this.rolesListBox.Refresh();
    }

    private void LoadRolesListBox(List<Role> list) {
        this.rolesListBox.Items.Clear();
        this.rolesListBox.Items.AddRange(list.ToArray());
    }

    private void SetRolesListBoxSelectedRolesForUser(Utilisateur user) {

    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
        List<Role> selectedRoles = this.rolesListBox.SelectedItems.Cast<Role>().ToList();

    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }
}
