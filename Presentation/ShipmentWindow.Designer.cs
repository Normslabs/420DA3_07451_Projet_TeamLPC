namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ShipmentWindow {
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
        panel1 = new Panel();
        label1 = new Label();
        ShippingOrderIdTextbox = new TextBox();
        label2 = new Label();
        TrackingtextBox = new TextBox();
        label3 = new Label();
        ServicelistBox = new ListBox();
        ControlBtnpanel = new Panel();
        Exitbtn = new Button();
        Actionbtn = new Button();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ControlBtnpanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Controls.Add(panel1, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(ControlBtnpanel);
        panel1.Controls.Add(ServicelistBox);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(TrackingtextBox);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(ShippingOrderIdTextbox);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(83, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(634, 444);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 6);
        label1.Name = "label1";
        label1.Size = new Size(110, 15);
        label1.TabIndex = 0;
        label1.Text = "Shipping Order ID : ";
        // 
        // ShippingOrderIdTextbox
        // 
        ShippingOrderIdTextbox.Enabled = false;
        ShippingOrderIdTextbox.Location = new Point(3, 24);
        ShippingOrderIdTextbox.Name = "ShippingOrderIdTextbox";
        ShippingOrderIdTextbox.Size = new Size(220, 23);
        ShippingOrderIdTextbox.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 50);
        label2.Name = "label2";
        label2.Size = new Size(102, 15);
        label2.TabIndex = 2;
        label2.Text = "Tracking number :";
        // 
        // TrackingtextBox
        // 
        TrackingtextBox.Enabled = false;
        TrackingtextBox.Location = new Point(3, 68);
        TrackingtextBox.Name = "TrackingtextBox";
        TrackingtextBox.Size = new Size(220, 23);
        TrackingtextBox.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 94);
        label3.Name = "label3";
        label3.Size = new Size(113, 15);
        label3.TabIndex = 4;
        label3.Text = "Service de livraison :\r\n";
        // 
        // ServicelistBox
        // 
        ServicelistBox.FormattingEnabled = true;
        ServicelistBox.ItemHeight = 15;
        ServicelistBox.Location = new Point(3, 112);
        ServicelistBox.Name = "ServicelistBox";
        ServicelistBox.Size = new Size(259, 94);
        ServicelistBox.TabIndex = 5;
        // 
        // ControlBtnpanel
        // 
        ControlBtnpanel.Controls.Add(Actionbtn);
        ControlBtnpanel.Controls.Add(Exitbtn);
        ControlBtnpanel.Dock = DockStyle.Bottom;
        ControlBtnpanel.Location = new Point(0, 344);
        ControlBtnpanel.Name = "ControlBtnpanel";
        ControlBtnpanel.Size = new Size(634, 100);
        ControlBtnpanel.TabIndex = 6;
        // 
        // Exitbtn
        // 
        Exitbtn.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        Exitbtn.Location = new Point(539, 23);
        Exitbtn.Name = "Exitbtn";
        Exitbtn.Size = new Size(92, 40);
        Exitbtn.TabIndex = 0;
        Exitbtn.Text = "Quitter";
        Exitbtn.UseVisualStyleBackColor = true;
        // 
        // Actionbtn
        // 
        Actionbtn.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        Actionbtn.Location = new Point(441, 23);
        Actionbtn.Name = "Actionbtn";
        Actionbtn.Size = new Size(92, 40);
        Actionbtn.TabIndex = 1;
        Actionbtn.Text = "ACTION";
        Actionbtn.UseVisualStyleBackColor = true;
        // 
        // ShipmentWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "ShipmentWindow";
        this.Text = "ShipmentWindow";
        this.Load += this.ShipmentWindow_Load;
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ControlBtnpanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Label label1;
    private Panel ControlBtnpanel;
    private Button Actionbtn;
    private Button Exitbtn;
    private ListBox ServicelistBox;
    private Label label3;
    private TextBox TrackingtextBox;
    private Label label2;
    private TextBox ShippingOrderIdTextbox;
}