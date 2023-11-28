﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;
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


/// <summary>
/// Represente une fenêtre pour gérer les objets de type <see cref="Utilisateur"/>.
/// </summary>
/// <remarks>
/// Permet par défaut les quatres opérations de base CRUD.
/// </remarks>
public partial class UtilisateurManagementForm : Form, IDtoManagementView<Utilisateur> {
    private readonly AbstractFacade facade;
    private Utilisateur workingInstance;
    private ViewIntentEnum workingIntent;
    private int nullWarehouseComboboxItemIndex = 0;


    /// <summary>
    /// Construit un nouvel objet <see cref="UtilisateurManagementForm"/>. Recoit un objet de type
    /// <see cref="AbstractFacade"/> en paramètre.
    /// </summary>
    /// <param name="facade">La facade fournissant des services.</param>
    public UtilisateurManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadRolesListBox(this.facade.GetService<RoleService>().GetAllRoles());
    }

    public UtilisateurManagementForm() {
        this.InitializeComponent();
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
        this.userRolesListbox.Items.Clear();
        this.userRolesListbox.Items.AddRange(list.ToArray());
    }

    public void LoadWarehousesInCombobox(List<Entrepot> warehouseList) {
        this.userWarehouseCombobox.Items.Clear();
        this.nullWarehouseComboboxItemIndex = this.userWarehouseCombobox.Items.Add("Aucun");
        this.userWarehouseCombobox.Items.AddRange(warehouseList.ToArray());
        this.userWarehouseCombobox.Refresh();
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

    private void DoEdit() {
        try {
            this.validateOnEdit();
        } catch (Exception ex) {

        }
        this.workingInstance.Roles = this.userRolesListbox.SelectedItems.Cast<Role>().ToList();
        _ = this.facade.GetService<UtilisateurService>().UpdateDtoInstance(this.workingInstance);
    }

    private void DoDelete() {

    }

    private void validateOnEdit() {
        if (!Utilisateur.ValiderUsername(this.userUsernameTextBox.Text)) {
            throw new Exception("Nom d'utilisateur invalide");
        }
    }

    #endregion


    #region Event Handlers

    private void UserUsernameTextBox_TextChanged(object sender, EventArgs e) {
        if (!Utilisateur.ValiderUsername(this.userUsernameTextBox.Text)) {
            this.userUsernameTextBox.Invalidate(true);
        } else {
            this.userUsernameTextBox.Invalidate(false);
        }
    }

    private void UserUsernameTextBox_Leave(object sender, EventArgs e) {
        Utilisateur? existingUser =
            this.facade.GetService<UtilisateurService>().FindUtilisateurByUsername(this.userUsernameTextBox.Text);
        if (existingUser is not null) {
            _ = MessageBox.Show("U utilisateur avec le même username existe déjà!");
            this.userUsernameTextBox.Invalidate(true);
        }
    }

    private void UserPasswordResetButton_Click(object sender, EventArgs e) {

    }

    private void ButtonAnnuler_Click(object sender, EventArgs e) {

    }

    private void BoutonAction_Click(object sender, EventArgs e) {
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


    #endregion

    private void userUsernameLabel_Click(object sender, EventArgs e) {

    }

    private void UserPasswordTextBox_Leave(object sender, EventArgs e) {
        if (!this.userPasswordTextBox.Text.IsNullOrEmpty()) {
            string newHash = CryptographyService.HashPassword(this.userPasswordTextBox.Text);
            this.userPasswordHashTextBox.Text = newHash;
        }
    }
}