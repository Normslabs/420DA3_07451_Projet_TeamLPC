using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
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
public partial class PurchaseOrderForm : Form, IDtoManagementView<PurchaseOrder> {

    private readonly AbstractFacade facade;
    private PurchaseOrder po; //working instance


    public PurchaseOrderForm(AbstractFacade facade) {
        this.facade = facade;
        InitializeComponent();
        //
        //
    }

    #region Public Methods
    public DialogResult OpenForCreation(PurchaseOrder blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(PurchaseOrder instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(PurchaseOrder instance) {
        throw new NotImplementedException();
    }
    #endregion

    #region Private Methods
    private void AnnulerBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }


    #endregion


}
