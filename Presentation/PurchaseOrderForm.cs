using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
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
public partial class PurchaseOrderForm : Form, IDtoManagementView<PurchaseOrder> {

    private readonly AbstractFacade facade;
    private PurchaseOrder po; //working instance
    private ViewIntentEnum workingIntent;

    public PurchaseOrderForm(AbstractFacade facade) {
        this.facade = facade;
        InitializeComponent();


    }
    #region Public Methods
    public DialogResult OpenForCreation(PurchaseOrder blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(PurchaseOrder instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(PurchaseOrder instance) {
        throw new NotImplementedException();
    }
    #endregion

    #region Private Methods
    private void SaveDataInInstace() {
        this.ValidateFields();
        this.po.ProductId = (int) this.idNumericUpDown.Value;
        this.po.QuantityOrdered = (int) this.QTYnumericUpDown.Value;
        this.po.Status = (PurchaseOrderStatusEnum) this.StatusComboBox.SelectedItem;
        this.po.DestinationWarehouse = (Entrepot) this.entrepotComboBox.SelectedItem;
    }
    //incomplet LoadProduitDataInControls
    private void LoadProduitDataInControls(PurchaseOrder po) {
        this.idNumericUpDown.Value = po.ProductId;
        if (!this.produitListView.Items.Contains(po.)) {
            // // // // // // //
        }
        this.QTYnumericUpDown.Value = po.QuantityOrdered;
        this.StatusComboBox.SelectedItem = po.Status;
        this.entrepotComboBox.SelectedItem = po.DestinationWarehouse;
    }


    private void ValidateFields() {
        if (!PurchaseOrder.ValiderQTYOrder((int) this.QTYnumericUpDown.Value)) {
            throw new Exception("La quantité à commander ne peut pas être en dessous de 0");
        }
    }

    private void AnnulerBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    private void ActionBtn_Click(object sender, EventArgs e) {
        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    SaveDataInInstace();
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

    private void EnabledControls() {
        this.idNumericUpDown.Enabled = false;
        this.produitTextBox.Enabled = true;
        this.produitListView.Enabled = true;
        this.QTYnumericUpDown.Enabled = true;
        this.StatusComboBox.Enabled = true;
        this.entrepotComboBox.Enabled = true;
    }

    private void DisableControls() {
        this.idNumericUpDown.Enabled = false;
        this.produitTextBox.Enabled = false;
        this.produitListView.Enabled = false;
        this.QTYnumericUpDown.Enabled = false;
        this.StatusComboBox.Enabled = false;
        this.entrepotComboBox.Enabled = false;
    }
    #endregion



}