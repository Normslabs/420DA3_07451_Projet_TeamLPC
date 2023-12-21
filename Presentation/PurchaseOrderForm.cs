using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class PurchaseOrderForm : Form, IDtoManagementView<PurchaseOrder> {

    private readonly AbstractFacade facade;
    private PurchaseOrder po = null!; //working instance
    private ViewIntentEnum workingIntent;

    public PurchaseOrderForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();

    }
    private void LoadEntrepotComboBox() {
        this.entrepotComboBox.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepot();
    }

    private void LoadStatusComboBox() {
        this.StatusComboBox.Items.Clear();
        foreach (PurchaseOrderStatusEnum po in Enum.GetValues(typeof(PurchaseOrderStatusEnum))) {
            _ = this.StatusComboBox.Items.Add(po);
        }
    }
    #region Public Methods
    public DialogResult OpenForCreation(PurchaseOrder blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.ActionBtn.Text = "Creer";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.ActionBtn.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(PurchaseOrder instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.ActionBtn.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(PurchaseOrder instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.ActionBtn.Text = "OK";
        return this.OpenFor(instance);
    }


    #endregion


    #region Private Methods

    private DialogResult OpenFor(PurchaseOrder instance) {
        this.LoadEntrepotComboBox();
        this.LoadStatusComboBox();
        this.po = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DisableControls();
                break;
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.EnabledControls();
                break;
            default:
                throw new Exception("View Intent not supported");
        }
        this.LoadProduitDataInControls(instance);
        return this.ShowDialog();
    }
    private void SaveDataInInstace() {
        this.ValidateFields();
        this.po.ProductId = (int) this.idNumericUpDown.Value;
        this.po.QuantityOrdered = (int) this.QTYnumericUpDown.Value;
        this.po.Status = (PurchaseOrderStatusEnum) this.StatusComboBox.SelectedItem;
        this.po.DestinationWarehouse = (Entrepot) this.entrepotComboBox.SelectedItem;
    }
    private void LoadProduitDataInControls(PurchaseOrder po) {
        this.idNumericUpDown.Value = po.ProductId;
        if (!this.produitListView.Items.Contains(po.Product)) {

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
    private void ActionBtn_Click(object sender, EventArgs e) {
        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SaveDataInInstace();
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
    private void AnnulerBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}