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
    public ClientWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadAdresseComboBox();
        this.LoadEntrepotComboBox();

    }
    public DialogResult OpenForCreation(ClientsDTO blankInstance) {
        this.workinIntent = ViewIntentEnum.Creation;
        this.actionbutton1.Text = "Créer";
        return this.OpenFor(blankInstance);
    }
    public DialogResult OpenForDeletion(ClientsDTO instance) {
        this.workinIntent = ViewIntentEnum.Deletion;
        this.actionbutton1.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(ClientsDTO instance) {
        this.workinIntent = ViewIntentEnum.Edition;
        this.actionbutton1.Text = "Éditer";
        return this.OpenFor(instance);
    }

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

    public void LoadAdresseComboBox() {
        this.adresseClientcomboBox1.DataSource = this.facade.GetService<AdresseService>().GetAllAddresses();

    }

    public void LoadEntrepotComboBox() {
        this.entrepotClientcomboBox1.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepot();
    }

    public void DisableControl() {
        this.nomClienttextBox1.Enabled = false;
        this.prenomtextBox1.Enabled = false;
        this.courrielClienttextBox1.Enabled = false;
        this.telephoneClienttextBox1.Enabled = false;
        this.companyNameClienttextBox1.Enabled = false;
        this.entrepotClientcomboBox1.Enabled = false;
        this.adresseClientcomboBox1.Enabled = false;
    }

    public void EnableControls() {
        this.nomClienttextBox1.Enabled = true;
        this.prenomtextBox1.Enabled = true;
        this.courrielClienttextBox1.Enabled = true;
        this.telephoneClienttextBox1.Enabled = true;
        this.companyNameClienttextBox1.Enabled = true;
        this.entrepotClientcomboBox1.Enabled = true;
        this.adresseClientcomboBox1.Enabled = true;
    }

    public void LoadClientDataInControls(ClientsDTO clients) {
        this.nomClienttextBox1.Text = clients.Nom;
        this.prenomtextBox1.Text = clients.Prenom;
        this.courrielClienttextBox1.Text = clients.Courriel;
        this.telephoneClienttextBox1.Text = clients.Telephone.ToString();
        this.companyNameClienttextBox1.Text = clients.CompanyName;
        this.entrepotClientcomboBox1.SelectedItem = clients.AsignedWarehouse;
        this.adresseClientcomboBox1.SelectedItem = clients.ClientAdress;
    }

    public void SaveDataOfInstance() {
        this.workingInstance.Nom = this.nomClienttextBox1.Text;
        this.workingInstance.Prenom = this.prenomtextBox1.Text;
        this.workingInstance.Courriel = this.courrielClienttextBox1.Text;
        this.workingInstance.Telephone = long.Parse(this.telephoneClienttextBox1.Text);
        this.workingInstance.CompanyName = this.companyNameClienttextBox1.Text;
        this.workingInstance.AsignedWarehouse = (Entrepot) this.entrepotClientcomboBox1.SelectedItem;
        this.workingInstance.ClientAdress = (Adresse) this.adresseClientcomboBox1.SelectedItem;
    }

    public DialogResult OpenFor(ClientsDTO instance) {

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
}
