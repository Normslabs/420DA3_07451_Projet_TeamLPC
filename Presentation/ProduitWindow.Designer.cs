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
        this.CreateButton = new Button();
        this.EditButton = new Button();
        this.DeleteButton = new Button();
        this.ExitButton = new Button();
        this.produitListView = new ListView();
        this.ProductNameTextBox = new TextBox();
        this.ByNameButton = new Button();
        this.button1 = new Button();
        this.ProductUPCTextBox = new TextBox();
        this.SuspendLayout();
        // 
        // CreateButton
        // 
        this.CreateButton.Location = new Point(406, 239);
        this.CreateButton.Name = "CreateButton";
        this.CreateButton.Size = new Size(167, 23);
        this.CreateButton.TabIndex = 0;
        this.CreateButton.Text = "Create new Product";
        this.CreateButton.UseVisualStyleBackColor = true;
        this.CreateButton.Click += this.button1_Click;
        // 
        // EditButton
        // 
        this.EditButton.Location = new Point(405, 268);
        this.EditButton.Name = "EditButton";
        this.EditButton.Size = new Size(167, 23);
        this.EditButton.TabIndex = 1;
        this.EditButton.Text = "Edit Selected Product";
        this.EditButton.UseVisualStyleBackColor = true;
        this.EditButton.Click += this.EditButton_Click;
        // 
        // DeleteButton
        // 
        this.DeleteButton.Location = new Point(405, 297);
        this.DeleteButton.Name = "DeleteButton";
        this.DeleteButton.Size = new Size(167, 23);
        this.DeleteButton.TabIndex = 2;
        this.DeleteButton.Text = "Delete Selected Product";
        this.DeleteButton.UseVisualStyleBackColor = true;
        this.DeleteButton.Click += this.DeleteButton_Click;
        // 
        // ExitButton
        // 
        this.ExitButton.Location = new Point(406, 326);
        this.ExitButton.Name = "ExitButton";
        this.ExitButton.Size = new Size(167, 23);
        this.ExitButton.TabIndex = 3;
        this.ExitButton.Text = "Exit";
        this.ExitButton.UseVisualStyleBackColor = true;
        this.ExitButton.Click += this.ExitButton_Click;
        // 
        // produitListView
        // 
        this.produitListView.Dock = DockStyle.Left;
        this.produitListView.Location = new Point(0, 0);
        this.produitListView.Name = "produitListView";
        this.produitListView.Size = new Size(374, 361);
        this.produitListView.TabIndex = 4;
        this.produitListView.UseCompatibleStateImageBehavior = false;
        this.produitListView.SelectedIndexChanged += this.produitListView_SelectedIndexChanged;
        // 
        // ProductNameTextBox
        // 
        this.ProductNameTextBox.Location = new Point(405, 12);
        this.ProductNameTextBox.Name = "ProductNameTextBox";
        this.ProductNameTextBox.Size = new Size(168, 23);
        this.ProductNameTextBox.TabIndex = 5;
        this.ProductNameTextBox.TextChanged += this.ProductNameTextBox_TextChanged;
        // 
        // ByNameButton
        // 
        this.ByNameButton.Location = new Point(406, 52);
        this.ByNameButton.Name = "ByNameButton";
        this.ByNameButton.Size = new Size(167, 23);
        this.ByNameButton.TabIndex = 6;
        this.ByNameButton.Text = "Search Product by name";
        this.ByNameButton.UseVisualStyleBackColor = true;
        this.ByNameButton.Click += this.ByNameButton_Click;
        // 
        // button1
        // 
        this.button1.Location = new Point(405, 137);
        this.button1.Name = "button1";
        this.button1.Size = new Size(167, 23);
        this.button1.TabIndex = 7;
        this.button1.Text = "Search Product by UPC Code";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += this.button1_Click_1;
        // 
        // ProductUPCTextBox
        // 
        this.ProductUPCTextBox.Location = new Point(405, 94);
        this.ProductUPCTextBox.Name = "ProductUPCTextBox";
        this.ProductUPCTextBox.Size = new Size(168, 23);
        this.ProductUPCTextBox.TabIndex = 8;
        this.ProductUPCTextBox.TextChanged += this.ProductUPCTextBox_TextChanged;
        // 
        // ProduitWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(584, 361);
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
        this.Load += this.ProduitWindow_Load;
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