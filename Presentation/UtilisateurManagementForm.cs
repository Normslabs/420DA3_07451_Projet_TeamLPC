﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class UtilisateurManagementForm : Form, IDtoManagementView<Utilisateur> {
    private readonly AbstractFacade facade;
    private Utilisateur workingInstance;
    private ViewIntentEnum workingIntent;

    private List<ExampleDTO> examples = new List<ExampleDTO>() {
        new ExampleDTO("TestName1", "TestDesc1") {Id = 1},
        new ExampleDTO("TestName2", "TestDesc2") {Id = 2},
        new ExampleDTO("TestName3", "TestDesc3") {Id = 3},
        new ExampleDTO("TestName4", "TestDesc4") {Id = 4}
    };


    public UtilisateurManagementForm() {
        this.InitializeComponent();
        _ = this.listView1.Columns.Add("Nom", -2, HorizontalAlignment.Left);
        _ = this.listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
        _ = this.listView1.Columns.Add("Date Créé", -2, HorizontalAlignment.Center);
        _ = this.listView1.Columns.Add("Date Mofifié", -2, HorizontalAlignment.Center);
        foreach (ExampleDTO example in this.examples) {
            ListViewItem item = new ListViewItem(example.Name);
            _ = item.SubItems.Add(example.Description);
            _ = item.SubItems.Add(example.DateCreated.ToString());
            _ = item.SubItems.Add(example.DateUpdated.ToString());
            _ = this.listView1.Items.Add(item);
        }
    }

    public UtilisateurManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadRolesInCombobox(this.facade.GetService<RoleService>().GetAllRoles());
    }


    #region Public Methods

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

    public void LoadRolesListBox(List<Role> list) {
        this.rolesListBox.Items.Clear();
        this.rolesListBox.Items.AddRange(list.ToArray());
    }

    public void LoadRolesInCombobox(List<Role> rolesList) {
        this.comboBox1.Items.Clear();
        this.comboBox1.Items.AddRange(rolesList.ToArray());
        this.comboBox1.Refresh();
    }

    #endregion


    #region Private Methods

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

    private void SetRolesListBoxSelectedRolesForUser(Utilisateur user) {

    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
        List<Role> selectedRoles = this.rolesListBox.SelectedItems.Cast<Role>().ToList();

    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        Role selectedRole = (Role) this.comboBox1.SelectedItem;
    }

    #endregion

    private void buttonAnnuler_Click(object sender, EventArgs e) {

    }

    private void boutonAction_Click(object sender, EventArgs e) {
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                break;
            case ViewIntentEnum.Edition:
                break;
            case ViewIntentEnum.Deletion:
                break;
            case ViewIntentEnum.Visualization:
            default:
                break;
        }
    }

    private void DoEdit() {
        this.workingInstance.Roles = this.rolesListBox.SelectedItems.Cast<Role>().ToList();
        this.facade.GetService<UtilisateurService>().UpdateDtoInstance(this.workingInstance);
    }
}
