using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using System.Data;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ShipmentOrderWindows : Form, IDtoManagementView<ShipmentOrderDTO> {

    private readonly AbstractFacade facade;
    private ShipmentOrderDTO workingInstance = null!;
    private ViewIntentEnum workingIntent;
    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();
    /// <summary>
    /// Initialise une nouvelle instance de la classe ClientWindows.
    /// </summary>
    /// <param name="facade"></param>
    public ShipmentOrderWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }
    /// <summary>
    ///  Charge la fenetre pour la creation d'une nouveaulle commande avec une instance vide
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(ShipmentOrderDTO blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.actionbutton1.Text = "Créer";
        return this.OpenFor(blankInstance);

    }
    /// <summary>
    /// Charge la fenetre pour la suppression d'une commande d'expedition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionbutton1.Text = "Supprimer";
        return this.OpenFor(instance);
    }
    /// <summary>
    /// Charge la fenetre pour la modification d'une commmande d'expedition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionbutton1.Text = "Éditer";
        return this.OpenFor(instance);
    }
    /// <summary>
    /// charge la fenetre pour pouvoir voir une commande d'expedition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForVisualization(ShipmentOrderDTO instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionbutton1.Text = "Vu";
        return this.OpenFor(instance);
    }
    /// <summary>
    /// Permet de charger la liste des client dans la combobox client
    /// </summary>
    public void LoadClientComboBox() {
        this.clientShipmentcomboBox1.DataSource = this.facade.GetService<ClientService>().GetAllClients();

    }
    /// <summary>
    /// Permet de charger la liste des entrepots dans la combobox entrepot
    /// </summary>
    public void LoadEntrepotComboBox() {
        this.entrepotcomboBox1.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepot();
    }
    /// <summary>
    /// Permet de charger la liste des employe selon leur entrepot dans le combobox entrepot
    /// </summary>
    /// <param name="entrepot"></param>
    public void LoadEmployeEntrepotComboBox(Entrepot entrepot) {
        this.employeEntrepotcomboBox.DataSource = this.facade.GetService<UtilisateurService>().GetAllEmployesEntrepotDunEntrepot(entrepot);

    }
    /// <summary>
    /// Permet de prendre les Statut de la classe ShippingOrderStatusEnum et de les charger dans la combobox
    /// </summary>
    public void LoadStatutComboBox() {
        this.statutcomboBox1.Items.Clear();
        foreach (ShippingOrderStatusEnum status in Enum.GetValues(typeof(ShippingOrderStatusEnum))) {
            _ = this.statutcomboBox1.Items.Add(status);
        }
    }
    /// <summary>
    /// Charge la fenetre pour une operation specifique sur le commande d'expedition tout en chargant les liste box
    /// </summary>
    /// <param name="shipmentOrderDTO"></param>
    /// <returns></returns>
    public DialogResult OpenFor(ShipmentOrderDTO shipmentOrderDTO) {
        this.workingInstance = shipmentOrderDTO;
        this.LoadClientComboBox();
        this.LoadStatutComboBox();
        this.LoadEntrepotComboBox();
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.EnableControl();
                break;
            case ViewIntentEnum.Edition:
                this.EnableControl();
                break;
            case ViewIntentEnum.Deletion:
                this.DisableControl();
                break;
            case ViewIntentEnum.Visualization:
                this.DisableControl();
                break;
        }
        this.LoadShipmentOrderDataInControls(shipmentOrderDTO);
        return this.ShowDialog();
    }
    /// <summary>
    /// Restreint l'acces des textbox de la fenetre. 
    /// </summary>
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
    /// <summary>
    /// Donne l'acces des textbox de la fenetre. 
    /// </summary>
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
        this.produitorderlistBox1.Enabled = false;
        this.produitalllistBox.Enabled = true;
        this.qtyproductnumericUpDown1.Enabled = true;

    }

    private void Actionbutton1_Click(object sender, EventArgs e) {
        switch (this.workingIntent) {

            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.SaveShipmentOrderInInstance();
                this.ShippingOrderProducts = this.produitorderlistBox1.Items.Cast<ShippingOrderProducts>().ToList();
                break;
            case ViewIntentEnum.Deletion:
            case ViewIntentEnum.Visualization:
                break;
        }
        this.DialogResult = DialogResult.OK;
    }
    /// <summary>
    /// Charge les donne du client dans la fenetre 
    /// </summary>
    /// <param name="instance"></param>
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
        foreach (ShippingOrderProducts sop in instance.AssociationsProduits) {
            _ = this.produitorderlistBox1.Items.Add(sop);
        }
        this.LoadEmployeEntrepotComboBox(instance.EntrepotOriginal);
        this.employeEntrepotcomboBox.SelectedItem = instance.EmployeEntrepot;

    }
    /// <summary>
    /// Sauvegarde les donnees dans l'instance de commande d'expedition
    /// </summary>
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
    /// <summary>
    /// Validation des textebox
    /// </summary>
    /// <exception cref="Exception"></exception>
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

    private void Addproductbutton2_Click(object sender, EventArgs e) {

        if (this.produitalllistBox.SelectedItem != null) {

            if (this.qtyproductnumericUpDown1.Value > 0) {
                Produit produitselected = (Produit) this.produitalllistBox.SelectedItem;
                ShippingOrderProducts produitassociation = new ShippingOrderProducts() { ProduitId = produitselected.Id, Quantite = (int) this.qtyproductnumericUpDown1.Value };
                _ = this.produitorderlistBox1.Items.Add(produitassociation);
            } else {
                _ = MessageBox.Show("Veuillez entrer une quantite");
            }
        } else {
            _ = MessageBox.Show("Pas de produit selectione");
        }
    }

    private void RetireProductbutton1_Click(object sender, EventArgs e) {

        if (this.produitorderlistBox1.SelectedItem != null) {
            ShippingOrderProducts produitassociation = (ShippingOrderProducts) this.produitorderlistBox1.SelectedItem;
            this.produitorderlistBox1.Items.Remove(produitassociation);
        } else {
            _ = MessageBox.Show("Pas de produit selectione");
        }
    }
}
