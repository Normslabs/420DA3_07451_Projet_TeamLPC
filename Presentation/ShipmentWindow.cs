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
public partial class ShipmentWindow : Form, IDtoManagementView<ShipmentDTO> {

    private readonly AbstractFacade facade;
    private ShipmentDTO workingInstance = null!;
    private ViewIntentEnum workingIntent;

    public ShipmentWindow(AbstractFacade facade) {
        this.facade = facade;
        InitializeComponent();
        LoadShipmentDataInComboBox();
    }

    public DialogResult OpenForCreation(ShipmentDTO blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.Actionbtn.Text = "Créer!";
        return this.OpenFor(blankInstance);
        ;
    }

    public DialogResult OpenForDeletion(ShipmentDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(ShipmentDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(ShipmentDTO instance) {
        throw new NotImplementedException();
    }

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


    private void EnableControlsForCreation() {
        this.ShippingOrderIdnumericUpDown.Enabled = false;
        this.TrackingtextBox.Enabled = false;
        this.ServicelistBox.Enabled = true;
    }



    private void DisableControls() {
        this.ShippingOrderIdnumericUpDown.Enabled = false;
        this.TrackingtextBox.Enabled = false;
        this.ServicelistBox.Enabled = false;

    }

    private void LoadShipmentDataInControls(ShipmentDTO shipment) {
        this.ShippingOrderIdnumericUpDown.Value = shipment.Id;
        this.TrackingtextBox.Text = shipment.TrackingNumber;
        this.ServicelistBox.SelectedItem = shipment.Service;

    }

    private void LoadShipmentDataInComboBox() {
        foreach (ShipmentDTO.ShipmentServiceEnum ShipmentService in Enum.GetValues(typeof(ShipmentDTO.ShipmentServiceEnum))) {
            this.ServicelistBox.Items.Add(ShipmentService);
        }
    }

    private void SaveDataInInstance() {
        this.workingInstance.Service = (ShipmentDTO.ShipmentServiceEnum) this.ServicelistBox.SelectedItem;
    }

    private void Exitbtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void Actionbtn_Click(object sender, EventArgs e) {
        try {
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
}
