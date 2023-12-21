using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
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
public partial class ProduitWindow : Form, IDtoManagementView<Produit> {

    private readonly AbstractFacade facade;
    private Produit produit;
    private ViewIntentEnum workingIntent;
    private int nullclientListBoxItemIndex = 0;
    private int nullsupplierListBoxItemIndex = 0;

    public ProduitWindow(AbstractFacade facade) {
        this.facade = facade;

        InitializeComponent();
        this.LoadSupplierComboBox();
        this.LoadClientComboBox();
    }
    private void LoadClientComboBox() {
        this.clientComboBox.DataSource = this.facade.GetService<ClientService>().GetAllClients();

    }

    private void LoadSupplierComboBox() {
        this.supplierComboBox.DataSource = this.facade.GetService<FournisseurService>().GetAllFournisseur();
    }

    

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    private void panel2_Paint(object sender, PaintEventArgs e) {

    }


    #region Public Methods
    public DialogResult OpenForCreation(Produit blankInstance) {

        throw new NotImplementedException();
    }
    public DialogResult OpenForVisualization(Produit instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionBtn.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Produit instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionBtn.Text = "Enregistrer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForDeletion(Produit instance) {

        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionBtn.Text = "Supprimer";
        return this.OpenFor(instance);
    }


    #endregion



    #region Private Methods
    private DialogResult OpenFor(Produit instance) {
        this.produit = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                DisableControls();
                break;
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                EnableControls();
                break;
            default:
                throw new Exception("View Intent not supported");

        }
        this.LoadProduitDataInControls(instance);
        return this.ShowDialog();
    }

    private void cancelBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    private void SaveDataInInstance() {
        this.ValidateFields();
        this.produit.UpcCode = (int)this.upcCodeNumUpDown.Value;
        this.produit.Name = this.nameTextBox.Text;
        this.produit.Description = this.descriptionTextBox.Text;
        this.produit.SupplierCode = this.supplierCodeTextBox.Text;
        this.produit.DoAutoRestock = this.AutoCheckBox.Checked;
        this.produit.InstockQuantity = (int)this.qtyInStockNumeric.Value;
        this.produit.ClientsDTO = (ClientsDTO)this.clientComboBox.SelectedItem;
        this.produit.Fournisseur = (Fournisseur) this.supplierComboBox.SelectedItem;
    }

    private void LoadProduitDataInControls(Produit produit) {
        this.idNumUpDown.Value = produit.Id;
        this.upcCodeNumUpDown.Value = produit.UpcCode;
        this.nameTextBox.Text = produit.Name;
        this.descriptionTextBox.Text = produit.Description;
        this.supplierCodeTextBox.Text = produit.SupplierCode;
        this.AutoCheckBox.Checked = produit.DoAutoRestock;
        this.qtyInStockNumeric.Value = produit.InstockQuantity;
        this.clientComboBox.SelectedItem = produit.ClientsDTO;
        this.supplierComboBox.SelectedItem = produit.SupplierCode;
    }

    private void ValidateFields() {
        if (!Produit.ValiderUPCCode((int)this.upcCodeNumUpDown.Value)) {
            throw new Exception("UPC Code");
        }
        if (string.IsNullOrEmpty(this.nameTextBox.Text)) {
            throw new Exception("Veuillez rentrer un nom valide");
        }
        if (!Produit.ValiderName(this.nameTextBox.Text)) {
            throw new Exception("Le nom de doit pas depasser 128 caractère");
        }
        if (!Produit.ValiderSupplierCode(this.supplierComboBox.Text)) {
            throw new Exception("Le Supplier Code est trop long");
        }
    }

    private void EnableControls() {
        this.idNumUpDown.Enabled = false;
        this.upcCodeNumUpDown.Enabled = true;
        this.nameTextBox.Enabled = true;
        this.descriptionTextBox.Enabled = true;
        this.supplierCodeTextBox.Enabled = true;
        this.AutoCheckBox.Enabled = true;
        this.qtyInStockNumeric.Enabled = true;
        this.clientComboBox.Enabled = true;
        this.supplierComboBox.Enabled = true;
    }

    private void DisableControls() {
        this.idNumUpDown.Enabled = false;
        this.upcCodeNumUpDown.Enabled = false;
        this.nameTextBox.Enabled = false;
        this.descriptionTextBox.Enabled = false;
        this.supplierCodeTextBox.Enabled = false;
        this.AutoCheckBox.Enabled = false;
        this.qtyInStockNumeric.Enabled = false;
        this.clientComboBox.Enabled = false;
        this.supplierComboBox.Enabled = false;

    }

    #endregion

    private void actionBtn_Click(object sender, EventArgs e) {

    }
}
