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
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ShipmentOrderWindows : Form, IDtoManagementView<ShipmentOrderDTO> {

    private readonly AbstractFacade facade;
    private ShipmentOrderDTO workingInstance = null!;
    private ViewIntentEnum workingIntent;

    public ShipmentOrderWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadClientComboBox();
        this.LoadStatutComboBox();
        this.LoadEntrepotComboBox();
    }
    public DialogResult OpenForCreation(ShipmentOrderDTO blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.actionbutton1.Text = "Créer";
        return this.OpenFor(blankInstance);

    }
    public DialogResult OpenForDeletion(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionbutton1.Text = "Supprimer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionbutton1.Text = "Éditer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionbutton1.Text = "Vu";
        return this.OpenFor(instance);
    }

    private void ShipmentOrderWindows_Load(object sender, EventArgs e) {

    }

    private void clientlabel1_Click(object sender, EventArgs e) {

    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    public void LoadClientComboBox() {
        this.clientShipmentcomboBox1.DataSource = this.facade.GetService<ClientService>().GetAllClients();

    }

    public void LoadEntrepotComboBox() {
        this.entrepotcomboBox1.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepot();
    }

    public void LoadEmployeEntrepotComboBox(Entrepot entrepot) {
        this.employeEntrepotcomboBox.DataSource = this.facade.GetService<UtilisateurService>().GetAllEmployesEntrepotDunEntrepot(entrepot);

    }

    public void LoadStatutComboBox() {
        this.statutcomboBox1.Items.Clear();
        foreach (ShippingOrderStatusEnum status in Enum.GetValues(typeof(ShippingOrderStatusEnum))) {
            this.statutcomboBox1.Items.Add(status);
        }
    }

    public DialogResult OpenFor(ShipmentOrderDTO shipmentOrderDTO) {

        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.EnableControl();
                break;
            case ViewIntentEnum.Edition:
                break;
            case ViewIntentEnum.Deletion:

                this.DisableControl();
                break;
            case ViewIntentEnum.Visualization:
                this.DisableControl();
                break;
        }
        return this.ShowDialog();
    }

    public void DisableControl() {
        this.clientShipmentcomboBox1.Enabled = false;
        this.employeEntrepotcomboBox.Enabled = false;
        this.entrepotcomboBox1.Enabled = false;
        this.datecreatedtextBox1.Enabled = false;
        this.datelivraisontextBox1.Enabled = false;
        this.adresseciviquetextBox2.Enabled = false;
        this.contactdestinatairetextBox3.Enabled = false;
        this.codepostaltextBox4.Enabled = false;
        this.statutcomboBox1.Enabled = false;
        this.produitfiltertextBox.Enabled = false;
        this.produitorderlistBox1.Enabled = false;
        this.produitalllistBox.Enabled = false;
        this.qtyproductnumericUpDown1.Enabled = false;

    }

    public void EnableControl() {
        this.clientShipmentcomboBox1.Enabled = true;
        this.employeEntrepotcomboBox.Enabled = true;
        this.entrepotcomboBox1.Enabled = false;
        this.datecreatedtextBox1.Enabled = false;
        this.datelivraisontextBox1.Enabled = false;
        this.adresseciviquetextBox2.Enabled = true;
        this.contactdestinatairetextBox3.Enabled = true;
        this.codepostaltextBox4.Enabled = true;
        this.statutcomboBox1.Enabled = true;
        this.produitfiltertextBox.Enabled = true;
        this.produitorderlistBox1.Enabled =false;
        this.produitalllistBox.Enabled = true;
        this.qtyproductnumericUpDown1.Enabled = true;

    }

    private void actionbutton1_Click(object sender, EventArgs e) {
        switch (this.workingIntent) {

            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
            case ViewIntentEnum.Deletion:
            case ViewIntentEnum.Visualization:
                break;
        }
        this.DialogResult = DialogResult.OK;
    }
    public void LoadShipmentOrderDataInControls(ShipmentOrderDTO instance) {
        this.clientShipmentcomboBox1.SelectedItem = instance.Clients;
        this.entrepotcomboBox1.SelectedItem = instance.EntrepotOriginal;
        this.datecreatedtextBox1.Text = instance.DateCreated.ToString();
        this.datelivraisontextBox1.Text = instance.DateShipped.ToString();
        this.adresseciviquetextBox2.Text = instance.DestinationCivicAdress;
        this.contactdestinatairetextBox3.Text = instance.DestinationContact;
        this.codepostaltextBox4.Text = instance.DestinationPostalCode;
        this.statutcomboBox1.SelectedItem = instance.Status;
        this.produitorderlistBox1.Items.Clear();
        foreach(ShippingOrderProducts sop in instance.AssociationsProduits) {
            this.produitorderlistBox1.Items.Add(sop);
        }
        this.LoadEmployeEntrepotComboBox(instance.EntrepotOriginal);
        this.employeEntrepotcomboBox.SelectedItem = instance.EmployeEntrepot;

    }

    public void SaveShipmentOrderInInstance() {
        this.ValidationFields();
        this.workingInstance.Clients = (ClientsDTO) this.clientShipmentcomboBox1.SelectedItem;
        this.workingInstance.EntrepotOriginal = (Entrepot) this.entrepotcomboBox1.SelectedItem;
        this.workingInstance.EmployeEntrepot = (Utilisateur) this.employeEntrepotcomboBox.SelectedItem;
        this.workingInstance.DestinationCivicAdress = this.adresseciviquetextBox2.Text;
        this.workingInstance.DestinationContact = this.contactdestinatairetextBox3.Text;
        this.workingInstance.DestinationPostalCode = this.codepostaltextBox4.Text;
        this.workingInstance.Status = (ShippingOrderStatusEnum) this.statutcomboBox1.SelectedItem;
        this.workingInstance.AssociationsProduits = this.produitorderlistBox1.Items.Cast<ShippingOrderProducts>().ToList();

    }

    private void ValidationFields() {

        if (!ShipmentOrderDTO.ValiderContactDestinataire(this.contactdestinatairetextBox3.Text)) {
            throw new Exception("Contact du destinataire invalide");
        }
        if (!ShipmentOrderDTO.ValiderAdresseCivique(this.adresseciviquetextBox2.Text)) {
            throw new Exception("Adresse civique invalide");
        }
        if (!ShipmentOrderDTO.ValidervCodePostal(this.codepostaltextBox4.Text)) {
            throw new Exception("Code Postal invalide");
        }
    }
}
