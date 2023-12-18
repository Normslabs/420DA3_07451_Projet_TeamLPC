using _420DA3_07451_Projet_Initial.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ProduitWindow : Form ,IDtoManagementView<Produit> {

    private readonly AbstractFacade facade;
    private Produit workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public ProduitWindow(AbstractFacade facade) {
        this.facade = facade;
        //this.workingDtoInstance = new Produit("", null);
        this.InitializeComponent();
    }

    private void ProduitWindow_Load(object sender, EventArgs e) {

    }


    private void ExitButton_Click(object sender, EventArgs e) {
        this.Hide();
        this.facade.ShutdownParentApplication();
    }

}
