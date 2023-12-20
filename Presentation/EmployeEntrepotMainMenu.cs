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

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class EmployeEntrepotMainMenu : Form {
    private readonly AbstractFacade ParentFacade;


    public EmployeEntrepotMainMenu(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }
}
