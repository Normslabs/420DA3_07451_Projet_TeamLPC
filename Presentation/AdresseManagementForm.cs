using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
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
public partial class AdresseManagementForm : Form, IDtoManagementView<Adresse> {
    private AbstractFacade ParentFacade { get; set; }
    public AdresseManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        InitializeComponent();

    }

    public DialogResult OpenForCreation(Adresse blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(Adresse instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(Adresse instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(Adresse instance) {
        throw new NotImplementedException();
    }
}
