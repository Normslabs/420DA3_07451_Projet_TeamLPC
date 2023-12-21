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
        ControlLayout = new TableLayoutPanel();
        DataPanel = new Panel();
        ShippingOrderIdnumericUpDown = new NumericUpDown();
        ControlBtnpanel = new Panel();
        Actionbtn = new Button();
        Exitbtn = new Button();
        ServicelistBox = new ListBox();
        label3 = new Label();
        TrackingtextBox = new TextBox();
        label2 = new Label();
        label1 = new Label();
        ControlLayout.SuspendLayout();
        DataPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) ShippingOrderIdnumericUpDown).BeginInit();
        ControlBtnpanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // ControlLayout
        // 
        ControlLayout.ColumnCount = 3;
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        ControlLayout.Controls.Add(DataPanel, 1, 0);
        ControlLayout.Dock = DockStyle.Fill;
        ControlLayout.Location = new Point(0, 0);
        ControlLayout.Name = "ControlLayout";
        ControlLayout.RowCount = 1;
        ControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ControlLayout.Size = new Size(800, 450);
        ControlLayout.TabIndex = 0;
        // 
        // DataPanel
        // 
        DataPanel.Controls.Add(ShippingOrderIdnumericUpDown);
        DataPanel.Controls.Add(ControlBtnpanel);
        DataPanel.Controls.Add(ServicelistBox);
        DataPanel.Controls.Add(label3);
        DataPanel.Controls.Add(TrackingtextBox);
        DataPanel.Controls.Add(label2);
        DataPanel.Controls.Add(label1);
        DataPanel.Dock = DockStyle.Fill;
        DataPanel.Location = new Point(83, 3);
        DataPanel.Name = "DataPanel";
        DataPanel.Size = new Size(634, 444);
        DataPanel.TabIndex = 0;
        // 
        // ShippingOrderIdnumericUpDown
        // 
        ShippingOrderIdnumericUpDown.Location = new Point(3, 24);
        ShippingOrderIdnumericUpDown.Name = "ShippingOrderIdnumericUpDown";
        ShippingOrderIdnumericUpDown.Size = new Size(220, 23);
        ShippingOrderIdnumericUpDown.TabIndex = 2;
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
        // Actionbtn
        // 
        Actionbtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        Actionbtn.Location = new Point(441, 23);
        Actionbtn.Name = "Actionbtn";
        Actionbtn.Size = new Size(92, 40);
        Actionbtn.TabIndex = 1;
        Actionbtn.Text = "ACTION";
        Actionbtn.UseVisualStyleBackColor = true;
        Actionbtn.Click += this.Actionbtn_Click;
        // 
        // Exitbtn
        // 
        Exitbtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        Exitbtn.Location = new Point(539, 23);
        Exitbtn.Name = "Exitbtn";
        Exitbtn.Size = new Size(92, 40);
        Exitbtn.TabIndex = 0;
        Exitbtn.Text = "Quitter";
        Exitbtn.UseVisualStyleBackColor = true;
        Exitbtn.Click += this.Exitbtn_Click;
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
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 94);
        label3.Name = "label3";
        label3.Size = new Size(113, 15);
        label3.TabIndex = 4;
        label3.Text = "Service de livraison :\r\n";
        // 
        // TrackingtextBox
        // 
        TrackingtextBox.Enabled = false;
        TrackingtextBox.Location = new Point(3, 68);
        TrackingtextBox.Name = "TrackingtextBox";
        TrackingtextBox.Size = new Size(220, 23);
        TrackingtextBox.TabIndex = 3;
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
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 6);
        label1.Name = "label1";
        label1.Size = new Size(110, 15);
        label1.TabIndex = 0;
        label1.Text = "Shipping Order ID : ";
        // 
        // ShipmentWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(ControlLayout);
        this.Name = "ShipmentWindow";
        this.Text = "ShipmentWindow";
        ControlLayout.ResumeLayout(false);
        DataPanel.ResumeLayout(false);
        DataPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) ShippingOrderIdnumericUpDown).EndInit();
        ControlBtnpanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel ControlLayout;
    private Panel DataPanel;
    private Label label1;
    private Panel ControlBtnpanel;
    private Button Actionbtn;
    private Button Exitbtn;
    private ListBox ServicelistBox;
    private Label label3;
    private TextBox TrackingtextBox;
    private Label label2;
    private NumericUpDown ShippingOrderIdnumericUpDown;
}