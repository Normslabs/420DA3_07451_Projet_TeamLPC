namespace _420DA3_07451_Projet_Initial.Presentation;

partial class TestCours {
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
        comboBox1 = new ComboBox();
        textBox1 = new TextBox();
        listBox1 = new ListBox();
        textBox2 = new TextBox();
        button1 = new Button();
        this.SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.Simple;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(484, 51);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(304, 28);
        comboBox1.TabIndex = 0;
        comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 71);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Serch in list...";
        textBox1.Size = new Size(282, 27);
        textBox1.TabIndex = 1;
        textBox1.TextChanged += this.textBox1_TextChanged;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(12, 104);
        listBox1.Name = "listBox1";
        listBox1.SelectionMode = SelectionMode.MultiSimple;
        listBox1.Size = new Size(282, 124);
        listBox1.TabIndex = 2;
        listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(406, 187);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(350, 27);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.BackColor = Color.LimeGreen;
        button1.FlatAppearance.BorderColor = Color.LimeGreen;
        button1.FlatAppearance.BorderSize = 3;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(406, 274);
        button1.Name = "button1";
        button1.Size = new Size(252, 72);
        button1.TabIndex = 14;
        button1.Text = "DEMO";
        button1.UseVisualStyleBackColor = false;
        button1.MouseEnter += this.button1_MouseEnter;
        button1.MouseLeave += this.button1_MouseLeave;
        // 
        // TestCours
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(button1);
        this.Controls.Add(textBox2);
        this.Controls.Add(listBox1);
        this.Controls.Add(textBox1);
        this.Controls.Add(comboBox1);
        this.Name = "TestCours";
        this.Text = "TestCours";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private ComboBox comboBox1;
    private TextBox textBox1;
    private ListBox listBox1;
    private TextBox textBox2;
    private Button button1;
}