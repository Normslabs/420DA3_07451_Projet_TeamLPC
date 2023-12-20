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

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class EntrepotManagementForm : Form, IDtoManagementView<Entrepot> {

    private AbstractFacade ParentFacade { get; set; }
    private Entrepot workingInstance = null!;
    private ViewIntentEnum workingIntent;


    public EntrepotManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
        this.LoadAdresseInComboBox();
    }

    public DialogResult OpenForCreation(Entrepot blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.ActionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForVisualization(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.ActionButton.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.ActionButton.Text = "Enregistrer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForDeletion(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.ActionButton.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    public void LoadAdresseInComboBox() {
        this.entrepotadresseComboBox.DataSource = this.ParentFacade.GetService<AdresseService>().GetAllAddresses();
    }

    private DialogResult OpenFor(Entrepot instance) {
        this.workingInstance = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Edition:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DeactivateControls();
                break;
            default:

                break;
        }
        this.LoadEntrepotDataInControls(instance);
        return this.ShowDialog();
    }

    private void ActivateControls() {
        this.entrepotidField.Enabled = false;
        this.entrepotnameTextBox.Enabled = true;
        this.entrepotadresseComboBox.Enabled = true;
    }

    private void DeactivateControls() {
        this.entrepotidField.Enabled = false;
        this.entrepotnameTextBox.Enabled = false;
        this.entrepotadresseComboBox.Enabled = false;
    }

    private void ValidateFields() {
        if (!Entrepot.ValiderNomEntrepot(this.entrepotnameTextBox.Text)) {
            throw new Exception("Nom entrepot invalide");
        }
    }

    private void LoadEntrepotDataInControls(Entrepot entrepot) {
        this.entrepotidField.Value = entrepot.Id;
        this.entrepotnameTextBox.Text = entrepot.NomEntrepot;
        if (this.entrepotadresseComboBox.Items.Contains(entrepot.AdresseEntrepot)) {
            this.entrepotadresseComboBox.SelectedItem = entrepot.AdresseEntrepot;
        }

    }

    private void SaveDataInstance() {
        this.ValidateFields();
        this.workingInstance.NomEntrepot = this.entrepotnameTextBox.Text;
        this.workingInstance.AdresseEntrepot = (Adresse) this.entrepotadresseComboBox.SelectedItem;
    }




    private void EntrepotManagementForm_Load(object sender, EventArgs e) {

    }

    private void QuitButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SaveDataInstance();
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

    private void CreateadresseBtn_Click(object sender, EventArgs e) {
        Adresse? ajouternouvelleAdresse = this.ParentFacade.GetService<AdresseService>().CreateNewDtoInstance();
        if (ajouternouvelleAdresse is not null) {
            this.LoadAdresseInComboBox();
            if (this.entrepotadresseComboBox.Items.Contains(ajouternouvelleAdresse)) {
                this.entrepotadresseComboBox.SelectedItem = ajouternouvelleAdresse;
            }


        }
    }
}
