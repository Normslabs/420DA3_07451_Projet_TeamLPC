using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using _420DA3_07451_Projet_Initial.Business.Services;

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

    public DialogResult OpenFor(Produit instance) {
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
        return this.ShowDialog();

    }

    public void EnableControls() {
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

    public void DisableControls() {
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
}
