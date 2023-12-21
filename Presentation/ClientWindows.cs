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
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ClientWindows : Form, IDtoManagementView<ClientsDTO> {

    private readonly AbstractFacade facade;
    private ClientsDTO workingInstance = null!;
    private ViewIntentEnum workinIntent;

    /// <summary>
    /// Initialise une nouvelle instance de la classe ClientWindows.
    /// </summary>
    /// <param name="facade"></param>
    public ClientWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();


    }
    /// <summary>
    /// Charge la fenetre pour la creation d'un nouveau client avec une instance vide
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(ClientsDTO blankInstance) {
        this.workinIntent = ViewIntentEnum.Creation;
        this.actionbutton1.Text = "Créer";
        return this.OpenFor(blankInstance);
    }

    /// <summary>
    /// Charge la fenetre pour la suppression d'un client
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(ClientsDTO instance) {
        this.workinIntent = ViewIntentEnum.Deletion;
        this.actionbutton1.Text = "Supprimer";
        return this.OpenFor(instance);
    }
    /// <summary>
    /// Charge la fenetre pour l'edition d'un client
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(ClientsDTO instance) {
        this.workinIntent = ViewIntentEnum.Edition;
        this.actionbutton1.Text = "Éditer";
        return this.OpenFor(instance);
    }
    /// <summary>
    /// Charge la fenetre pour la visualiation du client
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForVisualization(ClientsDTO instance) {
        this.workinIntent = ViewIntentEnum.Visualization;
        this.actionbutton1.Text = "Vu";
        return this.OpenFor(instance);
    }

    private void ClientWindows_Load(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void produitlabel1_Click(object sender, EventArgs e) {

    }
    /// <summary>
    /// Permet d'ajouter la liste des adresse dans la combobox d'adresse
    /// </summary>
    public void LoadAdresseComboBox() {
        this.adresseClientcomboBox1.DataSource = this.facade.GetService<AdresseService>().GetAllAddresses();

    }
    /// <summary>
    /// Permet d'ajouter la liste des entrepot dans la combo box d'entrepot
    /// </summary>
    public void LoadEntrepotComboBox() {
        this.entrepotClientcomboBox1.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepot();
    }
    /// <summary>
    /// Permet de resteindre l'acces de certaine textebox
    /// </summary>
    public void DisableControl() {
        this.nomClienttextBox1.Enabled = false;
        this.prenomtextBox1.Enabled = false;
        this.courrielClienttextBox1.Enabled = false;
        this.telephoneClienttextBox1.Enabled = false;
        this.companyNameClienttextBox1.Enabled = false;
        this.entrepotClientcomboBox1.Enabled = false;
        this.adresseClientcomboBox1.Enabled = false;
    }
    /// <summary>
    /// Permet de donner l'acces a certaine textbox
    /// </summary>
    public void EnableControls() {
        this.nomClienttextBox1.Enabled = true;
        this.prenomtextBox1.Enabled = true;
        this.courrielClienttextBox1.Enabled = true;
        this.telephoneClienttextBox1.Enabled = true;
        this.companyNameClienttextBox1.Enabled = true;
        this.entrepotClientcomboBox1.Enabled = true;
        this.adresseClientcomboBox1.Enabled = true;
    }
    /// <summary>
    /// Charge les donne du client dans les controles de la fenetre.
    /// </summary>
    /// <param name="clients"></param>
    public void LoadClientDataInControls(ClientsDTO clients) {
        this.nomClienttextBox1.Text = clients.Nom;
        this.prenomtextBox1.Text = clients.Prenom;
        this.courrielClienttextBox1.Text = clients.Courriel;
        this.telephoneClienttextBox1.Text = clients.Telephone.ToString();
        this.companyNameClienttextBox1.Text = clients.CompanyName;
        this.entrepotClientcomboBox1.SelectedItem = clients.AsignedWarehouse;
        this.adresseClientcomboBox1.SelectedItem = clients.ClientAdress;
    }
    /// <summary>
    /// Sauvegarde les donnes de l'instance du client.
    /// </summary>
    public void SaveDataOfInstance() {
        this.ValidationFields();
        this.workingInstance.Nom = this.nomClienttextBox1.Text;
        this.workingInstance.Prenom = this.prenomtextBox1.Text;
        this.workingInstance.Courriel = this.courrielClienttextBox1.Text;
        this.workingInstance.Telephone = long.Parse(this.telephoneClienttextBox1.Text);
        this.workingInstance.CompanyName = this.companyNameClienttextBox1.Text;
        this.workingInstance.AsignedWarehouse = (Entrepot) this.entrepotClientcomboBox1.SelectedItem;
        this.workingInstance.ClientAdress = (Adresse) this.adresseClientcomboBox1.SelectedItem;
    }
    /// <summary>
    /// Charge la fenetre pour une operation specifique sur le client.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenFor(ClientsDTO instance) {
        this.LoadAdresseComboBox();
        this.LoadEntrepotComboBox();

        this.workingInstance = instance;
        switch (this.workinIntent) {
            case ViewIntentEnum.Creation:
                this.EnableControls();
                break;
            case ViewIntentEnum.Edition:
                this.EnableControls();
                break;
            case ViewIntentEnum.Deletion:
                this.DisableControl();
                break;
            case ViewIntentEnum.Visualization:
                this.DisableControl();
                break;
            default:
                break;
        }

        this.LoadClientDataInControls(instance);
        return this.ShowDialog();
    }

    private void actionbutton1_Click(object sender, EventArgs e) {

        switch (this.workinIntent) {
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.SaveDataOfInstance();
                break;
            case ViewIntentEnum.Deletion:
            case ViewIntentEnum.Visualization:
            default:
                break;
        }
        this.DialogResult = DialogResult.OK;
    }

    private void Quitbutton1_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    /// <summary>
    /// Bouton de creation pour l'adresse
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateAddressButton_Click(object sender, EventArgs e) {
        Adresse? nouvelleAdresse = this.facade.GetService<AdresseService>().CreateNewDtoInstance();
        if (nouvelleAdresse is not null) {
            this.LoadAdresseComboBox();
            if (this.adresseClientcomboBox1.Items.Contains(nouvelleAdresse)) {
                this.adresseClientcomboBox1.SelectedItem = nouvelleAdresse;
            }
        }
    }
    /// <summary>
    /// Validation des champs de texte
    /// </summary>
    /// <exception cref="Exception"></exception>
    private void ValidationFields() {

        if (!ClientsDTO.ValiderNomClient(this.nomClienttextBox1.Text)) {
            throw new Exception("Nom invalide");
        }
        if (!ClientsDTO.ValiderPrenomClient(this.prenomtextBox1.Text)) {
            throw new Exception("Prenom invalide");
        }
        if (!ClientsDTO.ValiderTelephoneClient(long.Parse(this.telephoneClienttextBox1.Text))) {
            throw new Exception("Telephone invalide");
        }
        if (!ClientsDTO.ValiderEmailClient(this.courrielClienttextBox1.Text)) {
            throw new Exception("Courriel invalide");
        }
        if (!ClientsDTO.ValideCompanyName(this.companyNameClienttextBox1.Text)) {
            throw new Exception("Courriel invalide");
        }
    }
}
