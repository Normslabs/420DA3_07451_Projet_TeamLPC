namespace _420DA3_07451_Projet_Initial.Presentation;

partial class AdresseManagementForm {
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
        panel2 = new Panel();
        panel3 = new Panel();
        adresseIdLabel = new Label();
        IdField = new NumericUpDown();
        villeLabel = new Label();
        villeTextBox = new TextBox();
        numerociviqueLabel = new Label();
        numerociviqueTextBox = new TextBox();
        paysLabel = new Label();
        paysTextBox = new TextBox();
        codepostalLabel = new Label();
        codepostalTextBox = new TextBox();
        provinceLabel = new Label();
        provinceTextBox = new TextBox();
        rueLabel = new Label();
        rueTextBox = new TextBox();
        actionButton = new Button();
        cancelButton = new Button();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) IdField).BeginInit();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Controls.Add(panel2, 0, 2);
        tableLayoutPanel1.Controls.Add(panel3, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.Size = new Size(329, 517);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(rueTextBox);
        panel1.Controls.Add(rueLabel);
        panel1.Controls.Add(provinceTextBox);
        panel1.Controls.Add(provinceLabel);
        panel1.Controls.Add(codepostalTextBox);
        panel1.Controls.Add(codepostalLabel);
        panel1.Controls.Add(paysTextBox);
        panel1.Controls.Add(paysLabel);
        panel1.Controls.Add(numerociviqueTextBox);
        panel1.Controls.Add(numerociviqueLabel);
        panel1.Controls.Add(villeTextBox);
        panel1.Controls.Add(villeLabel);
        panel1.Controls.Add(IdField);
        panel1.Controls.Add(adresseIdLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 54);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(20);
        panel1.Size = new Size(323, 381);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(cancelButton);
        panel2.Controls.Add(actionButton);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 441);
        panel2.Name = "panel2";
        panel2.Size = new Size(323, 73);
        panel2.TabIndex = 1;
        // 
        // panel3
        // 
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(3, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(323, 45);
        panel3.TabIndex = 2;
        // 
        // adresseIdLabel
        // 
        adresseIdLabel.Dock = DockStyle.Top;
        adresseIdLabel.Location = new Point(20, 20);
        adresseIdLabel.Name = "adresseIdLabel";
        adresseIdLabel.Size = new Size(283, 23);
        adresseIdLabel.TabIndex = 0;
        adresseIdLabel.Text = "ID : ";
        // 
        // IdField
        // 
        IdField.Dock = DockStyle.Top;
        IdField.Enabled = false;
        IdField.Location = new Point(20, 43);
        IdField.Name = "IdField";
        IdField.Size = new Size(283, 23);
        IdField.TabIndex = 1;
        // 
        // villeLabel
        // 
        villeLabel.Dock = DockStyle.Top;
        villeLabel.Location = new Point(20, 66);
        villeLabel.Name = "villeLabel";
        villeLabel.Size = new Size(283, 23);
        villeLabel.TabIndex = 2;
        villeLabel.Text = "Ville : ";
        // 
        // villeTextBox
        // 
        villeTextBox.Dock = DockStyle.Top;
        villeTextBox.Location = new Point(20, 89);
        villeTextBox.Name = "villeTextBox";
        villeTextBox.Size = new Size(283, 23);
        villeTextBox.TabIndex = 3;
        // 
        // numerociviqueLabel
        // 
        numerociviqueLabel.Dock = DockStyle.Top;
        numerociviqueLabel.Location = new Point(20, 112);
        numerociviqueLabel.Name = "numerociviqueLabel";
        numerociviqueLabel.Size = new Size(283, 23);
        numerociviqueLabel.TabIndex = 4;
        numerociviqueLabel.Text = "Numéro Civique :";
        // 
        // numerociviqueTextBox
        // 
        numerociviqueTextBox.Dock = DockStyle.Top;
        numerociviqueTextBox.Location = new Point(20, 135);
        numerociviqueTextBox.Name = "numerociviqueTextBox";
        numerociviqueTextBox.Size = new Size(283, 23);
        numerociviqueTextBox.TabIndex = 5;
        // 
        // paysLabel
        // 
        paysLabel.Dock = DockStyle.Top;
        paysLabel.Location = new Point(20, 158);
        paysLabel.Name = "paysLabel";
        paysLabel.Size = new Size(283, 23);
        paysLabel.TabIndex = 6;
        paysLabel.Text = "Pays : ";
        // 
        // paysTextBox
        // 
        paysTextBox.Dock = DockStyle.Top;
        paysTextBox.Location = new Point(20, 181);
        paysTextBox.Name = "paysTextBox";
        paysTextBox.Size = new Size(283, 23);
        paysTextBox.TabIndex = 7;
        // 
        // codepostalLabel
        // 
        codepostalLabel.Dock = DockStyle.Top;
        codepostalLabel.Location = new Point(20, 204);
        codepostalLabel.Name = "codepostalLabel";
        codepostalLabel.Size = new Size(283, 23);
        codepostalLabel.TabIndex = 8;
        codepostalLabel.Text = "Code Postal :";
        // 
        // codepostalTextBox
        // 
        codepostalTextBox.Dock = DockStyle.Top;
        codepostalTextBox.Location = new Point(20, 227);
        codepostalTextBox.Name = "codepostalTextBox";
        codepostalTextBox.Size = new Size(283, 23);
        codepostalTextBox.TabIndex = 9;
        // 
        // provinceLabel
        // 
        provinceLabel.Dock = DockStyle.Top;
        provinceLabel.Location = new Point(20, 250);
        provinceLabel.Name = "provinceLabel";
        provinceLabel.Size = new Size(283, 23);
        provinceLabel.TabIndex = 10;
        provinceLabel.Text = "Province : ";
        // 
        // provinceTextBox
        // 
        provinceTextBox.Dock = DockStyle.Top;
        provinceTextBox.Location = new Point(20, 273);
        provinceTextBox.Name = "provinceTextBox";
        provinceTextBox.Size = new Size(283, 23);
        provinceTextBox.TabIndex = 11;
        // 
        // rueLabel
        // 
        rueLabel.Dock = DockStyle.Top;
        rueLabel.Location = new Point(20, 296);
        rueLabel.Name = "rueLabel";
        rueLabel.Size = new Size(283, 23);
        rueLabel.TabIndex = 12;
        rueLabel.Text = "Rue : ";
        // 
        // rueTextBox
        // 
        rueTextBox.Dock = DockStyle.Top;
        rueTextBox.Location = new Point(20, 319);
        rueTextBox.Name = "rueTextBox";
        rueTextBox.Size = new Size(283, 23);
        rueTextBox.TabIndex = 13;
        // 
        // actionButton
        // 
        actionButton.Location = new Point(40, 21);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(96, 30);
        actionButton.TabIndex = 0;
        actionButton.Text = "ACTION";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(168, 21);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(96, 30);
        cancelButton.TabIndex = 1;
        cancelButton.Text = "Annuler";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // AdresseManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(329, 517);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "AdresseManagementForm";
        this.Text = "AdresseManagementForm";
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) IdField).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Label villeLabel;
    private NumericUpDown IdField;
    private Label adresseIdLabel;
    private TextBox villeTextBox;
    private TextBox numerociviqueTextBox;
    private Label numerociviqueLabel;
    private TextBox provinceTextBox;
    private Label provinceLabel;
    private TextBox codepostalTextBox;
    private Label codepostalLabel;
    private TextBox paysTextBox;
    private Label paysLabel;
    private TextBox rueTextBox;
    private Label rueLabel;
    private Button cancelButton;
    private Button actionButton;
}