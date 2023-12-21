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
        panel1 = new Panel();
        ActionButton = new Button();
        QuitButton = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel2 = new Panel();
        entrepotadresseComboBox = new ComboBox();
        adresseentrepotLabel = new Label();
        entrepotnameTextBox = new TextBox();
        entrepotnameLabel = new Label();
        entrepotidField = new NumericUpDown();
        entrepotidLabel = new Label();
        panel3 = new Panel();
        createadresseBtn = new Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) entrepotidField).BeginInit();
        panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(ActionButton);
        panel1.Controls.Add(QuitButton);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 285);
        panel1.Name = "panel1";
        panel1.Size = new Size(607, 57);
        panel1.TabIndex = 0;
        // 
        // ActionButton
        // 
        ActionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        ActionButton.Location = new Point(361, 15);
        ActionButton.Name = "ActionButton";
        ActionButton.Size = new Size(107, 30);
        ActionButton.TabIndex = 1;
        ActionButton.Text = "ACTION";
        ActionButton.UseVisualStyleBackColor = true;
        ActionButton.Click += this.ActionButton_Click;
        // 
        // QuitButton
        // 
        QuitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        QuitButton.Location = new Point(486, 15);
        QuitButton.Name = "QuitButton";
        QuitButton.Size = new Size(107, 30);
        QuitButton.TabIndex = 0;
        QuitButton.Text = "Annuler";
        QuitButton.UseVisualStyleBackColor = true;
        QuitButton.Click += this.QuitButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
        tableLayoutPanel1.Controls.Add(panel2, 1, 0);
        tableLayoutPanel1.Controls.Add(panel3, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(607, 285);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.Controls.Add(entrepotadresseComboBox);
        panel2.Controls.Add(adresseentrepotLabel);
        panel2.Controls.Add(entrepotnameTextBox);
        panel2.Controls.Add(entrepotnameLabel);
        panel2.Controls.Add(entrepotidField);
        panel2.Controls.Add(entrepotidLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(137, 3);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(10, 20, 10, 20);
        panel2.Size = new Size(331, 279);
        panel2.TabIndex = 0;
        // 
        // entrepotadresseComboBox
        // 
        entrepotadresseComboBox.Dock = DockStyle.Top;
        entrepotadresseComboBox.FormattingEnabled = true;
        entrepotadresseComboBox.Location = new Point(10, 127);
        entrepotadresseComboBox.Name = "entrepotadresseComboBox";
        entrepotadresseComboBox.Size = new Size(311, 23);
        entrepotadresseComboBox.TabIndex = 5;
        // 
        // adresseentrepotLabel
        // 
        adresseentrepotLabel.AutoSize = true;
        adresseentrepotLabel.Dock = DockStyle.Top;
        adresseentrepotLabel.Location = new Point(10, 112);
        adresseentrepotLabel.Name = "adresseentrepotLabel";
        adresseentrepotLabel.Size = new Size(115, 15);
        adresseentrepotLabel.TabIndex = 4;
        adresseentrepotLabel.Text = "Adresse d'entrepot : ";
        // 
        // entrepotnameTextBox
        // 
        entrepotnameTextBox.Dock = DockStyle.Top;
        entrepotnameTextBox.Location = new Point(10, 89);
        entrepotnameTextBox.Name = "entrepotnameTextBox";
        entrepotnameTextBox.PlaceholderText = "Nom d'entrepot";
        entrepotnameTextBox.Size = new Size(311, 23);
        entrepotnameTextBox.TabIndex = 3;
        // 
        // entrepotnameLabel
        // 
        entrepotnameLabel.Dock = DockStyle.Top;
        entrepotnameLabel.Location = new Point(10, 66);
        entrepotnameLabel.Name = "entrepotnameLabel";
        entrepotnameLabel.Size = new Size(311, 23);
        entrepotnameLabel.TabIndex = 2;
        entrepotnameLabel.Text = "Nom d'entrepot : ";
        // 
        // entrepotidField
        // 
        entrepotidField.Dock = DockStyle.Top;
        entrepotidField.Location = new Point(10, 43);
        entrepotidField.Name = "entrepotidField";
        entrepotidField.Size = new Size(311, 23);
        entrepotidField.TabIndex = 1;
        // 
        // entrepotidLabel
        // 
        entrepotidLabel.Dock = DockStyle.Top;
        entrepotidLabel.Location = new Point(10, 20);
        entrepotidLabel.Name = "entrepotidLabel";
        entrepotidLabel.Size = new Size(311, 23);
        entrepotidLabel.TabIndex = 0;
        entrepotidLabel.Text = "ID :";
        // 
        // panel3
        // 
        panel3.Controls.Add(createadresseBtn);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(474, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(130, 279);
        panel3.TabIndex = 1;
        // 
        // createadresseBtn
        // 
        createadresseBtn.Location = new Point(10, 123);
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
        this.Controls.Add(tableLayoutPanel1);
        this.Controls.Add(panel1);
        this.Name = "EntrepotManagementForm";
        this.Text = "EntrepotManagementForm";
        this.Load += this.EntrepotManagementForm_Load;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) entrepotidField).EndInit();
        panel3.ResumeLayout(false);
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