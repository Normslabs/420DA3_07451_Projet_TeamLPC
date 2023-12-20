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

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ShipmentOrderWindows : Form, IDtoManagementView<ShipmentOrderDTO> {

    private readonly AbstractFacade facade;

    public ShipmentOrderWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }
    public DialogResult OpenForCreation(ShipmentOrderDTO blankInstance) {
        throw new NotImplementedException();
    }
    public DialogResult OpenForDeletion(ShipmentOrderDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(ShipmentOrderDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(ShipmentOrderDTO instance) {
        throw new NotImplementedException();
    }

    private void ShipmentOrderWindows_Load(object sender, EventArgs e) {

    }

    private void clientlabel1_Click(object sender, EventArgs e) {

    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }
    
    public void LoadClientComboBox() {
        this.facade.GetService<ClientService>();
    }
}
