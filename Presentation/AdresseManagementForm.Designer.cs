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
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        IdLabel = new Label();
        IdField = new NumericUpDown();
        villeLabel = new Label();
        villeTextBox = new TextBox();
        numeriqueciviqueLabel = new Label();
        numerociviqueTextBox = new TextBox();
        paysLabel = new Label();
        paysTextBox = new TextBox();
        codepostalLabel = new Label();
        codepostalTextBox = new TextBox();
        provinceLabel = new Label();
        panel2 = new Panel();
        provinceTextBox = new TextBox();
        rueLabel = new Label();
        rueTextBox = new TextBox();
        cancelButton = new Button();
        actionButton = new Button();
        quitButton = new Button();
        actionnButton = new Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) IdField).BeginInit();
        panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.8050842F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1949148F));
        tableLayoutPanel1.Size = new Size(380, 472);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3180428F));
        tableLayoutPanel2.Controls.Add(panel2, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(374, 399);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(actionnButton);
        panel1.Controls.Add(quitButton);
        panel1.Controls.Add(actionButton);
        panel1.Controls.Add(cancelButton);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 408);
        panel1.Name = "panel1";
        panel1.Size = new Size(374, 61);
        panel1.TabIndex = 1;
        // 
        // IdLabel
        // 
        IdLabel.Dock = DockStyle.Top;
        IdLabel.Location = new Point(20, 20);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(328, 23);
        IdLabel.TabIndex = 0;
        IdLabel.Text = "ID :";
        IdLabel.Click += this.label1_Click;
        // 
        // IdField
        // 
        IdField.Dock = DockStyle.Top;
        IdField.Enabled = false;
        IdField.Location = new Point(20, 43);
        IdField.Name = "IdField";
        IdField.Size = new Size(328, 23);
        IdField.TabIndex = 1;
        // 
        // villeLabel
        // 
        villeLabel.Dock = DockStyle.Top;
        villeLabel.Location = new Point(20, 66);
        villeLabel.Name = "villeLabel";
        villeLabel.Size = new Size(328, 23);
        villeLabel.TabIndex = 2;
        villeLabel.Text = "Ville :";
        // 
        // villeTextBox
        // 
        villeTextBox.Dock = DockStyle.Top;
        villeTextBox.Location = new Point(20, 89);
        villeTextBox.Name = "villeTextBox";
        villeTextBox.Size = new Size(328, 23);
        villeTextBox.TabIndex = 3;
        // 
        // numeriqueciviqueLabel
        // 
        numeriqueciviqueLabel.Dock = DockStyle.Top;
        numeriqueciviqueLabel.Location = new Point(20, 112);
        numeriqueciviqueLabel.Name = "numeriqueciviqueLabel";
        numeriqueciviqueLabel.Size = new Size(328, 23);
        numeriqueciviqueLabel.TabIndex = 4;
        numeriqueciviqueLabel.Text = "Numéro Civique : ";
        // 
        // numerociviqueTextBox
        // 
        numerociviqueTextBox.Dock = DockStyle.Top;
        numerociviqueTextBox.Location = new Point(20, 135);
        numerociviqueTextBox.Name = "numerociviqueTextBox";
        numerociviqueTextBox.Size = new Size(328, 23);
        numerociviqueTextBox.TabIndex = 5;
        // 
        // paysLabel
        // 
        paysLabel.Dock = DockStyle.Top;
        paysLabel.Location = new Point(20, 158);
        paysLabel.Name = "paysLabel";
        paysLabel.Size = new Size(328, 23);
        paysLabel.TabIndex = 6;
        paysLabel.Text = "Pays :";
        // 
        // paysTextBox
        // 
        paysTextBox.Dock = DockStyle.Top;
        paysTextBox.Location = new Point(20, 181);
        paysTextBox.Name = "paysTextBox";
        paysTextBox.Size = new Size(328, 23);
        paysTextBox.TabIndex = 7;
        // 
        // codepostalLabel
        // 
        codepostalLabel.Dock = DockStyle.Top;
        codepostalLabel.Location = new Point(20, 204);
        codepostalLabel.Name = "codepostalLabel";
        codepostalLabel.Size = new Size(328, 23);
        codepostalLabel.TabIndex = 8;
        codepostalLabel.Text = "Code Postal : ";
        // 
        // codepostalTextBox
        // 
        codepostalTextBox.Dock = DockStyle.Top;
        codepostalTextBox.Location = new Point(20, 227);
        codepostalTextBox.Name = "codepostalTextBox";
        codepostalTextBox.Size = new Size(328, 23);
        codepostalTextBox.TabIndex = 9;
        // 
        // provinceLabel
        // 
        provinceLabel.Dock = DockStyle.Top;
        provinceLabel.Location = new Point(20, 250);
        provinceLabel.Name = "provinceLabel";
        provinceLabel.Size = new Size(328, 23);
        provinceLabel.TabIndex = 10;
        provinceLabel.Text = "Province :";
        // 
        // panel2
        // 
        panel2.Controls.Add(rueTextBox);
        panel2.Controls.Add(rueLabel);
        panel2.Controls.Add(provinceTextBox);
        panel2.Controls.Add(provinceLabel);
        panel2.Controls.Add(codepostalTextBox);
        panel2.Controls.Add(codepostalLabel);
        panel2.Controls.Add(paysTextBox);
        panel2.Controls.Add(paysLabel);
        panel2.Controls.Add(numerociviqueTextBox);
        panel2.Controls.Add(numeriqueciviqueLabel);
        panel2.Controls.Add(villeTextBox);
        panel2.Controls.Add(villeLabel);
        panel2.Controls.Add(IdField);
        panel2.Controls.Add(IdLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 3);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(20);
        panel2.Size = new Size(368, 393);
        panel2.TabIndex = 0;
        // 
        // provinceTextBox
        // 
        provinceTextBox.Dock = DockStyle.Top;
        provinceTextBox.Location = new Point(20, 273);
        provinceTextBox.Name = "provinceTextBox";
        provinceTextBox.Size = new Size(328, 23);
        provinceTextBox.TabIndex = 11;
        // 
        // rueLabel
        // 
        rueLabel.Dock = DockStyle.Top;
        rueLabel.Location = new Point(20, 296);
        rueLabel.Name = "rueLabel";
        rueLabel.Size = new Size(328, 23);
        rueLabel.TabIndex = 12;
        rueLabel.Text = "Rue :";
        // 
        // rueTextBox
        // 
        rueTextBox.Dock = DockStyle.Top;
        rueTextBox.Location = new Point(20, 319);
        rueTextBox.Name = "rueTextBox";
        rueTextBox.Size = new Size(328, 23);
        rueTextBox.TabIndex = 13;
        // 
        // cancelButton
        // 
        cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        cancelButton.Location = new Point(264, 91);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(101, 32);
        cancelButton.TabIndex = 0;
        cancelButton.Text = "Annuler";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // actionButton
        // 
        actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionButton.Location = new Point(143, 91);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(101, 32);
        actionButton.TabIndex = 1;
        actionButton.Text = "ACTION";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // quitButton
        // 
        quitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        quitButton.Location = new Point(254, 21);
        quitButton.Name = "quitButton";
        quitButton.Size = new Size(111, 31);
        quitButton.TabIndex = 2;
        quitButton.Text = "Annuler";
        quitButton.UseVisualStyleBackColor = true;
        quitButton.Click += this.button1_Click;
        // 
        // actionnButton
        // 
        actionnButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionnButton.Location = new Point(133, 21);
        actionnButton.Name = "actionnButton";
        actionnButton.Size = new Size(111, 31);
        actionnButton.TabIndex = 3;
        actionnButton.Text = "ACTION";
        actionnButton.UseVisualStyleBackColor = true;
        // 
        // AdresseManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(380, 472);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "AdresseManagementForm";
        this.Text = "AdresseManagementForm";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) IdField).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel1;
    private Panel panel2;
    private TextBox rueTextBox;
    private Label rueLabel;
    private TextBox provinceTextBox;
    private Label provinceLabel;
    private TextBox codepostalTextBox;
    private Label codepostalLabel;
    private TextBox paysTextBox;
    private Label paysLabel;
    private TextBox numerociviqueTextBox;
    private Label numeriqueciviqueLabel;
    private TextBox villeTextBox;
    private Label villeLabel;
    private NumericUpDown IdField;
    private Label IdLabel;
    private Button actionButton;
    private Button cancelButton;
    private Button quitButton;
    private Button actionnButton;
    private TextBox textBox1;
    private Label label1;
}