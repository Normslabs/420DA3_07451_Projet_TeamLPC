namespace _420DA3_07451_Projet_Initial.Presentation;

partial class LoginForm {
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
        usernameTextBox = new TextBox();
        passwordTextBox = new TextBox();
        logInButton = new Button();
        cancelButton = new Button();
        label1 = new Label();
        this.SuspendLayout();
        // 
        // usernameTextBox
        // 
        usernameTextBox.Location = new Point(12, 62);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.PlaceholderText = "Nom d'utilisateur";
        usernameTextBox.Size = new Size(258, 27);
        usernameTextBox.TabIndex = 0;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(12, 95);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PlaceholderText = "Mot de passe";
        passwordTextBox.Size = new Size(258, 27);
        passwordTextBox.TabIndex = 1;
        passwordTextBox.UseSystemPasswordChar = true;
        // 
        // logInButton
        // 
        logInButton.Location = new Point(40, 140);
        logInButton.Name = "logInButton";
        logInButton.Size = new Size(200, 35);
        logInButton.TabIndex = 2;
        logInButton.Text = "Connexion";
        logInButton.UseVisualStyleBackColor = true;
        logInButton.Click += this.LogInButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(40, 181);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(200, 35);
        cancelButton.TabIndex = 3;
        cancelButton.Text = "Annuler";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += this.CancelButton_Click;
        // 
        // label1
        // 
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(258, 50);
        label1.TabIndex = 4;
        label1.Text = "Connexion requise!";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(282, 253);
        this.Controls.Add(label1);
        this.Controls.Add(cancelButton);
        this.Controls.Add(logInButton);
        this.Controls.Add(passwordTextBox);
        this.Controls.Add(usernameTextBox);
        this.Name = "LoginForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Login Required";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox usernameTextBox;
    private TextBox passwordTextBox;
    private Button logInButton;
    private Button cancelButton;
    private Label label1;
}