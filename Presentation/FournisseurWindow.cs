using _420DA3_07451_Projet_Initial.Business;
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
/// Déclaration de la classe FournisseurWindows
/// </summary>
public partial class FournisseurWindow : Form, IDtoManagementView<Fournisseur> {

    /// <summary>
    /// Déclaration de la facade, de l'instance courante ainsi que de l'intention courante  
    /// </summary>
    private readonly AbstractFacade facade;
    private Fournisseur workingInstance = null!;
    private ViewIntentEnum workingIntent;



    /// <summary>
    /// Declaration du constructeur de base passant l'initialisation ainsi que la facade
    /// </summary>
    /// <param name="facade"></param>
    public FournisseurWindow(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadAdresseComboBox();
    }

    /// <summary>
    /// Fonction du bouton pour quitter l'application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExitBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Fonction pour ouvrir le window en mode creation
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Fournisseur blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.ActionBtn.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    /// <summary>
    /// Fonction pour ouvrir le window en mode visualisation
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForVisualization(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.ActionBtn.Text = "OK";
        return this.OpenFor(instance);
    }


    /// <summary>
    /// Fonction pour ouvrir le window en mode edition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.ActionBtn.Text = "Enregistrer";
        return this.OpenFor(instance);
    }


    /// <summary>
    /// Fonction pour ouvrir le window en mode de suppression
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Fournisseur instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.ActionBtn.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction permettant d'activer les controls et les désactiver en fonction de l'intent d'ouverture de la window
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Fonction pour activer les controles en mode creation
    /// </summary>
    private void EnableControlsForCreation() {
        this.PrenomContacttextBox1.Enabled = true;
        this.NomContacttextBox.Enabled = true;
        this.AdresseContacttextBox.Enabled = true;
        this.EmailContacttextBox.Enabled = true;
        this.FournisseurNomtextBox.Enabled = true;
        this.AdressecomboBox.Enabled = true;
    }

    /// <summary>
    /// Fonction pour activer les controles en mode edition
    /// </summary>
    private void EnableControlsForEdition() {
        this.PrenomContacttextBox1.Enabled = true;
        this.NomContacttextBox.Enabled = true;
        this.AdresseContacttextBox.Enabled = true;
        this.EmailContacttextBox.Enabled = true;
        this.FournisseurNomtextBox.Enabled = true;
        this.AdressecomboBox.Enabled = true;
    }

    /// <summary>
    /// Fonction pour désactiver les controles
    /// </summary>
    private void DisableControls() {
        this.PrenomContacttextBox1.Enabled = false;
        this.NomContacttextBox.Enabled = false;
        this.AdresseContacttextBox.Enabled = false;
        this.EmailContacttextBox.Enabled = false;
        this.FournisseurNomtextBox.Enabled = false;
        this.AdressecomboBox.Enabled = false;

    }


    /// <summary>
    /// Fonction pour charger le combobox des adresses
    /// </summary>
    private void LoadAdresseComboBox() {
        this.AdressecomboBox.DataSource = this.facade.GetService<AdresseService>().GetAllAddresses();
    }

    /// <summary>
    /// Fonction pour charger les fournisseur dans les controles
    /// </summary>
    /// <param name="fournisseur"></param>
    private void LoadFournisseurDataInControls(Fournisseur fournisseur) {
        this.PrenomContacttextBox1.Text = fournisseur.PrenomContact;
        this.NomContacttextBox.Text = fournisseur.NomContact;
        this.AdresseContacttextBox.Text = fournisseur.TelephoneContact;
        this.EmailContacttextBox.Text = fournisseur.EmailContact;
        this.FournisseurNomtextBox.Text = fournisseur.SupplierName;
        if (this.AdressecomboBox.Items.Contains(fournisseur.SupplierAdresse)) {
            this.AdressecomboBox.SelectedItem = fournisseur.SupplierAdresse;
        }
    }

    /// <summary>
    /// Fonction pour sauvegarder les datas de l'instance
    /// </summary>
    private void SaveDataInInstance() {
        this.workingInstance.PrenomContact = this.PrenomContacttextBox1.Text;
        this.workingInstance.NomContact = this.NomContacttextBox.Text;
        this.workingInstance.TelephoneContact = this.AdresseContacttextBox.Text;
        this.workingInstance.EmailContact = this.EmailContacttextBox.Text;
        this.workingInstance.SupplierName = this.FournisseurNomtextBox.Text;
        this.workingInstance.SupplierAdresse = (Adresse) this.AdressecomboBox.SelectedItem;



    }

    /// <summary>
    /// Fonction permettant la validation du email de contact ainsi que du nom,prenom,adresse de contact et le nom du fournisseur ne permettant pas de laisser la boite vide ou de dépasser un nombre de caractère
    /// </summary>
    /// <returns></returns>
    private bool ValidateFields() {
        if (!System.Text.RegularExpressions.Regex.IsMatch(this.EmailContacttextBox.Text, @"^[\w\.-]+@[\w\.-]+\.\w{2,4}$")) {
            _ = MessageBox.Show("L'adresse email n'est pas valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        Dictionary<TextBox, string> fields = new Dictionary<TextBox, string> {
        { this.PrenomContacttextBox1, "Prénom du contact" },
        { this.NomContacttextBox, "Nom du contact" },
        { this.AdresseContacttextBox, "Adresse" },
        { this.FournisseurNomtextBox, "Nom du fournisseur" }
    };

        foreach (KeyValuePair<TextBox, string> field in fields) {
            if (string.IsNullOrWhiteSpace(field.Key.Text)) {
                _ = MessageBox.Show($"Le champ '{field.Value}' ne peut pas être vide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (field.Key.Text.Length < 3 || field.Key.Text.Length > 100) {
                _ = MessageBox.Show($"La longueur du champ '{field.Value}' doit être comprise entre 3 et 100 caractères.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }


    /// <summary>
    /// Fonction du bouton d'action
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActionBtn_Click(object sender, EventArgs e) {
        try {
            if (!this.ValidateFields()) {
                return;
            }

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
