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
    private readonly AbstractFacade ParentFacade;


    public EmployeEntrepotMainMenu(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
        this.LoadListboxIncompletePoListBox();
        this.LoadListBoxIncompleteSoListBox();
        this.LoadListBoxUnassignedSoListBox();
    }

    private void assignToSelfButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.unassignedSOListBox.SelectedItem;
        Utilisateur utilisateur = this.ParentFacade.LoginService.GetLoggedInUser();
        this.ParentFacade.GetService<ShipmentOrderService>().AssignOrderToUser(selectedOrder, utilisateur);
        this.unassignedSOListBox.Items.Remove(selectedOrder);
        this.userIncompleteSOListBox.Items.Add(selectedOrder);

    }

    private void markSoAsPickedUpButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.userIncompleteSOListBox.SelectedItem;
        this.ParentFacade.GetService<ShipmentOrderService>().MarkAsPickedup(selectedOrder);
        this.userIncompleteSOListBox.Items.Remove(selectedOrder);
    }

    private void markSoAsCompletedButton_Click(object sender, EventArgs e) {
        ShipmentOrderDTO selectedOrder = (ShipmentOrderDTO) this.userIncompleteSOListBox.SelectedItem;
        this.ParentFacade.GetService<ShipmentOrderService>().MarkAsCompleted(selectedOrder);
        this.userIncompleteSOListBox.Items.Remove(selectedOrder);

    }

    private void markPoAsCompletedButton_Click(object sender, EventArgs e) {
        PurchaseOrder selectedOrder = (PurchaseOrder) this.warehouseIncompletePoListBox.SelectedItem;
        this.ParentFacade.GetService<PurchaseOrderService>().CompletePurchaseOrder(selectedOrder);
        this.warehouseIncompletePoListBox.Items.Remove(selectedOrder);
    }

    private void col1RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListBoxUnassignedSoListBox();
    }

    private void col2RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListBoxIncompleteSoListBox();
    }

    private void col3RefreshButton_Click(object sender, EventArgs e) {
        this.LoadListboxIncompletePoListBox();
    }

    private void quitButton_Click(object sender, EventArgs e) {
        this.ParentFacade.ShutdownParentApplication();
    }

    private void unassignedSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.unassignedSOListBox.SelectedItem != null) {
            this.assignToSelfButton.Enabled = true;
        } else {
            this.assignToSelfButton.Enabled = false;

        }
    }

    private void userIncompleteSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.userIncompleteSOListBox.SelectedItem != null) {
            this.markSoAsCompletedButton.Enabled = true;
            this.markSoAsPickedUpButton.Enabled = true;
        } else {
            this.markSoAsCompletedButton.Enabled = false;
            this.markSoAsPickedUpButton.Enabled = false;
        }
    }

    private void warehouseIncompletePoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.warehouseIncompletePoListBox.SelectedItem != null) {
            this.markPoAsCompletedButton.Enabled = true;

        } else {
            this.markPoAsCompletedButton.Enabled = false;
        }
    }


    private void LoadListboxIncompletePoListBox() {
        this.warehouseIncompletePoListBox.Items.Clear();
        Entrepot entrepot = this.ParentFacade.LoginService.GetLoggedInUser().EntrepotDeTravail ?? throw new Exception("Employe d'entrepot n'a pas d'entrepot assigne");
        this.warehouseIncompletePoListBox.Items.AddRange(this.ParentFacade.GetService<PurchaseOrderService>().GetIncompleteForWarehouse(entrepot).ToArray());
    }

    private void LoadListBoxUnassignedSoListBox() {
        this.unassignedSOListBox.Items.Clear();
        Entrepot entrepot = this.ParentFacade.LoginService.GetLoggedInUser().EntrepotDeTravail ?? throw new Exception("Employe d'entrepot n'a pas d'entrepot assigne");
        this.unassignedSOListBox.Items.AddRange(this.ParentFacade.GetService<ShipmentOrderService>().GetNewOrdersForWarehouse(entrepot.Id).ToArray());
    }

    private void LoadListBoxIncompleteSoListBox() {
        this.userIncompleteSOListBox.Items.Clear();
        int userId = this.ParentFacade.LoginService.GetLoggedInUser().Id;
        this.userIncompleteSOListBox.Items.AddRange(this.ParentFacade.GetService<ShipmentOrderService>().GetIncompleteOrdersAssignedTo(userId).ToArray());
    }
}
