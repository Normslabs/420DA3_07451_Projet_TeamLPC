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
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.label1 = new Label();
        this.Datapanel = new Panel();
        this.label8 = new Label();
        this.AdressecomboBox = new ComboBox();
        this.BtnControlpanel = new Panel();
        this.ActionBtn = new Button();
        this.ExitBtn = new Button();
        this.FournisseurNomtextBox = new TextBox();
        this.label7 = new Label();
        this.EmailContacttextBox = new TextBox();
        this.label6 = new Label();
        this.label5 = new Label();
        this.AdresseContacttextBox = new TextBox();
        this.NomContacttextBox = new TextBox();
        this.label4 = new Label();
        this.PrenomContacttextBox1 = new TextBox();
        this.label3 = new Label();
        this.tableLayoutPanel1.SuspendLayout();
        this.Datapanel.SuspendLayout();
        this.BtnControlpanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
        this.tableLayoutPanel1.Controls.Add(this.Datapanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(800, 450);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = DockStyle.Top;
        this.label1.Location = new Point(723, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(74, 15);
        this.label1.TabIndex = 0;
        // 
        // Datapanel
        // 
        this.Datapanel.Controls.Add(this.label8);
        this.Datapanel.Controls.Add(this.AdressecomboBox);
        this.Datapanel.Controls.Add(this.BtnControlpanel);
        this.Datapanel.Controls.Add(this.FournisseurNomtextBox);
        this.Datapanel.Controls.Add(this.label7);
        this.Datapanel.Controls.Add(this.EmailContacttextBox);
        this.Datapanel.Controls.Add(this.label6);
        this.Datapanel.Controls.Add(this.label5);
        this.Datapanel.Controls.Add(this.AdresseContacttextBox);
        this.Datapanel.Controls.Add(this.NomContacttextBox);
        this.Datapanel.Controls.Add(this.label4);
        this.Datapanel.Controls.Add(this.PrenomContacttextBox1);
        this.Datapanel.Controls.Add(this.label3);
        this.Datapanel.Dock = DockStyle.Fill;
        this.Datapanel.Location = new Point(83, 3);
        this.Datapanel.Name = "Datapanel";
        this.Datapanel.Size = new Size(634, 444);
        this.Datapanel.TabIndex = 2;
        // 
        // label8
        // 
        this.label8.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(381, 151);
        this.label8.Name = "label8";
        this.label8.Size = new Size(133, 15);
        this.label8.TabIndex = 15;
        this.label8.Text = "Adresse du fournisseur :";
        // 
        // AdressecomboBox
        // 
        this.AdressecomboBox.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        this.AdressecomboBox.FormattingEnabled = true;
        this.AdressecomboBox.Location = new Point(381, 169);
        this.AdressecomboBox.Name = "AdressecomboBox";
        this.AdressecomboBox.Size = new Size(250, 23);
        this.AdressecomboBox.TabIndex = 14;
        // 
        // BtnControlpanel
        // 
        this.BtnControlpanel.Controls.Add(this.ActionBtn);
        this.BtnControlpanel.Controls.Add(this.ExitBtn);
        this.BtnControlpanel.Dock = DockStyle.Bottom;
        this.BtnControlpanel.Location = new Point(0, 344);
        this.BtnControlpanel.Name = "BtnControlpanel";
        this.BtnControlpanel.Size = new Size(634, 100);
        this.BtnControlpanel.TabIndex = 13;
        // 
        // ActionBtn
        // 
        this.ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.ActionBtn.Location = new Point(381, 24);
        this.ActionBtn.Name = "ActionBtn";
        this.ActionBtn.Size = new Size(122, 43);
        this.ActionBtn.TabIndex = 1;
        this.ActionBtn.Text = "ACTION";
        this.ActionBtn.UseVisualStyleBackColor = true;
        this.ActionBtn.Click += this.ActionBtn_Click;
        // 
        // ExitBtn
        // 
        this.ExitBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.ExitBtn.Location = new Point(509, 24);
        this.ExitBtn.Name = "ExitBtn";
        this.ExitBtn.Size = new Size(122, 43);
        this.ExitBtn.TabIndex = 0;
        this.ExitBtn.Text = "Quitter";
        this.ExitBtn.UseVisualStyleBackColor = true;
        this.ExitBtn.Click += this.ExitBtn_Click;
        // 
        // FournisseurNomtextBox
        // 
        this.FournisseurNomtextBox.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        this.FournisseurNomtextBox.Location = new Point(381, 125);
        this.FournisseurNomtextBox.Name = "FournisseurNomtextBox";
        this.FournisseurNomtextBox.PlaceholderText = "Nom du fournisseur";
        this.FournisseurNomtextBox.Size = new Size(250, 23);
        this.FournisseurNomtextBox.TabIndex = 12;
        // 
        // label7
        // 
        this.label7.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(381, 107);
        this.label7.Name = "label7";
        this.label7.Size = new Size(119, 15);
        this.label7.TabIndex = 11;
        this.label7.Text = "Nom du fournisseur :";
        // 
        // EmailContacttextBox
        // 
        this.EmailContacttextBox.Location = new Point(3, 257);
        this.EmailContacttextBox.Name = "EmailContacttextBox";
        this.EmailContacttextBox.PlaceholderText = "Email du contact";
        this.EmailContacttextBox.Size = new Size(250, 23);
        this.EmailContacttextBox.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(3, 239);
        this.label6.Name = "label6";
        this.label6.Size = new Size(158, 15);
        this.label6.TabIndex = 9;
        this.label6.Text = "Email du contact d'urgence :";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(3, 195);
        this.label5.Name = "label5";
        this.label5.Size = new Size(183, 15);
        this.label5.TabIndex = 8;
        this.label5.Text = "Téléphone du contact d'urgence :";
        // 
        // AdresseContacttextBox
        // 
        this.AdresseContacttextBox.Location = new Point(3, 213);
        this.AdresseContacttextBox.Name = "AdresseContacttextBox";
        this.AdresseContacttextBox.PlaceholderText = "Telephone du contact";
        this.AdresseContacttextBox.Size = new Size(250, 23);
        this.AdresseContacttextBox.TabIndex = 7;
        // 
        // NomContacttextBox
        // 
        this.NomContacttextBox.Location = new Point(3, 169);
        this.NomContacttextBox.Name = "NomContacttextBox";
        this.NomContacttextBox.PlaceholderText = "Nom du contact";
        this.NomContacttextBox.Size = new Size(250, 23);
        this.NomContacttextBox.TabIndex = 6;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(3, 151);
        this.label4.Name = "label4";
        this.label4.Size = new Size(156, 15);
        this.label4.TabIndex = 5;
        this.label4.Text = "Nom du contact d'urgence :";
        // 
        // PrenomContacttextBox1
        // 
        this.PrenomContacttextBox1.Location = new Point(3, 125);
        this.PrenomContacttextBox1.Name = "PrenomContacttextBox1";
        this.PrenomContacttextBox1.PlaceholderText = "Prénom du contact";
        this.PrenomContacttextBox1.Size = new Size(250, 23);
        this.PrenomContacttextBox1.TabIndex = 4;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(3, 107);
        this.label3.Name = "label3";
        this.label3.Size = new Size(171, 15);
        this.label3.TabIndex = 3;
        this.label3.Text = "Prénom du contact d'urgence :";
        // 
        // FournisseurWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "FournisseurWindow";
        this.Text = "FournisseurWindow";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.Datapanel.ResumeLayout(false);
        this.Datapanel.PerformLayout();
        this.BtnControlpanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Panel Datapanel;
    private Label label4;
    private TextBox PrenomContacttextBox1;
    private Label label3;
    private Label label5;
    private TextBox AdresseContacttextBox;
    private TextBox NomContacttextBox;
    private TextBox FournisseurNomtextBox;
    private Label label7;
    private TextBox EmailContacttextBox;
    private Label label6;
    private Panel BtnControlpanel;
    private Button ActionBtn;
    private Button ExitBtn;
    private Label label8;
    private ComboBox AdressecomboBox;
}