namespace Connect_to_DB
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameField = new System.Windows.Forms.TextBox();
            this.surenameField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(208, 117);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(180, 20);
            this.nameField.TabIndex = 0;
            this.nameField.Text = "Введите имя";
            this.nameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            this.nameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // surenameField
            // 
            this.surenameField.Location = new System.Drawing.Point(208, 161);
            this.surenameField.Name = "surenameField";
            this.surenameField.Size = new System.Drawing.Size(180, 20);
            this.surenameField.TabIndex = 1;
            this.surenameField.Text = "Введите фамилию";
            this.surenameField.Enter += new System.EventHandler(this.SurenameField_Enter);
            this.surenameField.Leave += new System.EventHandler(this.SurenameField_Leave);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(208, 201);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(180, 20);
            this.loginField.TabIndex = 2;
            this.loginField.Text = "Введите логин";
            this.loginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(208, 244);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(180, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.Text = "Введите пароль";
            this.passwordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registerButton.Location = new System.Drawing.Point(233, 289);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(119, 42);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.surenameField);
            this.Controls.Add(this.nameField);
            this.Name = "RegisterForm";
            this.Text = "Введите имя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox surenameField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button registerButton;
    }
}