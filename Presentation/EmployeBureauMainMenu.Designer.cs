﻿namespace _420DA3_07451_Projet_Initial.Presentation;

partial class EmployeBureauMainMenu {
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
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        GestionClientLabel = new Label();
        ClientCreateBtn = new Button();
        ClientFiltretextBox = new TextBox();
        ClientlistBox = new ListBox();
        GestionShippingOrderLabel = new Label();
        ShippingOrderCreateBtn = new Button();
        panel2 = new Panel();
        ClientViewBtn = new Button();
        ClientEditBtn = new Button();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 5;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(panel2, 3, 0);
        tableLayoutPanel1.Controls.Add(panel1, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(ClientViewBtn);
        panel1.Controls.Add(ClientEditBtn);
        panel1.Controls.Add(ClientlistBox);
        panel1.Controls.Add(ClientFiltretextBox);
        panel1.Controls.Add(ClientCreateBtn);
        panel1.Controls.Add(GestionClientLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(93, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(294, 444);
        panel1.TabIndex = 0;
        // 
        // GestionClientLabel
        // 
        GestionClientLabel.Dock = DockStyle.Top;
        GestionClientLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
        GestionClientLabel.Location = new Point(0, 0);
        GestionClientLabel.Name = "GestionClientLabel";
        GestionClientLabel.Size = new Size(294, 30);
        GestionClientLabel.TabIndex = 0;
        GestionClientLabel.Text = "Gestion des clients";
        GestionClientLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ClientCreateBtn
        // 
        ClientCreateBtn.Dock = DockStyle.Top;
        ClientCreateBtn.Location = new Point(0, 30);
        ClientCreateBtn.Name = "ClientCreateBtn";
        ClientCreateBtn.Size = new Size(294, 23);
        ClientCreateBtn.TabIndex = 2;
        ClientCreateBtn.Text = "Creer un client";
        ClientCreateBtn.UseVisualStyleBackColor = true;
        ClientCreateBtn.Click += this.ClientCreateBtn_Click;
        // 
        // ClientFiltretextBox
        // 
        ClientFiltretextBox.Dock = DockStyle.Top;
        ClientFiltretextBox.Location = new Point(0, 53);
        ClientFiltretextBox.Name = "ClientFiltretextBox";
        ClientFiltretextBox.Size = new Size(294, 23);
        ClientFiltretextBox.TabIndex = 1;
        ClientFiltretextBox.TextChanged += this.ClientFiltretextBox_TextChanged;
        // 
        // ClientlistBox
        // 
        ClientlistBox.Dock = DockStyle.Top;
        ClientlistBox.FormattingEnabled = true;
        ClientlistBox.ItemHeight = 15;
        ClientlistBox.Location = new Point(0, 76);
        ClientlistBox.Name = "ClientlistBox";
        ClientlistBox.Size = new Size(294, 94);
        ClientlistBox.TabIndex = 3;
        ClientlistBox.SelectedIndexChanged += this.ClientlistBox_SelectedIndexChanged;
        // 
        // GestionShippingOrderLabel
        // 
        GestionShippingOrderLabel.Dock = DockStyle.Top;
        GestionShippingOrderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
        GestionShippingOrderLabel.Location = new Point(0, 0);
        GestionShippingOrderLabel.Name = "GestionShippingOrderLabel";
        GestionShippingOrderLabel.Size = new Size(294, 30);
        GestionShippingOrderLabel.TabIndex = 1;
        GestionShippingOrderLabel.Text = "Gestion des shipping order";
        GestionShippingOrderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ShippingOrderCreateBtn
        // 
        ShippingOrderCreateBtn.Dock = DockStyle.Top;
        ShippingOrderCreateBtn.Location = new Point(0, 30);
        ShippingOrderCreateBtn.Name = "ShippingOrderCreateBtn";
        ShippingOrderCreateBtn.Size = new Size(294, 23);
        ShippingOrderCreateBtn.TabIndex = 3;
        ShippingOrderCreateBtn.Text = "Creer un shipping order";
        ShippingOrderCreateBtn.UseVisualStyleBackColor = true;
        ShippingOrderCreateBtn.Click += this.ShippingOrderCreateBtn_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(ShippingOrderCreateBtn);
        panel2.Controls.Add(GestionShippingOrderLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(413, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(294, 444);
        panel2.TabIndex = 0;
        // 
        // ClientViewBtn
        // 
        ClientViewBtn.Dock = DockStyle.Top;
        ClientViewBtn.Location = new Point(0, 193);
        ClientViewBtn.Name = "ClientViewBtn";
        ClientViewBtn.Size = new Size(294, 23);
        ClientViewBtn.TabIndex = 8;
        ClientViewBtn.Text = "Voir un client";
        ClientViewBtn.UseVisualStyleBackColor = true;
        ClientViewBtn.Click += this.ClientViewBtn_Click;
        // 
        // ClientEditBtn
        // 
        ClientEditBtn.Dock = DockStyle.Top;
        ClientEditBtn.Location = new Point(0, 170);
        ClientEditBtn.Name = "ClientEditBtn";
        ClientEditBtn.Size = new Size(294, 23);
        ClientEditBtn.TabIndex = 7;
        ClientEditBtn.Text = "Modifier un client";
        ClientEditBtn.UseVisualStyleBackColor = true;
        ClientEditBtn.Click += this.ClientEditBtn_Click;
        // 
        // EmployeBureauMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "EmployeBureauMainMenu";
        this.Text = "EmployeBureauMainMenu";
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Label GestionClientLabel;
    private Button ClientCreateBtn;
    private Panel panel2;
    private Button ShippingOrderCreateBtn;
    private Label GestionShippingOrderLabel;
    private Button ClientViewBtn;
    private Button ClientEditBtn;
    private ListBox ClientlistBox;
    private TextBox ClientFiltretextBox;
}