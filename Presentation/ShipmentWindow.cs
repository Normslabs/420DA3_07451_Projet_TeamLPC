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
/// Classe de shipmentWindow (UI)
/// </summary>
public partial class ShipmentWindow : Form, IDtoManagementView<ShipmentDTO> {

    /// <summary>
    /// Déclaration de la facade, de l'instance courante ainsi que de l'intention courante  
    /// </summary>

    private readonly AbstractFacade facade;
    private ShipmentDTO workingInstance = null!;
    private ViewIntentEnum workingIntent;

    /// <summary>
    /// Declaration du constructeur de base passant l'initialisation ainsi que la facade
    /// </summary>
    /// <param name="facade"></param>
    public ShipmentWindow(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadShipmentDataInComboBox();
    }


    /// <summary>
    /// Fonction pour ouvrir le window en mode creation
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(ShipmentDTO blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.Actionbtn.Text = "Créer!";
        return this.OpenFor(blankInstance);
        ;
    }

    /// <summary>
    /// Fonction pour ouvrir le window en mode de suppression
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public DialogResult OpenForDeletion(ShipmentDTO instance) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Fonction pour ouvrir le window en mode edition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public DialogResult OpenForEdition(ShipmentDTO instance) {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Fonction pour ouvrir le window en mode visualisation
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public DialogResult OpenForVisualization(ShipmentDTO instance) {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Fonction permettant d'activer les controles et les désactiver en fonction de l'intent d'ouverture de la window
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    private DialogResult OpenFor(ShipmentDTO instance) {
        this.workingInstance = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.EnableControlsForCreation();
                break;
            case ViewIntentEnum.Edition:
                this.DisableControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
            default:
                this.DisableControls();
                break;
        }
        this.LoadShipmentDataInControls(instance);
        return this.ShowDialog();
    }

    /// <summary>
    /// Fonction pour activer les controles en mode creation
    /// </summary>
    private void EnableControlsForCreation() {
        this.ShippingOrderIdnumericUpDown.Enabled = false;
        this.TrackingtextBox.Enabled = false;
        this.ServicelistBox.Enabled = true;
    }

    /// <summary>
    /// Fonction pour désactiver les controles
    /// </summary>

    private void DisableControls() {
        this.ShippingOrderIdnumericUpDown.Enabled = false;
        this.TrackingtextBox.Enabled = false;
        this.ServicelistBox.Enabled = false;

    }

    /// <summary>
    /// Fonction pour charger les shipments dans les controles
    /// </summary>
    /// <param name="shipment"></param>
    private void LoadShipmentDataInControls(ShipmentDTO shipment) {
        this.ShippingOrderIdnumericUpDown.Value = shipment.Id;
        this.TrackingtextBox.Text = shipment.TrackingNumber;
        this.ServicelistBox.SelectedItem = shipment.Service;

    }


    /// <summary>
    /// Fonction pour charger le combobox des shipments
    /// </summary>
    private void LoadShipmentDataInComboBox() {
        foreach (ShipmentDTO.ShipmentServiceEnum ShipmentService in Enum.GetValues(typeof(ShipmentDTO.ShipmentServiceEnum))) {
            _ = this.ServicelistBox.Items.Add(ShipmentService);
        }
    }


    /// <summary>
    /// Fonction pour sauvegarder les datas de l'instance
    /// </summary>
    private void SaveDataInInstance() {
        this.workingInstance.Service = (ShipmentDTO.ShipmentServiceEnum) this.ServicelistBox.SelectedItem;
    }


    /// <summary>
    /// Fonction pour quitter l'application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Exitbtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }


    /// <summary>
    /// Fonction du bouton d'action
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Actionbtn_Click(object sender, EventArgs e) {
        try {
            if (!this.ValidateFields()) {
                return;
            }

            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                    this.SaveDataInInstance();
                    break;
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



    /// <summary>
    /// Fonction de validation empechant de faire une action si le tracking number ou le servicelistbox sont null
    /// </summary>
    /// <returns></returns>
    private bool ValidateFields() {

        if (string.IsNullOrWhiteSpace(this.TrackingtextBox.Text)) {
            _ = MessageBox.Show("Le champ 'Tracking number' est requis.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        if (this.ServicelistBox.SelectedItem == null) {
            _ = MessageBox.Show("Veuillez sélectionner un service.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

}
