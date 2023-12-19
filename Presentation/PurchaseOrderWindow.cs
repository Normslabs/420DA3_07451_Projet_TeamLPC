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
public partial class PurchaseOrderWindow : Form, IDtoManagementView<PurchaseOrder> {
    private AbstractFacade facade;

    public PurchaseOrderWindow() {
        InitializeComponent();
    }

    public PurchaseOrderWindow(AbstractFacade facade) {
        this.facade = facade;
    }

    public DialogResult OpenForCreation(PurchaseOrder blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        return DialogResult.OK;
    }

    public DialogResult OpenForEdition(PurchaseOrder instance) {
        return DialogResult.OK;
    }

    public DialogResult OpenForVisualization(PurchaseOrder instance) {
        throw new NotImplementedException();
    }


    private void textBox1_TextChanged(object sender, EventArgs e) {

    }
}
