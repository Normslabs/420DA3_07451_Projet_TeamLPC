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
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel2 = new Panel();
        paysTextBox = new TextBox();
        paysLabel = new Label();
        provinceTextBox = new TextBox();
        provinceLabel = new Label();
        codepostalTextBox = new TextBox();
        codepostalLabel = new Label();
        villeTextBox = new TextBox();
        villeLabel = new Label();
        rueTextBox = new TextBox();
        rueLabel = new Label();
        numerociviqueTextBox = new TextBox();
        numerociviqueLabel = new Label();
        IdField = new NumericUpDown();
        IdLabel = new Label();
        panel1 = new Panel();
        ActionnButton = new Button();
        QuitButton = new Button();
        actionButton = new Button();
        cancelButton = new Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) IdField).BeginInit();
        panel1.SuspendLayout();
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
        // panel2
        // 
        panel2.Controls.Add(paysTextBox);
        panel2.Controls.Add(paysLabel);
        panel2.Controls.Add(provinceTextBox);
        panel2.Controls.Add(provinceLabel);
        panel2.Controls.Add(codepostalTextBox);
        panel2.Controls.Add(codepostalLabel);
        panel2.Controls.Add(villeTextBox);
        panel2.Controls.Add(villeLabel);
        panel2.Controls.Add(rueTextBox);
        panel2.Controls.Add(rueLabel);
        panel2.Controls.Add(numerociviqueTextBox);
        panel2.Controls.Add(numerociviqueLabel);
        panel2.Controls.Add(IdField);
        panel2.Controls.Add(IdLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 3);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(20);
        panel2.Size = new Size(368, 393);
        panel2.TabIndex = 0;
        // 
        // paysTextBox
        // 
        paysTextBox.Dock = DockStyle.Top;
        paysTextBox.Location = new Point(20, 319);
        paysTextBox.Name = "paysTextBox";
        paysTextBox.Size = new Size(328, 23);
        paysTextBox.TabIndex = 13;
        // 
        // paysLabel
        // 
        paysLabel.Dock = DockStyle.Top;
        paysLabel.Location = new Point(20, 296);
        paysLabel.Name = "paysLabel";
        paysLabel.Size = new Size(328, 23);
        paysLabel.TabIndex = 12;
        paysLabel.Text = "Pays :";
        // 
        // provinceTextBox
        // 
        provinceTextBox.Dock = DockStyle.Top;
        provinceTextBox.Location = new Point(20, 273);
        provinceTextBox.Name = "provinceTextBox";
        provinceTextBox.Size = new Size(328, 23);
        provinceTextBox.TabIndex = 11;
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
        // codepostalTextBox
        // 
        codepostalTextBox.Dock = DockStyle.Top;
        codepostalTextBox.Location = new Point(20, 227);
        codepostalTextBox.Name = "codepostalTextBox";
        codepostalTextBox.Size = new Size(328, 23);
        codepostalTextBox.TabIndex = 9;
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
        // villeTextBox
        // 
        villeTextBox.Dock = DockStyle.Top;
        villeTextBox.Location = new Point(20, 181);
        villeTextBox.Name = "villeTextBox";
        villeTextBox.Size = new Size(328, 23);
        villeTextBox.TabIndex = 7;
        // 
        // villeLabel
        // 
        villeLabel.Dock = DockStyle.Top;
        villeLabel.Location = new Point(20, 158);
        villeLabel.Name = "villeLabel";
        villeLabel.Size = new Size(328, 23);
        villeLabel.TabIndex = 6;
        villeLabel.Text = "Ville :";
        // 
        // rueTextBox
        // 
        rueTextBox.Dock = DockStyle.Top;
        rueTextBox.Location = new Point(20, 135);
        rueTextBox.Name = "rueTextBox";
        rueTextBox.Size = new Size(328, 23);
        rueTextBox.TabIndex = 5;
        // 
        // rueLabel
        // 
        rueLabel.Dock = DockStyle.Top;
        rueLabel.Location = new Point(20, 112);
        rueLabel.Name = "rueLabel";
        rueLabel.Size = new Size(328, 23);
        rueLabel.TabIndex = 4;
        rueLabel.Text = "Rue : ";
        // 
        // numerociviqueTextBox
        // 
        numerociviqueTextBox.Dock = DockStyle.Top;
        numerociviqueTextBox.Location = new Point(20, 89);
        numerociviqueTextBox.Name = "numerociviqueTextBox";
        numerociviqueTextBox.Size = new Size(328, 23);
        numerociviqueTextBox.TabIndex = 3;
        // 
        // numerociviqueLabel
        // 
        numerociviqueLabel.Dock = DockStyle.Top;
        numerociviqueLabel.Location = new Point(20, 66);
        numerociviqueLabel.Name = "numerociviqueLabel";
        numerociviqueLabel.Size = new Size(328, 23);
        numerociviqueLabel.TabIndex = 2;
        numerociviqueLabel.Text = "Numéro Civique : ";
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
        // IdLabel
        // 
        IdLabel.Dock = DockStyle.Top;
        IdLabel.Location = new Point(20, 20);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(328, 23);
        IdLabel.TabIndex = 0;
        IdLabel.Text = "ID :";
        // 
        // panel1
        // 
        panel1.Controls.Add(ActionnButton);
        panel1.Controls.Add(QuitButton);
        panel1.Controls.Add(actionButton);
        panel1.Controls.Add(cancelButton);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 408);
        panel1.Name = "panel1";
        panel1.Size = new Size(374, 61);
        panel1.TabIndex = 1;
        // 
        // ActionnButton
        // 
        ActionnButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        ActionnButton.Location = new Point(133, 21);
        ActionnButton.Name = "ActionnButton";
        ActionnButton.Size = new Size(111, 31);
        ActionnButton.TabIndex = 3;
        ActionnButton.Text = "ACTION";
        ActionnButton.UseVisualStyleBackColor = true;
        ActionnButton.Click += this.ActionnButton_Click;
        // 
        // QuitButton
        // 
        QuitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        QuitButton.Location = new Point(254, 21);
        QuitButton.Name = "QuitButton";
        QuitButton.Size = new Size(111, 31);
        QuitButton.TabIndex = 2;
        QuitButton.Text = "Annuler";
        QuitButton.UseVisualStyleBackColor = true;
        QuitButton.Click += this.QuitButton_Click;
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
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) IdField).EndInit();
        panel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel1;
    private Panel panel2;
    private TextBox paysTextBox;
    private Label paysLabel;
    private TextBox provinceTextBox;
    private Label provinceLabel;
    private TextBox codepostalTextBox;
    private Label codepostalLabel;
    private TextBox villeTextBox;
    private Label villeLabel;
    private TextBox rueTextBox;
    private Label rueLabel;
    private TextBox numerociviqueTextBox;
    private Label numerociviqueLabel;
    private NumericUpDown IdField;
    private Label IdLabel;
    private Button actionButton;
    private Button cancelButton;
    private Button QuitButton;
    private Button ActionnButton;
    private TextBox textBox1;
    private Label label1;
}