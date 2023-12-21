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

/// <summary>
/// Declaration de la classe AdresseManagementForm
/// </summary>
public partial class AdresseManagementForm : Form, IDtoManagementView<Adresse> {

    // Champs Proprieter
    private AbstractFacade ParentFacade { get; set; }
    private Adresse workingInstance = null!;
    private ViewIntentEnum workingIntent;

    /// <summary>
    /// Declaration de la facade, pour les instance courante et les intention instance
    /// </summary>
    /// <param name="facade"></param>
    public AdresseManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    /// <summary>
    /// Fonction de boutton pour ouvrir le form en mode creation
    /// </summary>
    /// <param name="blankInstance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Adresse blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer !";
        return this.OpenFor(blankInstance);
    }

    /// <summary>
    /// Fonction de boutton pour ouvrir le form en mode Supprimer
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionButton.Text = " Supprimer !";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction de boutton pour ouvrir le form en mode Edition
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionButton.Text = "Enregistrer !";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction de boutton pour ouvrir le form en mode Visualiasation
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForVisualization(Adresse instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = " OK !";
        return this.OpenFor(instance);
    }

    /// <summary>
    /// Fonction qui permet de determiner l'activiation ou desactiviation a partir de l'intention de ouverture de la window
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
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


    /// <summary>
    /// Fonction qui permet d'activier les boutton pour l'intention voulue
    /// </summary>
    private void ActivateControls() {
        this.IdField.Enabled = false;
        this.numerociviqueTextBox.Enabled = true;
        this.rueTextBox.Enabled = true;
        this.villeTextBox.Enabled = true;
        this.codepostalTextBox.Enabled = true;
        this.provinceTextBox.Enabled = true;
        this.paysTextBox.Enabled = true;

    }

    /// <summary>
    /// Fonction qui permet desactiver les boutton pour l'intention voulue
    /// </summary>
    private void DeactivateControls() {
        this.IdField.Enabled = false;
        this.numerociviqueTextBox.Enabled = false;
        this.rueTextBox.Enabled = false;
        this.villeTextBox.Enabled = false;
        this.codepostalTextBox.Enabled = false;
        this.provinceTextBox.Enabled = false;
        this.paysTextBox.Enabled = false;
    }

    /// <summary>
    /// Fonction qui permet de charger les donner de l'instance 
    /// </summary>
    /// <param name="adresse"></param>
    private void LoadAdresseInControls(Adresse adresse) {
        this.IdField.Value = adresse.Id;
        this.numerociviqueTextBox.Text = adresse.NumeroCivique;
        this.rueTextBox.Text = adresse.Rue;
        this.villeTextBox.Text = adresse.Ville;
        this.codepostalTextBox.Text = adresse.CodePostal;
        this.provinceTextBox.Text = adresse.Province;
        this.paysTextBox.Text = adresse.Pays;

    }
   
    /// <summary>
    ///  Fonction du boutton pour quitter le form Adresse
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Fonction du boutton d'action : intention deterteminer par le switch case.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    /// <summary>
    /// Fonction qui permet de valider la longueur de tout les champs dans adresses.
    ///  Pour chaque champs la fonction va chercher les fonction de validations dans le AdresseDTO
    /// </summary>
    /// <exception cref="Exception"></exception>
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

    /// <summary>
    /// Fonction qui sauvegarde les donnees dans l'instance
    /// </summary>
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
