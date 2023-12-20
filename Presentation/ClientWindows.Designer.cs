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
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.createAddressButton = new Button();
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
        this.panel1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.infopanel2.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(actionbutton1);
        panel1.Controls.Add(Quitbutton1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 337);
        panel1.Name = "panel1";
        panel1.Size = new Size(531, 64);
        panel1.TabIndex = 0;
        // 
        // actionbutton1
        // 
        actionbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionbutton1.Location = new Point(325, 19);
        actionbutton1.Name = "actionbutton1";
        actionbutton1.Size = new Size(75, 23);
        actionbutton1.TabIndex = 1;
        actionbutton1.Text = "Action";
        actionbutton1.UseVisualStyleBackColor = true;
        actionbutton1.Click += this.actionbutton1_Click;
        // 
        // Quitbutton1
        // 
        Quitbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        Quitbutton1.Location = new Point(424, 19);
        Quitbutton1.Name = "Quitbutton1";
        Quitbutton1.Size = new Size(75, 23);
        Quitbutton1.TabIndex = 0;
        Quitbutton1.Text = "Quit";
        Quitbutton1.UseVisualStyleBackColor = true;
        Quitbutton1.Click += this.Quitbutton1_Click;
        // 
        // Idlabel
        // 
        Idlabel.AutoSize = true;
        Idlabel.Location = new Point(40, 27);
        Idlabel.Name = "Idlabel";
        Idlabel.Size = new Size(0, 15);
        Idlabel.TabIndex = 1;
        Idlabel.Click += this.label1_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.Controls.Add(infopanel2, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(531, 337);
        tableLayoutPanel1.TabIndex = 2;
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
        this.infopanel2.Padding = new Padding(25);
        this.infopanel2.Size = new Size(392, 331);
        this.infopanel2.TabIndex = 0;
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
        // adresseClientcomboBox1
        // 
        adresseClientcomboBox1.FormattingEnabled = true;
        adresseClientcomboBox1.Location = new Point(3, 2);
        adresseClientcomboBox1.Margin = new Padding(3, 2, 3, 2);
        adresseClientcomboBox1.Name = "adresseClientcomboBox1";
        adresseClientcomboBox1.Size = new Size(296, 23);
        adresseClientcomboBox1.TabIndex = 13;
        // 
        // adresselabel1
        // 
        adresselabel1.AutoSize = true;
        adresselabel1.Dock = DockStyle.Top;
        adresselabel1.Location = new Point(25, 253);
        adresselabel1.Name = "adresselabel1";
        adresselabel1.Size = new Size(57, 15);
        adresselabel1.TabIndex = 12;
        adresselabel1.Text = "Adresse : ";
        // 
        // entrepotClientcomboBox1
        // 
        entrepotClientcomboBox1.Dock = DockStyle.Top;
        entrepotClientcomboBox1.FormattingEnabled = true;
        entrepotClientcomboBox1.Location = new Point(25, 230);
        entrepotClientcomboBox1.Name = "entrepotClientcomboBox1";
        entrepotClientcomboBox1.Size = new Size(342, 23);
        entrepotClientcomboBox1.TabIndex = 11;
        // 
        // asignedWarehouselabel1
        // 
        asignedWarehouselabel1.AutoSize = true;
        asignedWarehouselabel1.Dock = DockStyle.Top;
        asignedWarehouselabel1.Location = new Point(25, 215);
        asignedWarehouselabel1.Name = "asignedWarehouselabel1";
        asignedWarehouselabel1.Size = new Size(100, 15);
        asignedWarehouselabel1.TabIndex = 10;
        asignedWarehouselabel1.Text = "Entrepot Asigné : ";
        // 
        // companyNameClienttextBox1
        // 
        companyNameClienttextBox1.Dock = DockStyle.Top;
        companyNameClienttextBox1.Location = new Point(25, 192);
        companyNameClienttextBox1.Name = "companyNameClienttextBox1";
        companyNameClienttextBox1.Size = new Size(342, 23);
        companyNameClienttextBox1.TabIndex = 9;
        // 
        // companylabel1
        // 
        companylabel1.AutoSize = true;
        companylabel1.Dock = DockStyle.Top;
        companylabel1.Location = new Point(25, 177);
        companylabel1.Name = "companylabel1";
        companylabel1.Size = new Size(122, 15);
        companylabel1.TabIndex = 8;
        companylabel1.Text = "Nom de compagnie : ";
        // 
        // telephoneClienttextBox1
        // 
        telephoneClienttextBox1.Dock = DockStyle.Top;
        telephoneClienttextBox1.Location = new Point(25, 154);
        telephoneClienttextBox1.Name = "telephoneClienttextBox1";
        telephoneClienttextBox1.Size = new Size(342, 23);
        telephoneClienttextBox1.TabIndex = 7;
        // 
        // telephonelabel1
        // 
        telephonelabel1.AutoSize = true;
        telephonelabel1.Dock = DockStyle.Top;
        telephonelabel1.Location = new Point(25, 139);
        telephonelabel1.Name = "telephonelabel1";
        telephonelabel1.Size = new Size(61, 15);
        telephonelabel1.TabIndex = 6;
        telephonelabel1.Text = "Telephone";
        // 
        // courrielClienttextBox1
        // 
        courrielClienttextBox1.Dock = DockStyle.Top;
        courrielClienttextBox1.Location = new Point(25, 116);
        courrielClienttextBox1.Name = "courrielClienttextBox1";
        courrielClienttextBox1.Size = new Size(342, 23);
        courrielClienttextBox1.TabIndex = 5;
        // 
        // courrielClientlabel1
        // 
        courrielClientlabel1.AutoSize = true;
        courrielClientlabel1.Dock = DockStyle.Top;
        courrielClientlabel1.Location = new Point(25, 101);
        courrielClientlabel1.Name = "courrielClientlabel1";
        courrielClientlabel1.Size = new Size(58, 15);
        courrielClientlabel1.TabIndex = 4;
        courrielClientlabel1.Text = "Courriel : ";
        // 
        // prenomtextBox1
        // 
        prenomtextBox1.Dock = DockStyle.Top;
        prenomtextBox1.Location = new Point(25, 78);
        prenomtextBox1.Name = "prenomtextBox1";
        prenomtextBox1.Size = new Size(342, 23);
        prenomtextBox1.TabIndex = 3;
        // 
        // prenomClientlabel1
        // 
        prenomClientlabel1.AutoSize = true;
        prenomClientlabel1.Dock = DockStyle.Top;
        prenomClientlabel1.Location = new Point(25, 63);
        prenomClientlabel1.Name = "prenomClientlabel1";
        prenomClientlabel1.Size = new Size(58, 15);
        prenomClientlabel1.TabIndex = 2;
        prenomClientlabel1.Text = "Prenom : ";
        // 
        // nomClienttextBox1
        // 
        nomClienttextBox1.Dock = DockStyle.Top;
        nomClienttextBox1.Location = new Point(25, 40);
        nomClienttextBox1.Name = "nomClienttextBox1";
        nomClienttextBox1.Size = new Size(342, 23);
        nomClienttextBox1.TabIndex = 1;
        nomClienttextBox1.TextAlign = HorizontalAlignment.Right;
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
        // ClientWindows
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(531, 401);
        this.Controls.Add(tableLayoutPanel1);
        this.Controls.Add(Idlabel);
        this.Controls.Add(panel1);
        this.Name = "ClientWindows";
        this.Text = "ClientWindows";
        this.Load += this.ClientWindows_Load;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        infopanel2.ResumeLayout(false);
        infopanel2.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
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