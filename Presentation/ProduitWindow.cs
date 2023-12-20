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
public partial class ProduitWindow : Form, IDtoManagementView<Produit> {
    public ProduitWindow() {
        InitializeComponent();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    private void panel2_Paint(object sender, PaintEventArgs e) {

    }

    public DialogResult OpenForCreation(Produit blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(Produit instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(Produit instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(Produit instance) {
        throw new NotImplementedException();
    }
}
