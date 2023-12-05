using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
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
public partial class ShipmentWindow : Form, IDtoManagementView<ShipmentDTO>{

    private readonly AbstractFacade facade;

    public ShipmentWindow(AbstractFacade facade) {
        this.facade = facade;
        InitializeComponent();
    }

    public DialogResult OpenForCreation(ShipmentDTO blankInstance) {
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
}
