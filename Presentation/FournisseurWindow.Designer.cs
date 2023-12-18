namespace _420DA3_07451_Projet_Initial.Presentation;

partial class FournisseurWindow {
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
        label1 = new Label();
        adresseIDtextBox = new TextBox();
        Datapanel = new Panel();
        label2 = new Label();
        label3 = new Label();
        PrenomContacttextBox1 = new TextBox();
        label4 = new Label();
        NomContacttextBox = new TextBox();
        AdresseContacttextBox = new TextBox();
        label5 = new Label();
        label6 = new Label();
        EmailContacttextBox = new TextBox();
        label7 = new Label();
        textBox1 = new TextBox();
        BtnControlpanel = new Panel();
        ExitBtn = new Button();
        ActionBtn = new Button();
        AdressecomboBox = new ComboBox();
        label8 = new Label();
        tableLayoutPanel1.SuspendLayout();
        Datapanel.SuspendLayout();
        BtnControlpanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Controls.Add(label1, 2, 0);
        tableLayoutPanel1.Controls.Add(Datapanel, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(723, 0);
        label1.Name = "label1";
        label1.Size = new Size(74, 15);
        label1.TabIndex = 0;
        // 
        // adresseIDtextBox
        // 
        adresseIDtextBox.Enabled = false;
        adresseIDtextBox.Location = new Point(182, 24);
        adresseIDtextBox.Name = "adresseIDtextBox";
        adresseIDtextBox.Size = new Size(250, 23);
        adresseIDtextBox.TabIndex = 1;
        adresseIDtextBox.TextChanged += this.textBox1_TextChanged;
        // 
        // Datapanel
        // 
        Datapanel.Controls.Add(label8);
        Datapanel.Controls.Add(AdressecomboBox);
        Datapanel.Controls.Add(BtnControlpanel);
        Datapanel.Controls.Add(textBox1);
        Datapanel.Controls.Add(label7);
        Datapanel.Controls.Add(EmailContacttextBox);
        Datapanel.Controls.Add(label6);
        Datapanel.Controls.Add(label5);
        Datapanel.Controls.Add(AdresseContacttextBox);
        Datapanel.Controls.Add(NomContacttextBox);
        Datapanel.Controls.Add(label4);
        Datapanel.Controls.Add(PrenomContacttextBox1);
        Datapanel.Controls.Add(label3);
        Datapanel.Controls.Add(label2);
        Datapanel.Controls.Add(adresseIDtextBox);
        Datapanel.Dock = DockStyle.Fill;
        Datapanel.Location = new Point(83, 3);
        Datapanel.Name = "Datapanel";
        Datapanel.Size = new Size(634, 444);
        Datapanel.TabIndex = 2;
        Datapanel.Paint += this.panel1_Paint;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(273, 6);
        label2.Name = "label2";
        label2.Size = new Size(71, 15);
        label2.TabIndex = 2;
        label2.Text = "Adresse ID : ";
        label2.Click += this.label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 107);
        label3.Name = "label3";
        label3.Size = new Size(171, 15);
        label3.TabIndex = 3;
        label3.Text = "Prénom du contact d'urgence :";
        // 
        // PrenomContacttextBox1
        // 
        PrenomContacttextBox1.Location = new Point(3, 125);
        PrenomContacttextBox1.Name = "PrenomContacttextBox1";
        PrenomContacttextBox1.PlaceholderText = "Prénom du contact";
        PrenomContacttextBox1.Size = new Size(250, 23);
        PrenomContacttextBox1.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(3, 151);
        label4.Name = "label4";
        label4.Size = new Size(156, 15);
        label4.TabIndex = 5;
        label4.Text = "Nom du contact d'urgence :";
        label4.Click += this.label4_Click;
        // 
        // NomContacttextBox
        // 
        NomContacttextBox.Location = new Point(3, 169);
        NomContacttextBox.Name = "NomContacttextBox";
        NomContacttextBox.PlaceholderText = "Nom du contact";
        NomContacttextBox.Size = new Size(250, 23);
        NomContacttextBox.TabIndex = 6;
        // 
        // AdresseContacttextBox
        // 
        AdresseContacttextBox.Location = new Point(3, 213);
        AdresseContacttextBox.Name = "AdresseContacttextBox";
        AdresseContacttextBox.PlaceholderText = "Adresse du contact";
        AdresseContacttextBox.Size = new Size(250, 23);
        AdresseContacttextBox.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(3, 195);
        label5.Name = "label5";
        label5.Size = new Size(170, 15);
        label5.TabIndex = 8;
        label5.Text = "Adresse du contact d'urgence :";
        label5.Click += this.label5_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(3, 239);
        label6.Name = "label6";
        label6.Size = new Size(158, 15);
        label6.TabIndex = 9;
        label6.Text = "Email du contact d'urgence :";
        // 
        // EmailContacttextBox
        // 
        EmailContacttextBox.Location = new Point(3, 257);
        EmailContacttextBox.Name = "EmailContacttextBox";
        EmailContacttextBox.PlaceholderText = "Email du contact";
        EmailContacttextBox.Size = new Size(250, 23);
        EmailContacttextBox.TabIndex = 10;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(381, 107);
        label7.Name = "label7";
        label7.Size = new Size(119, 15);
        label7.TabIndex = 11;
        label7.Text = "Nom du fournisseur :";
        label7.Click += this.label7_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(381, 125);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Nom du fournisseur";
        textBox1.Size = new Size(250, 23);
        textBox1.TabIndex = 12;
        // 
        // BtnControlpanel
        // 
        BtnControlpanel.Controls.Add(ActionBtn);
        BtnControlpanel.Controls.Add(ExitBtn);
        BtnControlpanel.Dock = DockStyle.Bottom;
        BtnControlpanel.Location = new Point(0, 344);
        BtnControlpanel.Name = "BtnControlpanel";
        BtnControlpanel.Size = new Size(634, 100);
        BtnControlpanel.TabIndex = 13;
        // 
        // ExitBtn
        // 
        ExitBtn.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        ExitBtn.Location = new Point(509, 24);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new Size(122, 43);
        ExitBtn.TabIndex = 0;
        ExitBtn.Text = "Quitter";
        ExitBtn.UseVisualStyleBackColor = true;
        // 
        // ActionBtn
        // 
        ActionBtn.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        ActionBtn.Location = new Point(381, 24);
        ActionBtn.Name = "ActionBtn";
        ActionBtn.Size = new Size(122, 43);
        ActionBtn.TabIndex = 1;
        ActionBtn.Text = "ACTION";
        ActionBtn.UseVisualStyleBackColor = true;
        // 
        // AdressecomboBox
        // 
        AdressecomboBox.FormattingEnabled = true;
        AdressecomboBox.Location = new Point(381, 169);
        AdressecomboBox.Name = "AdressecomboBox";
        AdressecomboBox.Size = new Size(250, 23);
        AdressecomboBox.TabIndex = 14;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(381, 151);
        label8.Name = "label8";
        label8.Size = new Size(133, 15);
        label8.TabIndex = 15;
        label8.Text = "Adresse du fournisseur :";
        label8.Click += this.label8_Click;
        // 
        // FournisseurWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "FournisseurWindow";
        this.Text = "FournisseurWindow";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        Datapanel.ResumeLayout(false);
        Datapanel.PerformLayout();
        BtnControlpanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private TextBox adresseIDtextBox;
    private Panel Datapanel;
    private Label label2;
    private Label label4;
    private TextBox PrenomContacttextBox1;
    private Label label3;
    private Label label5;
    private TextBox AdresseContacttextBox;
    private TextBox NomContacttextBox;
    private TextBox textBox1;
    private Label label7;
    private TextBox EmailContacttextBox;
    private Label label6;
    private Panel BtnControlpanel;
    private Button ActionBtn;
    private Button ExitBtn;
    private Label label8;
    private ComboBox AdressecomboBox;
}