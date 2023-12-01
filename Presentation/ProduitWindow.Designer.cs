namespace _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;
partial class ProduitWindow {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }








    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.CreateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.produitListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(406, 43);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(167, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create new Product";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(406, 131);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(167, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Selected Product";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(406, 214);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(167, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete Selected Product";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(406, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // produitListView
            // 
            this.produitListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.produitListView.Location = new System.Drawing.Point(0, 0);
            this.produitListView.Name = "produitListView";
            this.produitListView.Size = new System.Drawing.Size(374, 361);
            this.produitListView.TabIndex = 4;
            this.produitListView.UseCompatibleStateImageBehavior = false;
            // 
            // ProduitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.produitListView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "ProduitWindow";
            this.Text = "ProduitWindow";
            this.Load += new System.EventHandler(this.ProduitWindow_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Button CreateButton;
    private Button EditButton;
    private Button DeleteButton;
    private Button ExitButton;
    private ListView produitListView;
}