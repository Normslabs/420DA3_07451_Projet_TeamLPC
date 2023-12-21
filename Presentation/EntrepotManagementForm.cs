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

/// <summary>
/// Declaration de la classe EntrepotManagementForm
/// </summary>
public partial class EntrepotManagementForm : Form, IDtoManagementView<Entrepot> {

    /// <summary>
    /// Declaration de la facade pour les intance courrante et l'intention courrante
    /// </summary>
    private AbstractFacade ParentFacade { get; set; }
    private Entrepot workingInstance = null!;
    private ViewIntentEnum workingIntent;

    /// <summary>
    /// Declaration du constructeur qui fait passer la facade, initialitation et le rechargement des adresse combobox
    /// </summary>
    /// <param name="facade"></param>
    public EntrepotManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
        this.LoadAdresseInComboBox();
    }

    /// <summary>
    /// Fonction pour ouvrir le windonw en mode creation
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Entrepot blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.ActionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    /// <summary>
    /// Fonction pour ouvrir le windonw en mode Visualitation
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForVisualization(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.ActionButton.Text = "OK";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction pour ouvrir le windonw en mode Edition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.ActionButton.Text = "Enregistrer";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction pour ouvrir le windonw en mode Supprimer
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Entrepot instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.ActionButton.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction qui permet de recharger la combo box adresses 
    /// </summary>
    public void LoadAdresseInComboBox() {
        this.entrepotadresseComboBox.DataSource = this.ParentFacade.GetService<AdresseService>().GetAllAddresses();
    }

    /// <summary>
    /// Fonction permettant l'activiation ou desactivation de l'intent du form
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Fonction qui permet d'activier tout les bouttons choisie
    /// </summary>
    private void ActivateControls() {
        this.entrepotidField.Enabled = false;
        this.entrepotnameTextBox.Enabled = true;
        this.entrepotadresseComboBox.Enabled = true;
    }


    /// <summary>
    /// Fonction qui permet de desactiver tout les bouttons choisie
    /// </summary>
    private void DeactivateControls() {
        this.entrepotidField.Enabled = false;
        this.entrepotnameTextBox.Enabled = false;
        this.entrepotadresseComboBox.Enabled = false;
    }

    /// <summary>
    /// Fonction qui permet de valider le nom de l'entrepot en cherchant la fonction dans le DTO entrepot
    /// </summary>
    /// <exception cref="Exception"></exception>
    private void ValidateFields() {
        if (!Entrepot.ValiderNomEntrepot(this.entrepotnameTextBox.Text)) {
            throw new Exception("Nom entrepot invalide");
        }
    }

    /// <summary>
    /// Fonction pour charger les entrepots dans les controles
    /// </summary>
    /// <param name="entrepot"></param>
    private void LoadEntrepotDataInControls(Entrepot entrepot) {
        this.entrepotidField.Value = entrepot.Id;
        this.entrepotnameTextBox.Text = entrepot.NomEntrepot;
        if (this.entrepotadresseComboBox.Items.Contains(entrepot.AdresseEntrepot)) {
            this.entrepotadresseComboBox.SelectedItem = entrepot.AdresseEntrepot;
        }

    }
    
    /// <summary>
    /// Fonction pour sauvegarder les donnes dans l'instance
    /// </summary>
    private void SaveDataInstance() {
        this.ValidateFields();
        this.workingInstance.NomEntrepot = this.entrepotnameTextBox.Text;
        this.workingInstance.AdresseEntrepot = (Adresse) this.entrepotadresseComboBox.SelectedItem;
    }

    /// <summary>
    /// Fonction pour quitter le form Entrepot
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitButton_Click_1(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Fonction qui permet d'aller cree une nouvelle adresse
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateadresseBtn_Click(object sender, EventArgs e) {
        Adresse? ajouternouvelleAdresse = this.ParentFacade.GetService<AdresseService>().CreateNewDtoInstance();
        if (ajouternouvelleAdresse is not null) {
            this.LoadAdresseInComboBox();
            if (this.entrepotadresseComboBox.Items.Contains(ajouternouvelleAdresse)) {
                this.entrepotadresseComboBox.SelectedItem = ajouternouvelleAdresse;
            }


        }
    }

    /// <summary>
    /// Fonction du boutton qui permet de montrer l'intention voulu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
}
