namespace AmApp;

partial class StartForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        Login = new TextBox();
        Password = new TextBox();
        AuthorizeBtn = new Button();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // Login
        // 
        Login.Location = new Point(12, 27);
        Login.Name = "Login";
        Login.PlaceholderText = "Имя пользователя";
        Login.Size = new Size(270, 23);
        Login.TabIndex = 0;
        Login.Text = "admin";
        // 
        // Password
        // 
        Password.Location = new Point(12, 71);
        Password.Name = "Password";
        Password.PasswordChar = '*';
        Password.PlaceholderText = "Пароль";
        Password.Size = new Size(270, 23);
        Password.TabIndex = 1;
        Password.Text = "qwerty12345";
        Password.UseSystemPasswordChar = true;
        // 
        // AuthorizeBtn
        // 
        AuthorizeBtn.Location = new Point(109, 100);
        AuthorizeBtn.Name = "AuthorizeBtn";
        AuthorizeBtn.Size = new Size(75, 23);
        AuthorizeBtn.TabIndex = 2;
        AuthorizeBtn.Text = "Войти";
        AuthorizeBtn.UseVisualStyleBackColor = true;
        AuthorizeBtn.Click += AuthorizeBtn_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(109, 15);
        label1.TabIndex = 3;
        label1.Text = "Имя пользователя";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 53);
        label2.Name = "label2";
        label2.Size = new Size(49, 15);
        label2.TabIndex = 3;
        label2.Text = "Пароль";
        // 
        // StartForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(294, 130);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(AuthorizeBtn);
        Controls.Add(Password);
        Controls.Add(Login);
        Name = "StartForm";
        Text = "Авторизация";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox Login;
    private TextBox Password;
    private Button AuthorizeBtn;
    private Label label1;
    private Label label2;
}
