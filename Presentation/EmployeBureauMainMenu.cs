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
internal partial class EmployeBureauMainMenu : Form {

    private readonly OfficeEmployeeFacade facade;

    public EmployeBureauMainMenu(OfficeEmployeeFacade facade) {
        this.InitializeComponent();
        this.facade = facade;
    }


    #region Client
    private void ClientCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ClientService>().CreateNewDtoInstance();
    }

    private void ClientFiltretextBox_TextChanged(object sender, EventArgs e) {
        this.ClientlistBox.DataSource = this.facade.GetService<ClientService>().SearchClient(this.ClientFiltretextBox.Text);
    }

    private void ClientlistBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.ClientlistBox.SelectedItem != null) {
            this.ClientCreateBtn.Enabled = true;
            this.ClientViewBtn.Enabled = true;
            this.ClientEditBtn.Enabled = true;
        } else {
            this.ClientCreateBtn.Enabled = true;
            this.ClientViewBtn.Enabled = false;
            this.ClientEditBtn.Enabled = false;
        }
    }

    private void ClientEditBtn_Click(object sender, EventArgs e) {
        if (this.ClientlistBox != null) {
            ClientsDTO selectedclient = (ClientsDTO) this.ClientlistBox.SelectedItem;
            _ = this.facade.GetService<ClientService>().UpdateDtoInstance(selectedclient);
        } else {
            _ = MessageBox.Show("Pas de client sélectionné");
        }
    }

    private void ClientViewBtn_Click(object sender, EventArgs e) {
        if (this.ClientlistBox != null) {
            ClientsDTO selectedclient = (ClientsDTO) this.ClientlistBox.SelectedItem;
            _ = this.facade.GetService<ClientService>().DisplayDtoInstance(selectedclient);
        } else {
            _ = MessageBox.Show("Pas de client sélectionné");
        }
    }

    #endregion 

    #region ShippingOrder
    private void ShippingOrderCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ShipmentOrderService>().CreateNewDtoInstance();
    }

    #endregion
}
