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
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ByNameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductUPCTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(406, 239);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(167, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create new Product";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(405, 268);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(167, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Selected Product";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(405, 297);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(167, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete Selected Product";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(406, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(405, 12);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(168, 23);
            this.ProductNameTextBox.TabIndex = 5;
            // 
            // ByNameButton
            // 
            this.ByNameButton.Location = new System.Drawing.Point(406, 52);
            this.ByNameButton.Name = "ByNameButton";
            this.ByNameButton.Size = new System.Drawing.Size(167, 23);
            this.ByNameButton.TabIndex = 6;
            this.ByNameButton.Text = "Search Product by name";
            this.ByNameButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search Product by UPC Code";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductUPCTextBox
            // 
            this.ProductUPCTextBox.Location = new System.Drawing.Point(405, 94);
            this.ProductUPCTextBox.Name = "ProductUPCTextBox";
            this.ProductUPCTextBox.Size = new System.Drawing.Size(168, 23);
            this.ProductUPCTextBox.TabIndex = 8;
            // 
            // ProduitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ProductUPCTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ByNameButton);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.produitListView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "ProduitWindow";
            this.Text = "ProduitWindow";
            this.Load += new System.EventHandler(this.ProduitWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button CreateButton;
    private Button EditButton;
    private Button DeleteButton;
    private Button ExitButton;
    private ListView produitListView;
    private TextBox ProductNameTextBox;
    private Button ByNameButton;
    private Button button1;
    private TextBox ProductUPCTextBox;
}