namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ClientWindows {
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
        this.actionbutton1 = new Button();
        this.Quitbutton1 = new Button();
        this.Idlabel = new Label();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.infopanel2 = new Panel();
        this.adresseClientcomboBox1 = new ComboBox();
        this.adresselabel1 = new Label();
        this.entrepotClientcomboBox1 = new ComboBox();
        this.asignedWarehouselabel1 = new Label();
        this.companyNameClienttextBox1 = new TextBox();
        this.companylabel1 = new Label();
        this.telephoneClienttextBox1 = new TextBox();
        this.telephonelabel1 = new Label();
        this.courrielClienttextBox1 = new TextBox();
        this.courrielClientlabel1 = new Label();
        this.prenomtextBox1 = new TextBox();
        this.prenomClientlabel1 = new Label();
        this.nomClienttextBox1 = new TextBox();
        this.nomlabel1 = new Label();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.createAddressButton = new Button();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.infopanel2.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.actionbutton1);
        this.panel1.Controls.Add(this.Quitbutton1);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 337);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(531, 64);
        this.panel1.TabIndex = 0;
        // 
        // actionbutton1
        // 
        this.actionbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionbutton1.Location = new Point(325, 19);
        this.actionbutton1.Name = "actionbutton1";
        this.actionbutton1.Size = new Size(75, 23);
        this.actionbutton1.TabIndex = 1;
        this.actionbutton1.Text = "Action";
        this.actionbutton1.UseVisualStyleBackColor = true;
        this.actionbutton1.Click += this.actionbutton1_Click;
        // 
        // Quitbutton1
        // 
        this.Quitbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.Quitbutton1.Location = new Point(424, 19);
        this.Quitbutton1.Name = "Quitbutton1";
        this.Quitbutton1.Size = new Size(75, 23);
        this.Quitbutton1.TabIndex = 0;
        this.Quitbutton1.Text = "Quit";
        this.Quitbutton1.UseVisualStyleBackColor = true;
        this.Quitbutton1.Click += this.Quitbutton1_Click;
        // 
        // Idlabel
        // 
        this.Idlabel.AutoSize = true;
        this.Idlabel.Location = new Point(40, 27);
        this.Idlabel.Name = "Idlabel";
        this.Idlabel.Size = new Size(0, 15);
        this.Idlabel.TabIndex = 1;
        this.Idlabel.Click += this.label1_Click;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        this.tableLayoutPanel1.Controls.Add(this.infopanel2, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(531, 337);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // infopanel2
        // 
        this.infopanel2.Controls.Add(this.tableLayoutPanel2);
        this.infopanel2.Controls.Add(this.adresselabel1);
        this.infopanel2.Controls.Add(this.entrepotClientcomboBox1);
        this.infopanel2.Controls.Add(this.asignedWarehouselabel1);
        this.infopanel2.Controls.Add(this.companyNameClienttextBox1);
        this.infopanel2.Controls.Add(this.companylabel1);
        this.infopanel2.Controls.Add(this.telephoneClienttextBox1);
        this.infopanel2.Controls.Add(this.telephonelabel1);
        this.infopanel2.Controls.Add(this.courrielClienttextBox1);
        this.infopanel2.Controls.Add(this.courrielClientlabel1);
        this.infopanel2.Controls.Add(this.prenomtextBox1);
        this.infopanel2.Controls.Add(this.prenomClientlabel1);
        this.infopanel2.Controls.Add(this.nomClienttextBox1);
        this.infopanel2.Controls.Add(this.nomlabel1);
        this.infopanel2.Dock = DockStyle.Fill;
        this.infopanel2.Location = new Point(69, 3);
        this.infopanel2.Name = "infopanel2";
        this.infopanel2.Padding = new Padding(25, 25, 25, 25);
        this.infopanel2.Size = new Size(392, 331);
        this.infopanel2.TabIndex = 0;
        // 
        // adresseClientcomboBox1
        // 
        this.adresseClientcomboBox1.FormattingEnabled = true;
        this.adresseClientcomboBox1.Location = new Point(3, 2);
        this.adresseClientcomboBox1.Margin = new Padding(3, 2, 3, 2);
        this.adresseClientcomboBox1.Name = "adresseClientcomboBox1";
        this.adresseClientcomboBox1.Size = new Size(296, 23);
        this.adresseClientcomboBox1.TabIndex = 13;
        // 
        // adresselabel1
        // 
        this.adresselabel1.AutoSize = true;
        this.adresselabel1.Dock = DockStyle.Top;
        this.adresselabel1.Location = new Point(25, 253);
        this.adresselabel1.Name = "adresselabel1";
        this.adresselabel1.Size = new Size(57, 15);
        this.adresselabel1.TabIndex = 12;
        this.adresselabel1.Text = "Adresse : ";
        // 
        // entrepotClientcomboBox1
        // 
        this.entrepotClientcomboBox1.Dock = DockStyle.Top;
        this.entrepotClientcomboBox1.FormattingEnabled = true;
        this.entrepotClientcomboBox1.Location = new Point(25, 230);
        this.entrepotClientcomboBox1.Name = "entrepotClientcomboBox1";
        this.entrepotClientcomboBox1.Size = new Size(342, 23);
        this.entrepotClientcomboBox1.TabIndex = 11;
        // 
        // asignedWarehouselabel1
        // 
        this.asignedWarehouselabel1.AutoSize = true;
        this.asignedWarehouselabel1.Dock = DockStyle.Top;
        this.asignedWarehouselabel1.Location = new Point(25, 215);
        this.asignedWarehouselabel1.Name = "asignedWarehouselabel1";
        this.asignedWarehouselabel1.Size = new Size(100, 15);
        this.asignedWarehouselabel1.TabIndex = 10;
        this.asignedWarehouselabel1.Text = "Entrepot Asigné : ";
        // 
        // companyNameClienttextBox1
        // 
        this.companyNameClienttextBox1.Dock = DockStyle.Top;
        this.companyNameClienttextBox1.Location = new Point(25, 192);
        this.companyNameClienttextBox1.Name = "companyNameClienttextBox1";
        this.companyNameClienttextBox1.Size = new Size(342, 23);
        this.companyNameClienttextBox1.TabIndex = 9;
        // 
        // companylabel1
        // 
        this.companylabel1.AutoSize = true;
        this.companylabel1.Dock = DockStyle.Top;
        this.companylabel1.Location = new Point(25, 177);
        this.companylabel1.Name = "companylabel1";
        this.companylabel1.Size = new Size(122, 15);
        this.companylabel1.TabIndex = 8;
        this.companylabel1.Text = "Nom de compagnie : ";
        // 
        // telephoneClienttextBox1
        // 
        this.telephoneClienttextBox1.Dock = DockStyle.Top;
        this.telephoneClienttextBox1.Location = new Point(25, 154);
        this.telephoneClienttextBox1.Name = "telephoneClienttextBox1";
        this.telephoneClienttextBox1.Size = new Size(342, 23);
        this.telephoneClienttextBox1.TabIndex = 7;
        // 
        // telephonelabel1
        // 
        this.telephonelabel1.AutoSize = true;
        this.telephonelabel1.Dock = DockStyle.Top;
        this.telephonelabel1.Location = new Point(25, 139);
        this.telephonelabel1.Name = "telephonelabel1";
        this.telephonelabel1.Size = new Size(61, 15);
        this.telephonelabel1.TabIndex = 6;
        this.telephonelabel1.Text = "Telephone";
        // 
        // courrielClienttextBox1
        // 
        this.courrielClienttextBox1.Dock = DockStyle.Top;
        this.courrielClienttextBox1.Location = new Point(25, 116);
        this.courrielClienttextBox1.Name = "courrielClienttextBox1";
        this.courrielClienttextBox1.Size = new Size(342, 23);
        this.courrielClienttextBox1.TabIndex = 5;
        // 
        // courrielClientlabel1
        // 
        this.courrielClientlabel1.AutoSize = true;
        this.courrielClientlabel1.Dock = DockStyle.Top;
        this.courrielClientlabel1.Location = new Point(25, 101);
        this.courrielClientlabel1.Name = "courrielClientlabel1";
        this.courrielClientlabel1.Size = new Size(58, 15);
        this.courrielClientlabel1.TabIndex = 4;
        this.courrielClientlabel1.Text = "Courriel : ";
        // 
        // prenomtextBox1
        // 
        this.prenomtextBox1.Dock = DockStyle.Top;
        this.prenomtextBox1.Location = new Point(25, 78);
        this.prenomtextBox1.Name = "prenomtextBox1";
        this.prenomtextBox1.Size = new Size(342, 23);
        this.prenomtextBox1.TabIndex = 3;
        // 
        // prenomClientlabel1
        // 
        this.prenomClientlabel1.AutoSize = true;
        this.prenomClientlabel1.Dock = DockStyle.Top;
        this.prenomClientlabel1.Location = new Point(25, 63);
        this.prenomClientlabel1.Name = "prenomClientlabel1";
        this.prenomClientlabel1.Size = new Size(58, 15);
        this.prenomClientlabel1.TabIndex = 2;
        this.prenomClientlabel1.Text = "Prenom : ";
        // 
        // nomClienttextBox1
        // 
        this.nomClienttextBox1.Dock = DockStyle.Top;
        this.nomClienttextBox1.Location = new Point(25, 40);
        this.nomClienttextBox1.Name = "nomClienttextBox1";
        this.nomClienttextBox1.Size = new Size(342, 23);
        this.nomClienttextBox1.TabIndex = 1;
        this.nomClienttextBox1.TextAlign = HorizontalAlignment.Right;
        // 
        // nomlabel1
        // 
        this.nomlabel1.AutoSize = true;
        this.nomlabel1.Dock = DockStyle.Top;
        this.nomlabel1.Location = new Point(25, 25);
        this.nomlabel1.Name = "nomlabel1";
        this.nomlabel1.Size = new Size(43, 15);
        this.nomlabel1.TabIndex = 0;
        this.nomlabel1.Text = "Nom : ";
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 2;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
        this.tableLayoutPanel2.Controls.Add(this.createAddressButton, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.adresseClientcomboBox1, 0, 0);
        this.tableLayoutPanel2.Dock = DockStyle.Top;
        this.tableLayoutPanel2.Location = new Point(25, 268);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new Size(342, 30);
        this.tableLayoutPanel2.TabIndex = 14;
        // 
        // createAddressButton
        // 
        this.createAddressButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.createAddressButton.Location = new Point(305, 3);
        this.createAddressButton.Name = "createAddressButton";
        this.createAddressButton.Size = new Size(34, 24);
        this.createAddressButton.TabIndex = 14;
        this.createAddressButton.Text = "+";
        this.createAddressButton.UseVisualStyleBackColor = true;
        this.createAddressButton.Click += this.CreateAddressButton_Click;
        // 
        // ClientWindows
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(531, 401);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.Idlabel);
        this.Controls.Add(this.panel1);
        this.Name = "ClientWindows";
        this.Text = "ClientWindows";
        this.Load += this.ClientWindows_Load;
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.infopanel2.ResumeLayout(false);
        this.infopanel2.PerformLayout();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Button Quitbutton1;
    private Button actionbutton1;
    private Label Idlabel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel infopanel2;
    private Label telephonelabel1;
    private TextBox courrielClienttextBox1;
    private Label courrielClientlabel1;
    private TextBox prenomtextBox1;
    private Label prenomClientlabel1;
    private TextBox nomClienttextBox1;
    private Label nomlabel1;
    private TextBox companyNameClienttextBox1;
    private Label companylabel1;
    private TextBox telephoneClienttextBox1;
    private ComboBox entrepotClientcomboBox1;
    private Label asignedWarehouselabel1;
    private Label adresselabel1;
    private ComboBox adresseClientcomboBox1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button createAddressButton;
}