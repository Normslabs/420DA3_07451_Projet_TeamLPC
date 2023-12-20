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
        this.panel1 = new Panel();
        this.actionbutton1 = new Button();
        this.Quitbutton1 = new Button();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.infopanel = new Panel();
        this.label2 = new Label();
        this.textBox4 = new TextBox();
        this.codepostallabel2 = new Label();
        this.textBox3 = new TextBox();
        this.contactdudestinatairelabel2 = new Label();
        this.textBox2 = new TextBox();
        this.adresseCiviquelabel2 = new Label();
        this.textBox1 = new TextBox();
        this.label1 = new Label();
        this.datecreatedtextBox1 = new TextBox();
        this.dateCreationlabel1 = new Label();
        this.clientShipmentcomboBox1 = new ComboBox();
        this.clientlabel1 = new Label();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.infopanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.actionbutton1);
        this.panel1.Controls.Add(this.Quitbutton1);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 659);
        this.panel1.Margin = new Padding(3, 4, 3, 4);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(728, 84);
        this.panel1.TabIndex = 0;
        // 
        // actionbutton1
        // 
        this.actionbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionbutton1.Location = new Point(481, 25);
        this.actionbutton1.Margin = new Padding(3, 4, 3, 4);
        this.actionbutton1.Name = "actionbutton1";
        this.actionbutton1.Size = new Size(86, 31);
        this.actionbutton1.TabIndex = 1;
        this.actionbutton1.Text = "Action";
        this.actionbutton1.UseVisualStyleBackColor = true;
        // 
        // Quitbutton1
        // 
        this.Quitbutton1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.Quitbutton1.Location = new Point(618, 25);
        this.Quitbutton1.Margin = new Padding(3, 4, 3, 4);
        this.Quitbutton1.Name = "Quitbutton1";
        this.Quitbutton1.Size = new Size(86, 31);
        this.Quitbutton1.TabIndex = 0;
        this.Quitbutton1.Text = "Quit";
        this.Quitbutton1.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel1.Controls.Add(this.infopanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(728, 659);
        this.tableLayoutPanel1.TabIndex = 1;
        this.tableLayoutPanel1.Paint += this.tableLayoutPanel1_Paint;
        // 
        // infopanel
        // 
        this.infopanel.Controls.Add(this.label2);
        this.infopanel.Controls.Add(this.textBox4);
        this.infopanel.Controls.Add(this.codepostallabel2);
        this.infopanel.Controls.Add(this.textBox3);
        this.infopanel.Controls.Add(this.contactdudestinatairelabel2);
        this.infopanel.Controls.Add(this.textBox2);
        this.infopanel.Controls.Add(this.adresseCiviquelabel2);
        this.infopanel.Controls.Add(this.textBox1);
        this.infopanel.Controls.Add(this.label1);
        this.infopanel.Controls.Add(this.datecreatedtextBox1);
        this.infopanel.Controls.Add(this.dateCreationlabel1);
        this.infopanel.Controls.Add(this.clientShipmentcomboBox1);
        this.infopanel.Controls.Add(this.clientlabel1);
        this.infopanel.Dock = DockStyle.Fill;
        this.infopanel.Location = new Point(75, 4);
        this.infopanel.Margin = new Padding(3, 4, 3, 4);
        this.infopanel.Name = "infopanel";
        this.infopanel.Size = new Size(576, 651);
        this.infopanel.TabIndex = 0;
        // 
        // label2
        // 
        this.label2.Anchor = AnchorStyles.Left;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(73, 332);
        this.label2.Name = "label2";
        this.label2.Size = new Size(182, 20);
        this.label2.TabIndex = 12;
        this.label2.Text = "Code postal destinataire : ";
        // 
        // textBox4
        // 
        this.textBox4.Anchor = AnchorStyles.Left;
        this.textBox4.Location = new Point(258, 285);
        this.textBox4.Margin = new Padding(3, 4, 3, 4);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new Size(189, 27);
        this.textBox4.TabIndex = 11;
        // 
        // codepostallabel2
        // 
        this.codepostallabel2.Anchor = AnchorStyles.Left;
        this.codepostallabel2.AutoSize = true;
        this.codepostallabel2.Location = new Point(73, 289);
        this.codepostallabel2.Name = "codepostallabel2";
        this.codepostallabel2.Size = new Size(182, 20);
        this.codepostallabel2.TabIndex = 10;
        this.codepostallabel2.Text = "Code postal destinataire : ";
        // 
        // textBox3
        // 
        this.textBox3.Anchor = AnchorStyles.Left;
        this.textBox3.Location = new Point(258, 240);
        this.textBox3.Margin = new Padding(3, 4, 3, 4);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new Size(189, 27);
        this.textBox3.TabIndex = 9;
        // 
        // contactdudestinatairelabel2
        // 
        this.contactdudestinatairelabel2.Anchor = AnchorStyles.Left;
        this.contactdudestinatairelabel2.AutoSize = true;
        this.contactdudestinatairelabel2.Location = new Point(73, 244);
        this.contactdudestinatairelabel2.Name = "contactdudestinatairelabel2";
        this.contactdudestinatairelabel2.Size = new Size(174, 20);
        this.contactdudestinatairelabel2.TabIndex = 8;
        this.contactdudestinatairelabel2.Text = "Contact du destinataire : ";
        // 
        // textBox2
        // 
        this.textBox2.Anchor = AnchorStyles.Left;
        this.textBox2.Location = new Point(258, 199);
        this.textBox2.Margin = new Padding(3, 4, 3, 4);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(189, 27);
        this.textBox2.TabIndex = 7;
        // 
        // adresseCiviquelabel2
        // 
        this.adresseCiviquelabel2.Anchor = AnchorStyles.Left;
        this.adresseCiviquelabel2.AutoSize = true;
        this.adresseCiviquelabel2.Location = new Point(73, 203);
        this.adresseCiviquelabel2.Name = "adresseCiviquelabel2";
        this.adresseCiviquelabel2.Size = new Size(125, 20);
        this.adresseCiviquelabel2.TabIndex = 6;
        this.adresseCiviquelabel2.Text = "Adresse Civique : ";
        // 
        // textBox1
        // 
        this.textBox1.Anchor = AnchorStyles.Left;
        this.textBox1.Location = new Point(258, 155);
        this.textBox1.Margin = new Padding(3, 4, 3, 4);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(189, 27);
        this.textBox1.TabIndex = 5;
        // 
        // label1
        // 
        this.label1.Anchor = AnchorStyles.Left;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(73, 159);
        this.label1.Name = "label1";
        this.label1.Size = new Size(132, 20);
        this.label1.TabIndex = 4;
        this.label1.Text = "Date de livraison : ";
        // 
        // datecreatedtextBox1
        // 
        this.datecreatedtextBox1.Anchor = AnchorStyles.Left;
        this.datecreatedtextBox1.Location = new Point(258, 113);
        this.datecreatedtextBox1.Margin = new Padding(3, 4, 3, 4);
        this.datecreatedtextBox1.Name = "datecreatedtextBox1";
        this.datecreatedtextBox1.Size = new Size(189, 27);
        this.datecreatedtextBox1.TabIndex = 3;
        // 
        // dateCreationlabel1
        // 
        this.dateCreationlabel1.Anchor = AnchorStyles.Left;
        this.dateCreationlabel1.AutoSize = true;
        this.dateCreationlabel1.Location = new Point(73, 117);
        this.dateCreationlabel1.Name = "dateCreationlabel1";
        this.dateCreationlabel1.Size = new Size(112, 20);
        this.dateCreationlabel1.TabIndex = 2;
        this.dateCreationlabel1.Text = "Date Création : ";
        // 
        // clientShipmentcomboBox1
        // 
        this.clientShipmentcomboBox1.Anchor = AnchorStyles.Left;
        this.clientShipmentcomboBox1.FormattingEnabled = true;
        this.clientShipmentcomboBox1.Location = new Point(258, 75);
        this.clientShipmentcomboBox1.Margin = new Padding(3, 4, 3, 4);
        this.clientShipmentcomboBox1.Name = "clientShipmentcomboBox1";
        this.clientShipmentcomboBox1.Size = new Size(189, 28);
        this.clientShipmentcomboBox1.TabIndex = 1;
        // 
        // clientlabel1
        // 
        this.clientlabel1.Anchor = AnchorStyles.Left;
        this.clientlabel1.AutoSize = true;
        this.clientlabel1.Location = new Point(73, 75);
        this.clientlabel1.Name = "clientlabel1";
        this.clientlabel1.Size = new Size(58, 20);
        this.clientlabel1.TabIndex = 0;
        this.clientlabel1.Text = "Client : ";
        this.clientlabel1.Click += this.clientlabel1_Click;
        // 
        // ShipmentOrderWindows
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(728, 743);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.panel1);
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "ShipmentOrderWindows";
        this.Text = "ShipmentOrderWindows";
        this.Load += this.ShipmentOrderWindows_Load;
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.infopanel.ResumeLayout(false);
        this.infopanel.PerformLayout();
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