namespace _420DA3_07451_Projet_Initial.Presentation;

partial class EntrepotManagementForm {
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
        this.panel1 = new Panel();
        this.ActionButton = new Button();
        this.QuitButton = new Button();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.entrepotadresseComboBox = new ComboBox();
        this.adresseentrepotLabel = new Label();
        this.entrepotnameTextBox = new TextBox();
        this.entrepotnameLabel = new Label();
        this.entrepotidField = new NumericUpDown();
        this.entrepotidLabel = new Label();
        this.panel3 = new Panel();
        this.createadresseBtn = new Button();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.entrepotidField).BeginInit();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.ActionButton);
        this.panel1.Controls.Add(this.QuitButton);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 285);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(607, 57);
        this.panel1.TabIndex = 0;
        // 
        // ActionButton
        // 
        this.ActionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.ActionButton.Location = new Point(361, 15);
        this.ActionButton.Name = "ActionButton";
        this.ActionButton.Size = new Size(107, 30);
        this.ActionButton.TabIndex = 1;
        this.ActionButton.Text = "ACTION";
        this.ActionButton.UseVisualStyleBackColor = true;
        this.ActionButton.Click += this.ActionButton_Click;
        // 
        // QuitButton
        // 
        this.QuitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.QuitButton.Location = new Point(486, 15);
        this.QuitButton.Name = "QuitButton";
        this.QuitButton.Size = new Size(107, 30);
        this.QuitButton.TabIndex = 0;
        this.QuitButton.Text = "Annuler";
        this.QuitButton.UseVisualStyleBackColor = true;
        this.QuitButton.Click += this.QuitButton_Click;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
        this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(607, 285);
        this.tableLayoutPanel1.TabIndex = 1;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.entrepotadresseComboBox);
        this.panel2.Controls.Add(this.adresseentrepotLabel);
        this.panel2.Controls.Add(this.entrepotnameTextBox);
        this.panel2.Controls.Add(this.entrepotnameLabel);
        this.panel2.Controls.Add(this.entrepotidField);
        this.panel2.Controls.Add(this.entrepotidLabel);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(137, 3);
        this.panel2.Name = "panel2";
        this.panel2.Padding = new Padding(10, 20, 10, 20);
        this.panel2.Size = new Size(331, 279);
        this.panel2.TabIndex = 0;
        // 
        // entrepotadresseComboBox
        // 
        this.entrepotadresseComboBox.Dock = DockStyle.Top;
        this.entrepotadresseComboBox.FormattingEnabled = true;
        this.entrepotadresseComboBox.Location = new Point(10, 127);
        this.entrepotadresseComboBox.Name = "entrepotadresseComboBox";
        this.entrepotadresseComboBox.Size = new Size(311, 23);
        this.entrepotadresseComboBox.TabIndex = 5;
        // 
        // adresseentrepotLabel
        // 
        this.adresseentrepotLabel.AutoSize = true;
        this.adresseentrepotLabel.Dock = DockStyle.Top;
        this.adresseentrepotLabel.Location = new Point(10, 112);
        this.adresseentrepotLabel.Name = "adresseentrepotLabel";
        this.adresseentrepotLabel.Size = new Size(115, 15);
        this.adresseentrepotLabel.TabIndex = 4;
        this.adresseentrepotLabel.Text = "Adresse d'entrepot : ";
        // 
        // entrepotnameTextBox
        // 
        this.entrepotnameTextBox.Dock = DockStyle.Top;
        this.entrepotnameTextBox.Location = new Point(10, 89);
        this.entrepotnameTextBox.Name = "entrepotnameTextBox";
        this.entrepotnameTextBox.PlaceholderText = "Nom d'entrepot";
        this.entrepotnameTextBox.Size = new Size(311, 23);
        this.entrepotnameTextBox.TabIndex = 3;
        // 
        // entrepotnameLabel
        // 
        this.entrepotnameLabel.Dock = DockStyle.Top;
        this.entrepotnameLabel.Location = new Point(10, 66);
        this.entrepotnameLabel.Name = "entrepotnameLabel";
        this.entrepotnameLabel.Size = new Size(311, 23);
        this.entrepotnameLabel.TabIndex = 2;
        this.entrepotnameLabel.Text = "Nom d'entrepot : ";
        // 
        // entrepotidField
        // 
        this.entrepotidField.Dock = DockStyle.Top;
        this.entrepotidField.Location = new Point(10, 43);
        this.entrepotidField.Name = "entrepotidField";
        this.entrepotidField.Size = new Size(311, 23);
        this.entrepotidField.TabIndex = 1;
        // 
        // entrepotidLabel
        // 
        this.entrepotidLabel.Dock = DockStyle.Top;
        this.entrepotidLabel.Location = new Point(10, 20);
        this.entrepotidLabel.Name = "entrepotidLabel";
        this.entrepotidLabel.Size = new Size(311, 23);
        this.entrepotidLabel.TabIndex = 0;
        this.entrepotidLabel.Text = "ID :";
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.createadresseBtn);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(474, 3);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(130, 279);
        this.panel3.TabIndex = 1;
        // 
        // createadresseBtn
        // 
        createadresseBtn.Location = new Point(12, 127);
        createadresseBtn.Name = "createadresseBtn";
        createadresseBtn.Size = new Size(109, 29);
        createadresseBtn.TabIndex = 0;
        createadresseBtn.Text = "Crée Adresse";
        createadresseBtn.UseVisualStyleBackColor = true;
        createadresseBtn.Click += this.CreateadresseBtn_Click;
        // 
        // EntrepotManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(607, 342);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.panel1);
        this.Name = "EntrepotManagementForm";
        this.Text = "EntrepotManagementForm";
        this.Load += this.EntrepotManagementForm_Load;
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.entrepotidField).EndInit();
        this.panel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel2;
    private NumericUpDown entrepotidField;
    private Label entrepotidLabel;
    private TextBox entrepotnameTextBox;
    private Label entrepotnameLabel;
    private ComboBox entrepotadresseComboBox;
    private Label adresseentrepotLabel;
    private Panel panel3;
    private Button createadresseBtn;
    private Button QuitButton;
    private Button ActionButton;
}