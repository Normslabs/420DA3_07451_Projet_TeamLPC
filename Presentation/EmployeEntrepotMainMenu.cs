using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
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
public partial class EmployeEntrepotMainMenu : Form {
    private readonly AbstractFacade parentFacade;


    public EmployeEntrepotMainMenu(AbstractFacade facade) {
        this.parentFacade = facade;
        this.InitializeComponent();
        this.LoadListboxIncompletePoListBox();
        this.LoadListBoxIncompleteSoListBox();
        this.LoadListBoxUnassignedSoListBox();
    }

    private void AssignToSelfButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.unassignedSOListBox.SelectedItem;
        Utilisateur utilisateur = this.parentFacade.LoginService.GetLoggedInUser();
        _ = this.parentFacade.GetService<ShipmentOrderService>().AssignOrderToUser(selectedOrder, utilisateur);
        this.unassignedSOListBox.Items.Remove(selectedOrder);
        _ = this.userIncompleteSOListBox.Items.Add(selectedOrder);

    }

    private void MarkSoAsPickedUpButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.userIncompleteSOListBox.SelectedItem;
        _ = this.parentFacade.GetService<ShipmentOrderService>().MarkAsPickedup(selectedOrder);
        this.userIncompleteSOListBox.Items.Remove(selectedOrder);
    }

    private void MarkSoAsCompletedButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.userIncompleteSOListBox.SelectedItem;
        _ = this.parentFacade.GetService<ShipmentOrderService>().MarkAsCompleted(selectedOrder);
        this.userIncompleteSOListBox.Items.Remove(selectedOrder);

    }

    private void MarkPoAsCompletedButton_Click(object sender, EventArgs e) {
        PurchaseOrder selectedOrder = (PurchaseOrder) this.warehouseIncompletePoListBox.SelectedItem;
        _ = this.parentFacade.GetService<PurchaseOrderService>().CompletePurchaseOrder(selectedOrder);
        this.warehouseIncompletePoListBox.Items.Remove(selectedOrder);
    }

    private void Col1RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListBoxUnassignedSoListBox();
    }

    private void Col2RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListBoxIncompleteSoListBox();
    }

    private void Col3RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListboxIncompletePoListBox();
    }

    private void QuitButton_Click(object sender, EventArgs e) {
        this.parentFacade.ShutdownParentApplication();
    }

    private void UnassignedSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        this.assignToSelfButton.Enabled = this.unassignedSOListBox.SelectedItem != null;
    }

    private void UserIncompleteSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.userIncompleteSOListBox.SelectedItem != null) {
            this.markSoAsCompletedButton.Enabled = true;
            this.markSoAsPickedUpButton.Enabled = true;
        } else {
            this.markSoAsCompletedButton.Enabled = false;
            this.markSoAsPickedUpButton.Enabled = false;
        }
    }

    private void WarehouseIncompletePoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        this.markPoAsCompletedButton.Enabled = this.warehouseIncompletePoListBox.SelectedItem != null;
    }


    private void LoadListboxIncompletePoListBox() {
        this.warehouseIncompletePoListBox.Items.Clear();
        Entrepot entrepot = this.parentFacade.LoginService.GetLoggedInUser().EntrepotDeTravail ?? throw new Exception("Employe d'entrepot n'a pas d'entrepot assigne");
        this.warehouseIncompletePoListBox.Items.AddRange(this.parentFacade.GetService<PurchaseOrderService>().GetIncompleteForWarehouse(entrepot).ToArray());
    }

    private void LoadListBoxUnassignedSoListBox() {
        this.unassignedSOListBox.Items.Clear();
        Entrepot entrepot = this.parentFacade.LoginService.GetLoggedInUser().EntrepotDeTravail ?? throw new Exception("Employe d'entrepot n'a pas d'entrepot assigne");
        this.unassignedSOListBox.Items.AddRange(this.parentFacade.GetService<ShipmentOrderService>().GetNewOrdersForWarehouse(entrepot.Id).ToArray());
    }

    private void LoadListBoxIncompleteSoListBox() {
        this.userIncompleteSOListBox.Items.Clear();
        int userId = this.parentFacade.LoginService.GetLoggedInUser().Id;
        this.userIncompleteSOListBox.Items.AddRange(this.parentFacade.GetService<ShipmentOrderService>().GetIncompleteOrdersAssignedTo(userId).ToArray());
    }
}
