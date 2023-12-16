namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ShipmentOrderWindows {
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
        Quitbutton1 = new Button();
        actionbutton1 = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        infopanel = new Panel();
        clientlabel1 = new Label();
        clientShipmentcomboBox1 = new ComboBox();
        dateCreationlabel1 = new Label();
        datecreatedtextBox1 = new TextBox();
        label1 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        adresseCiviquelabel2 = new Label();
        contactdudestinatairelabel2 = new Label();
        textBox3 = new TextBox();
        codepostallabel2 = new Label();
        textBox4 = new TextBox();
        label2 = new Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        infopanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(actionbutton1);
        panel1.Controls.Add(Quitbutton1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 494);
        panel1.Name = "panel1";
        panel1.Size = new Size(637, 63);
        panel1.TabIndex = 0;
        // 
        // Quitbutton1
        // 
        Quitbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        Quitbutton1.Location = new Point(541, 19);
        Quitbutton1.Name = "Quitbutton1";
        Quitbutton1.Size = new Size(75, 23);
        Quitbutton1.TabIndex = 0;
        Quitbutton1.Text = "Quit";
        Quitbutton1.UseVisualStyleBackColor = true;
        // 
        // actionbutton1
        // 
        actionbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionbutton1.Location = new Point(421, 19);
        actionbutton1.Name = "actionbutton1";
        actionbutton1.Size = new Size(75, 23);
        actionbutton1.TabIndex = 1;
        actionbutton1.Text = "Action";
        actionbutton1.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Controls.Add(infopanel, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(637, 494);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // infopanel
        // 
        infopanel.Controls.Add(label2);
        infopanel.Controls.Add(textBox4);
        infopanel.Controls.Add(codepostallabel2);
        infopanel.Controls.Add(textBox3);
        infopanel.Controls.Add(contactdudestinatairelabel2);
        infopanel.Controls.Add(textBox2);
        infopanel.Controls.Add(adresseCiviquelabel2);
        infopanel.Controls.Add(textBox1);
        infopanel.Controls.Add(label1);
        infopanel.Controls.Add(datecreatedtextBox1);
        infopanel.Controls.Add(dateCreationlabel1);
        infopanel.Controls.Add(clientShipmentcomboBox1);
        infopanel.Controls.Add(clientlabel1);
        infopanel.Dock = DockStyle.Fill;
        infopanel.Location = new Point(66, 3);
        infopanel.Name = "infopanel";
        infopanel.Size = new Size(503, 488);
        infopanel.TabIndex = 0;
        // 
        // clientlabel1
        // 
        clientlabel1.Anchor = AnchorStyles.Left;
        clientlabel1.AutoSize = true;
        clientlabel1.Location = new Point(64, 56);
        clientlabel1.Name = "clientlabel1";
        clientlabel1.Size = new Size(47, 15);
        clientlabel1.TabIndex = 0;
        clientlabel1.Text = "Client : ";
        clientlabel1.Click += this.clientlabel1_Click;
        // 
        // clientShipmentcomboBox1
        // 
        clientShipmentcomboBox1.Anchor = AnchorStyles.Left;
        clientShipmentcomboBox1.FormattingEnabled = true;
        clientShipmentcomboBox1.Location = new Point(226, 56);
        clientShipmentcomboBox1.Name = "clientShipmentcomboBox1";
        clientShipmentcomboBox1.Size = new Size(166, 23);
        clientShipmentcomboBox1.TabIndex = 1;
        // 
        // dateCreationlabel1
        // 
        dateCreationlabel1.Anchor = AnchorStyles.Left;
        dateCreationlabel1.AutoSize = true;
        dateCreationlabel1.Location = new Point(64, 88);
        dateCreationlabel1.Name = "dateCreationlabel1";
        dateCreationlabel1.Size = new Size(88, 15);
        dateCreationlabel1.TabIndex = 2;
        dateCreationlabel1.Text = "Date Création : ";
        // 
        // datecreatedtextBox1
        // 
        datecreatedtextBox1.Anchor = AnchorStyles.Left;
        datecreatedtextBox1.Location = new Point(226, 85);
        datecreatedtextBox1.Name = "datecreatedtextBox1";
        datecreatedtextBox1.Size = new Size(166, 23);
        datecreatedtextBox1.TabIndex = 3;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left;
        label1.AutoSize = true;
        label1.Location = new Point(64, 119);
        label1.Name = "label1";
        label1.Size = new Size(103, 15);
        label1.TabIndex = 4;
        label1.Text = "Date de livraison : ";
        // 
        // textBox1
        // 
        textBox1.Anchor = AnchorStyles.Left;
        textBox1.Location = new Point(226, 116);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(166, 23);
        textBox1.TabIndex = 5;
        // 
        // textBox2
        // 
        textBox2.Anchor = AnchorStyles.Left;
        textBox2.Location = new Point(226, 149);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(166, 23);
        textBox2.TabIndex = 7;
        // 
        // adresseCiviquelabel2
        // 
        adresseCiviquelabel2.Anchor = AnchorStyles.Left;
        adresseCiviquelabel2.AutoSize = true;
        adresseCiviquelabel2.Location = new Point(64, 152);
        adresseCiviquelabel2.Name = "adresseCiviquelabel2";
        adresseCiviquelabel2.Size = new Size(100, 15);
        adresseCiviquelabel2.TabIndex = 6;
        adresseCiviquelabel2.Text = "Adresse Civique : ";
        // 
        // contactdudestinatairelabel2
        // 
        contactdudestinatairelabel2.Anchor = AnchorStyles.Left;
        contactdudestinatairelabel2.AutoSize = true;
        contactdudestinatairelabel2.Location = new Point(64, 183);
        contactdudestinatairelabel2.Name = "contactdudestinatairelabel2";
        contactdudestinatairelabel2.Size = new Size(139, 15);
        contactdudestinatairelabel2.TabIndex = 8;
        contactdudestinatairelabel2.Text = "Contact du destinataire : ";
        // 
        // textBox3
        // 
        textBox3.Anchor = AnchorStyles.Left;
        textBox3.Location = new Point(226, 180);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(166, 23);
        textBox3.TabIndex = 9;
        // 
        // codepostallabel2
        // 
        codepostallabel2.Anchor = AnchorStyles.Left;
        codepostallabel2.AutoSize = true;
        codepostallabel2.Location = new Point(64, 217);
        codepostallabel2.Name = "codepostallabel2";
        codepostallabel2.Size = new Size(143, 15);
        codepostallabel2.TabIndex = 10;
        codepostallabel2.Text = "Code postal destinataire : ";
        // 
        // textBox4
        // 
        textBox4.Anchor = AnchorStyles.Left;
        textBox4.Location = new Point(226, 214);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(166, 23);
        textBox4.TabIndex = 11;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Left;
        label2.AutoSize = true;
        label2.Location = new Point(64, 249);
        label2.Name = "label2";
        label2.Size = new Size(143, 15);
        label2.TabIndex = 12;
        label2.Text = "Code postal destinataire : ";
        // 
        // ShipmentOrderWindows
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(637, 557);
        this.Controls.Add(tableLayoutPanel1);
        this.Controls.Add(panel1);
        this.Name = "ShipmentOrderWindows";
        this.Text = "ShipmentOrderWindows";
        this.Load += this.ShipmentOrderWindows_Load;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        infopanel.ResumeLayout(false);
        infopanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button Quitbutton1;
    private Button actionbutton1;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel infopanel;
    private Label clientlabel1;
    private Label dateCreationlabel1;
    private ComboBox clientShipmentcomboBox1;
    private TextBox textBox1;
    private Label label1;
    private TextBox datecreatedtextBox1;
    private TextBox textBox2;
    private Label codepostallabel2;
    private TextBox textBox3;
    private Label contactdudestinatairelabel2;
    private Label adresseCiviquelabel2;
    private Label label2;
    private TextBox textBox4;
}