using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
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
public partial class AdresseManagementForm : Form, IDtoManagementView<Adresse> {
    private AbstractFacade ParentFacade { get; set; }
    private Adresse workingInstance = null!;
    private ViewIntentEnum workingIntent;

    public AdresseManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(Adresse blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer !";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionButton.Text = " Supprimer !";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionButton.Text = "Enregistrer !";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = " OK !";
        return this.OpenFor(instance);
    }

    private DialogResult OpenFor(Adresse instance) {
        this.workingInstance = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Creation:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Edition:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DeactivateControls();
                break;
            default:
                this.DeactivateControls();
                break;
        }
        this.LoadAdresseInControls(instance);
        return this.ShowDialog();
    }



    private void ActivateControls() {
        this.IdField.Enabled = false;
        this.numerociviqueTextBox.Enabled = true;
        this.rueTextBox.Enabled = true;
        this.villeTextBox.Enabled = true;
        this.codepostalTextBox.Enabled = true;
        this.provinceTextBox.Enabled = true;
        this.paysTextBox.Enabled = true;

    }

    private void DeactivateControls() {
        this.IdField.Enabled = false;
        this.numerociviqueTextBox.Enabled = false;
        this.rueTextBox.Enabled = false;
        this.villeTextBox.Enabled = false;
        this.codepostalTextBox.Enabled = false;
        this.provinceTextBox.Enabled = false;
        this.paysTextBox.Enabled = false;
    }

    private void LoadAdresseInControls(Adresse adresse) {
        this.IdField.Value = adresse.Id;
        this.numerociviqueTextBox.Text = adresse.Ville;
        this.rueTextBox.Text = adresse.NumeroCivique;
        this.villeTextBox.Text = adresse.Pays;
        this.codepostalTextBox.Text = adresse.CodePostal;
        this.provinceTextBox.Text = adresse.Province;
        this.paysTextBox.Text = adresse.Rue;

    }

    private void QuitButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionnButton_Click(object sender, EventArgs e) {
        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SavaDataInTheInstance();
                    break;
                case ViewIntentEnum.Deletion:
                case ViewIntentEnum.Visualization:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message);
            return;
        }
    }

    private void ValidatingFields() 
    {
        if(!Adresse.ValiderNumeroCivique(this.numerociviqueTextBox.Text)) 
        {
            throw new Exception(" Numéro civique invalide ");
        }
        if (!Adresse.ValiderRue(this.rueTextBox.Text)) 
        {
            throw new Exception(" Rue invalide ");
        }
        if (!Adresse.ValiderVille(this.villeTextBox.Text)) 
        {
            throw new Exception(" Ville invalide ");
        }
        if (!Adresse.ValiderCodePostal(this.codepostalTextBox.Text)) 
        {
            throw new Exception(" Code Postal invalide ");
        }
        if (!Adresse.ValiderProvince(this.provinceTextBox.Text)) 
        {
            throw new Exception(" Province invalide ");
        }
        if (!Adresse.ValiderPays(this.paysTextBox.Text)) 
        {
            throw new Exception(" Pays invalide ");
        }

    }

    private void SavaDataInTheInstance() 
    { 
       this.ValidatingFields();
       this.workingInstance.NumeroCivique = this.numerociviqueTextBox.Text;
       this.workingInstance.Rue = this.rueTextBox.Text;
       this.workingInstance.Ville = this.villeTextBox.Text;
       this.workingInstance.CodePostal = this.codepostalTextBox.Text;
       this.workingInstance.Province = this.provinceTextBox.Text;
       this.workingInstance.Pays = this.paysTextBox.Text;   
    
    }


}
