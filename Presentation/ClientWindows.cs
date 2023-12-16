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
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ClientWindows : Form {

    private readonly AbstractFacade facade;
    public ClientWindows(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }
    public DialogResult OpenForCreation(ShipmentOrderDTO blankInstance) {
        throw new NotImplementedException();
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

    private void ClientWindows_Load(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void produitlabel1_Click(object sender, EventArgs e) {

    }
}
