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
        panel1 = new Panel();
        actionbutton1 = new Button();
        Quitbutton1 = new Button();
        Idlabel = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        infopanel2 = new Panel();
        tableLayoutPanel2 = new TableLayoutPanel();
        createAddressButton = new Button();
        adresseClientcomboBox1 = new ComboBox();
        adresselabel1 = new Label();
        entrepotClientcomboBox1 = new ComboBox();
        asignedWarehouselabel1 = new Label();
        companyNameClienttextBox1 = new TextBox();
        companylabel1 = new Label();
        telephoneClienttextBox1 = new TextBox();
        telephonelabel1 = new Label();
        courrielClienttextBox1 = new TextBox();
        courrielClientlabel1 = new Label();
        prenomtextBox1 = new TextBox();
        prenomClientlabel1 = new Label();
        nomClienttextBox1 = new TextBox();
        nomlabel1 = new Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        infopanel2.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
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
        // 
        // Idlabel
        // 
        Idlabel.AutoSize = true;
        Idlabel.Location = new Point(40, 27);
        Idlabel.Name = "Idlabel";
        Idlabel.Size = new Size(0, 15);
        Idlabel.TabIndex = 1;
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
        infopanel2.Controls.Add(tableLayoutPanel2);
        infopanel2.Controls.Add(adresselabel1);
        infopanel2.Controls.Add(entrepotClientcomboBox1);
        infopanel2.Controls.Add(asignedWarehouselabel1);
        infopanel2.Controls.Add(companyNameClienttextBox1);
        infopanel2.Controls.Add(companylabel1);
        infopanel2.Controls.Add(telephoneClienttextBox1);
        infopanel2.Controls.Add(telephonelabel1);
        infopanel2.Controls.Add(courrielClienttextBox1);
        infopanel2.Controls.Add(courrielClientlabel1);
        infopanel2.Controls.Add(prenomtextBox1);
        infopanel2.Controls.Add(prenomClientlabel1);
        infopanel2.Controls.Add(nomClienttextBox1);
        infopanel2.Controls.Add(nomlabel1);
        infopanel2.Dock = DockStyle.Fill;
        infopanel2.Location = new Point(69, 3);
        infopanel2.Name = "infopanel2";
        infopanel2.Padding = new Padding(25, 25, 25, 25);
        infopanel2.Size = new Size(392, 331);
        infopanel2.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
        tableLayoutPanel2.Controls.Add(createAddressButton, 1, 0);
        tableLayoutPanel2.Controls.Add(adresseClientcomboBox1, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Top;
        tableLayoutPanel2.Location = new Point(25, 268);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(342, 30);
        tableLayoutPanel2.TabIndex = 14;
        // 
        // createAddressButton
        // 
        createAddressButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        createAddressButton.Location = new Point(305, 3);
        createAddressButton.Name = "createAddressButton";
        createAddressButton.Size = new Size(34, 24);
        createAddressButton.TabIndex = 14;
        createAddressButton.Text = "+";
        createAddressButton.UseVisualStyleBackColor = true;
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
        nomlabel1.AutoSize = true;
        nomlabel1.Dock = DockStyle.Top;
        nomlabel1.Location = new Point(25, 25);
        nomlabel1.Name = "nomlabel1";
        nomlabel1.Size = new Size(43, 15);
        nomlabel1.TabIndex = 0;
        nomlabel1.Text = "Nom : ";
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