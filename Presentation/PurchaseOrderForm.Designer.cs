﻿namespace _420DA3_07451_Projet_Initial.Presentation;

partial class PurchaseOrderForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.entrepotComboBox = new System.Windows.Forms.ComboBox();
            this.Entrepotlabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.QTYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.QTYlabel = new System.Windows.Forms.Label();
            this.produitListView = new System.Windows.Forms.ListView();
            this.listProduitLabel = new System.Windows.Forms.Label();
            this.produitTextBox = new System.Windows.Forms.TextBox();
            this.RechercheLabel = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.poIdLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QTYnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnnulerBtn);
            this.panel1.Controls.Add(this.ActionBtn);
            this.panel1.Controls.Add(this.entrepotComboBox);
            this.panel1.Controls.Add(this.Entrepotlabel);
            this.panel1.Controls.Add(this.StatusComboBox);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.QTYnumericUpDown);
            this.panel1.Controls.Add(this.QTYlabel);
            this.panel1.Controls.Add(this.produitListView);
            this.panel1.Controls.Add(this.listProduitLabel);
            this.panel1.Controls.Add(this.produitTextBox);
            this.panel1.Controls.Add(this.RechercheLabel);
            this.panel1.Controls.Add(this.idNumericUpDown);
            this.panel1.Controls.Add(this.poIdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(109, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 511);
            this.panel1.TabIndex = 0;
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnulerBtn.Location = new System.Drawing.Point(413, 461);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(75, 41);
            this.AnnulerBtn.TabIndex = 13;
            this.AnnulerBtn.Text = "Annuler";
            this.AnnulerBtn.UseVisualStyleBackColor = true;
            this.AnnulerBtn.Click += new System.EventHandler(this.AnnulerBtn_Click);
            // 
            // ActionBtn
            // 
            this.ActionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ActionBtn.Location = new System.Drawing.Point(3, 461);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(75, 41);
            this.ActionBtn.TabIndex = 12;
            this.ActionBtn.Text = "Action";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // entrepotComboBox
            // 
            this.entrepotComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotComboBox.FormattingEnabled = true;
            this.entrepotComboBox.Location = new System.Drawing.Point(0, 393);
            this.entrepotComboBox.Name = "entrepotComboBox";
            this.entrepotComboBox.Size = new System.Drawing.Size(491, 23);
            this.entrepotComboBox.TabIndex = 11;
            // 
            // Entrepotlabel
            // 
            this.Entrepotlabel.AutoSize = true;
            this.Entrepotlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entrepotlabel.Location = new System.Drawing.Point(0, 378);
            this.Entrepotlabel.Name = "Entrepotlabel";
            this.Entrepotlabel.Size = new System.Drawing.Size(89, 15);
            this.Entrepotlabel.TabIndex = 10;
            this.Entrepotlabel.Text = "Entrepôt stocké";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(0, 355);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(491, 23);
            this.StatusComboBox.TabIndex = 9;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.Status.Location = new System.Drawing.Point(0, 340);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(131, 15);
            this.Status.TabIndex = 8;
            this.Status.Text = "Status de la commande";
            // 
            // QTYnumericUpDown
            // 
            this.QTYnumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.QTYnumericUpDown.Location = new System.Drawing.Point(0, 317);
            this.QTYnumericUpDown.Name = "QTYnumericUpDown";
            this.QTYnumericUpDown.Size = new System.Drawing.Size(491, 23);
            this.QTYnumericUpDown.TabIndex = 7;
            // 
            // QTYlabel
            // 
            this.QTYlabel.AutoSize = true;
            this.QTYlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QTYlabel.Location = new System.Drawing.Point(0, 302);
            this.QTYlabel.Name = "QTYlabel";
            this.QTYlabel.Size = new System.Drawing.Size(130, 15);
            this.QTYlabel.TabIndex = 6;
            this.QTYlabel.Text = "Quantité à commander";
            // 
            // produitListView
            // 
            this.produitListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.produitListView.Location = new System.Drawing.Point(0, 91);
            this.produitListView.Name = "produitListView";
            this.produitListView.Size = new System.Drawing.Size(491, 211);
            this.produitListView.TabIndex = 5;
            this.produitListView.UseCompatibleStateImageBehavior = false;
            // 
            // listProduitLabel
            // 
            this.listProduitLabel.AutoSize = true;
            this.listProduitLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listProduitLabel.Location = new System.Drawing.Point(0, 76);
            this.listProduitLabel.Name = "listProduitLabel";
            this.listProduitLabel.Size = new System.Drawing.Size(99, 15);
            this.listProduitLabel.TabIndex = 4;
            this.listProduitLabel.Tag = "";
            this.listProduitLabel.Text = "Liste des produits";
            // 
            // produitTextBox
            // 
            this.produitTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.produitTextBox.Location = new System.Drawing.Point(0, 53);
            this.produitTextBox.Name = "produitTextBox";
            this.produitTextBox.Size = new System.Drawing.Size(491, 23);
            this.produitTextBox.TabIndex = 3;
            // 
            // RechercheLabel
            // 
            this.RechercheLabel.AutoSize = true;
            this.RechercheLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RechercheLabel.Location = new System.Drawing.Point(0, 38);
            this.RechercheLabel.Name = "RechercheLabel";
            this.RechercheLabel.Size = new System.Drawing.Size(101, 15);
            this.RechercheLabel.TabIndex = 2;
            this.RechercheLabel.Text = "Produit recherché";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.idNumericUpDown.Location = new System.Drawing.Point(0, 15);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(491, 23);
            this.idNumericUpDown.TabIndex = 1;
            // 
            // poIdLabel
            // 
            this.poIdLabel.AutoSize = true;
            this.poIdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.poIdLabel.Location = new System.Drawing.Point(0, 0);
            this.poIdLabel.Name = "poIdLabel";
            this.poIdLabel.Size = new System.Drawing.Size(76, 15);
            this.poIdLabel.TabIndex = 0;
            this.poIdLabel.Text = "Id du produit";
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PurchaseOrderForm";
            this.Text = "PurchaseOrderForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QTYnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Label poIdLabel;
    private Button AnnulerBtn;
    private Button ActionBtn;
    private ComboBox entrepotComboBox;
    private Label Entrepotlabel;
    private ComboBox StatusComboBox;
    private Label Status;
    private NumericUpDown QTYnumericUpDown;
    private Label QTYlabel;
    private ListView produitListView;
    private Label listProduitLabel;
    private TextBox produitTextBox;
    private Label RechercheLabel;
    private NumericUpDown idNumericUpDown;
}