using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
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
public partial class FournisseurWindow : Form {

    private readonly AbstractFacade facade;
    private Fournisseur workingInstance = null!;
    private ViewIntentEnum workingIntent;



    public FournisseurWindow() {
        this.InitializeComponent();
        this.LoadAdresseComboBox();
    }


    private void ExitBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    public DialogResult OpenForCreation(Fournisseur blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.ActionBtn.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForVisualization(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.ActionBtn.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.ActionBtn.Text = "Enregistrer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForDeletion(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.ActionBtn.Text = "Supprimer";
        return this.OpenFor(instance);
    }


    private DialogResult OpenFor(Fournisseur instance) {
        this.workingInstance = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.EnableControlsForCreation();
                break;
            case ViewIntentEnum.Edition:
                this.EnableControlsForEdition();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
            default:
                this.DisableControls();
                break;
        }
        this.LoadFournisseurDataInControls(instance);
        return this.ShowDialog();
    }

    private void EnableControlsForCreation() {
        this.PrenomContacttextBox1.Enabled = true;
        this.NomContacttextBox.Enabled = true;
        this.AdresseContacttextBox.Enabled = true;
        this.EmailContacttextBox.Enabled = true;
        this.FournisseurNomtextBox.Enabled = true;
        this.AdressecomboBox.Enabled = true;
    }

    private void EnableControlsForEdition() {
        this.PrenomContacttextBox1.Enabled = true;
        this.NomContacttextBox.Enabled = true;
        this.AdresseContacttextBox.Enabled = true;
        this.EmailContacttextBox.Enabled = true;
        this.FournisseurNomtextBox.Enabled = true;
        this.AdressecomboBox.Enabled = true;
    }

    private void DisableControls() {
        this.PrenomContacttextBox1.Enabled = false;
        this.NomContacttextBox.Enabled = false;
        this.AdresseContacttextBox.Enabled = false;
        this.EmailContacttextBox.Enabled = false;
        this.FournisseurNomtextBox.Enabled = false;
        this.AdressecomboBox.Enabled = false;

    }

    private void LoadAdresseComboBox() {
        this.AdressecomboBox.DataSource = this.facade.GetService<AdresseService>().GetAllAddresses();
    }

    private void LoadFournisseurDataInControls(Fournisseur fournisseur) {
        this.PrenomContacttextBox1.Text = fournisseur.PrenomContact;
        this.NomContacttextBox.Text = fournisseur.NomContact;
        this.AdresseContacttextBox.Text = fournisseur.AdresseContact;
        this.EmailContacttextBox.Text = fournisseur.EmailContact;
        this.FournisseurNomtextBox.Text = fournisseur.SupplierName;
        if (this.AdressecomboBox.Items.Contains(fournisseur.SupplierAdresse)) {
            this.AdressecomboBox.SelectedItem = fournisseur.SupplierAdresse;
        }
    }


    private void SaveDataInInstance() {
        this.workingInstance.PrenomContact = this.PrenomContacttextBox1.Text;
        this.workingInstance.NomContact = this.NomContacttextBox.Text;
        this.workingInstance.AdresseContact = this.AdresseContacttextBox.Text;
        this.workingInstance.EmailContact = this.EmailContacttextBox.Text;
        this.workingInstance.SupplierName = this.FournisseurNomtextBox.Text;
        this.workingInstance.SupplierAdresse = (Adresse) this.AdressecomboBox.SelectedItem;



    }

    private void ActionBtn_Click(object sender, EventArgs e) {
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
