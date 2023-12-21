using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
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
/// Classe du window d'employé de bureau
/// </summary>
internal partial class EmployeBureauMainMenu : Form {

    /// <summary>
    /// déclaration de la facade
    /// </summary>

    private readonly OfficeEmployeeFacade facade;


    /// <summary>
    /// Déclaration du constructeur pour la facade et l'initialisation de employé de bureau
    /// </summary>
    /// <param name="facade"></param>
    public EmployeBureauMainMenu(OfficeEmployeeFacade facade) {
        this.InitializeComponent();
        this.facade = facade;
    }


    #region Client

    /// <summary>
    /// Fonction du bouton de création pour les clients appellant le service client
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClientCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ClientService>().CreateNewDtoInstance();
    }

    /// <summary>
    /// Fonction de la recherche filtrer appellant le service client 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClientFiltretextBox_TextChanged(object sender, EventArgs e) {
        this.ClientlistBox.DataSource = this.facade.GetService<ClientService>().SearchClient(this.ClientFiltretextBox.Text);
    }


    /// <summary>
    /// Fonction pour activer les controles lié au fait de si un choix a été fait dans la listebox de client
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClientlistBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.ClientlistBox.SelectedItem != null) {
            this.ClientCreateBtn.Enabled = true;
            this.ClientViewBtn.Enabled = true;
            this.ClientEditBtn.Enabled = true;
        } else {
            this.ClientCreateBtn.Enabled = true;
            this.ClientViewBtn.Enabled = false;
            this.ClientEditBtn.Enabled = false;
        }
    }


    /// <summary>
    /// Fonction pour le bouton Edition des clients appellant le service client
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClientEditBtn_Click(object sender, EventArgs e) {
        if (this.ClientlistBox != null) {
            ClientsDTO selectedclient = (ClientsDTO) this.ClientlistBox.SelectedItem;
            _ = this.facade.GetService<ClientService>().UpdateDtoInstance(selectedclient);
        } else {
            _ = MessageBox.Show("Pas de client sélectionné");
        }
    }

    /// <summary>
    /// Fonction pour le bouton de visualisation des clients appellant le service client
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClientViewBtn_Click(object sender, EventArgs e) {
        if (this.ClientlistBox != null) {
            ClientsDTO selectedclient = (ClientsDTO) this.ClientlistBox.SelectedItem;
            _ = this.facade.GetService<ClientService>().DisplayDtoInstance(selectedclient);
        } else {
            _ = MessageBox.Show("Pas de client sélectionné");
        }
    }

    #endregion 

    #region ShippingOrder

    /// <summary>
    /// Fonction pour le bouton de création pour le shipping order appellant le shipmentorder service
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ShippingOrderCreateBtn_Click(object sender, EventArgs e) {
        _ = this.facade.GetService<ShipmentOrderService>().CreateNewDtoInstance();
    }

    #endregion


    /// <summary>
    /// Fonction du bouton quitter permettant de quitter l'application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
