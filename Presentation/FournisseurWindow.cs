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
public partial class FournisseurWindow : Form, IDtoManagementView<Fournisseur>{

    private readonly AbstractFacade facade;

    public FournisseurWindow(AbstractFacade facade) {
        this.facade = facade; 
        InitializeComponent();
    }



    public DialogResult OpenForCreation(Fournisseur blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(Fournisseur instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(Fournisseur instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(Fournisseur instance) {
        throw new NotImplementedException();
    }
}
