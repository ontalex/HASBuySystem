namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(543, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputLogin
            // 
            this.inputLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLogin.Font = new System.Drawing.Font("Arial", 16.8F);
            this.inputLogin.Location = new System.Drawing.Point(489, 232);
            this.inputLogin.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.inputLogin.MaxLength = 64;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.ShortcutsEnabled = false;
            this.inputLogin.Size = new System.Drawing.Size(384, 40);
            this.inputLogin.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 14.8F);
            this.btnSignIn.Location = new System.Drawing.Point(489, 381);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(386, 69);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Войти";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Image = global::WindowsFormsApp1.Properties.Resources.image_1__1_;
            this.logo.Location = new System.Drawing.Point(131, 130);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(300, 300);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            //this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPassword.Font = new System.Drawing.Font("Arial", 16.8F);
            this.inputPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputPassword.Location = new System.Drawing.Point(489, 322);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(16);
            this.inputPassword.MaxLength = 64;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(384, 40);
            this.inputPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(485, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(485, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ваш пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

