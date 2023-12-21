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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entrepotadresseComboBox = new System.Windows.Forms.ComboBox();
            this.adresseentrepotLabel = new System.Windows.Forms.Label();
            this.entrepotnameTextBox = new System.Windows.Forms.TextBox();
            this.entrepotnameLabel = new System.Windows.Forms.Label();
            this.entrepotidField = new System.Windows.Forms.NumericUpDown();
            this.entrepotidLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createadresseBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepotidField)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ActionButton);
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 57);
            this.panel1.TabIndex = 0;
            // 
            // ActionButton
            // 
            this.ActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionButton.Location = new System.Drawing.Point(361, 15);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(107, 30);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "ACTION";
            this.ActionButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.Location = new System.Drawing.Point(486, 15);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(107, 30);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Annuler";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 285);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(137, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panel2.Size = new System.Drawing.Size(331, 279);
            this.panel2.TabIndex = 0;
            // 
            // entrepotadresseComboBox
            // 
            this.entrepotadresseComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotadresseComboBox.FormattingEnabled = true;
            this.entrepotadresseComboBox.Location = new System.Drawing.Point(10, 127);
            this.entrepotadresseComboBox.Name = "entrepotadresseComboBox";
            this.entrepotadresseComboBox.Size = new System.Drawing.Size(311, 23);
            this.entrepotadresseComboBox.TabIndex = 5;
            // 
            // adresseentrepotLabel
            // 
            this.adresseentrepotLabel.AutoSize = true;
            this.adresseentrepotLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adresseentrepotLabel.Location = new System.Drawing.Point(10, 112);
            this.adresseentrepotLabel.Name = "adresseentrepotLabel";
            this.adresseentrepotLabel.Size = new System.Drawing.Size(115, 15);
            this.adresseentrepotLabel.TabIndex = 4;
            this.adresseentrepotLabel.Text = "Adresse d\'entrepot : ";
            // 
            // entrepotnameTextBox
            // 
            this.entrepotnameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotnameTextBox.Location = new System.Drawing.Point(10, 89);
            this.entrepotnameTextBox.Name = "entrepotnameTextBox";
            this.entrepotnameTextBox.PlaceholderText = "Nom d\'entrepot";
            this.entrepotnameTextBox.Size = new System.Drawing.Size(311, 23);
            this.entrepotnameTextBox.TabIndex = 3;
            // 
            // entrepotnameLabel
            // 
            this.entrepotnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotnameLabel.Location = new System.Drawing.Point(10, 66);
            this.entrepotnameLabel.Name = "entrepotnameLabel";
            this.entrepotnameLabel.Size = new System.Drawing.Size(311, 23);
            this.entrepotnameLabel.TabIndex = 2;
            this.entrepotnameLabel.Text = "Nom d\'entrepot : ";
            // 
            // entrepotidField
            // 
            this.entrepotidField.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotidField.Location = new System.Drawing.Point(10, 43);
            this.entrepotidField.Name = "entrepotidField";
            this.entrepotidField.Size = new System.Drawing.Size(311, 23);
            this.entrepotidField.TabIndex = 1;
            // 
            // entrepotidLabel
            // 
            this.entrepotidLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.entrepotidLabel.Location = new System.Drawing.Point(10, 20);
            this.entrepotidLabel.Name = "entrepotidLabel";
            this.entrepotidLabel.Size = new System.Drawing.Size(311, 23);
            this.entrepotidLabel.TabIndex = 0;
            this.entrepotidLabel.Text = "ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.createadresseBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(474, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 279);
            this.panel3.TabIndex = 1;
            // 
            // createadresseBtn
            // 
            this.createadresseBtn.Location = new System.Drawing.Point(10, 123);
            this.createadresseBtn.Name = "createadresseBtn";
            this.createadresseBtn.Size = new System.Drawing.Size(109, 29);
            this.createadresseBtn.TabIndex = 0;
            this.createadresseBtn.Text = "Crée Adresse";
            this.createadresseBtn.UseVisualStyleBackColor = true;
            // 
            // EntrepotManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "EntrepotManagementForm";
            this.Text = "EntrepotManagementForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepotidField)).EndInit();
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