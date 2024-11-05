namespace AptekaProject
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
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_loginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.register_confirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Location = new System.Drawing.Point(307, 296);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(15, 14);
            this.register_showPass.TabIndex = 17;
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_loginBtn.FlatAppearance.BorderSize = 0;
            this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginBtn.ForeColor = System.Drawing.Color.White;
            this.register_loginBtn.Location = new System.Drawing.Point(160, 479);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(115, 33);
            this.register_loginBtn.TabIndex = 16;
            this.register_loginBtn.Text = "Вхід";
            this.register_loginBtn.UseVisualStyleBackColor = false;
            this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Аптека";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(105, 420);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(223, 44);
            this.register_btn.TabIndex = 14;
            this.register_btn.Text = "Зареєструватись";
            this.register_btn.UseVisualStyleBackColor = false;
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(105, 289);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(223, 26);
            this.register_password.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(105, 220);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(223, 26);
            this.register_username.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Логін";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(392, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // register_confirmPassword
            // 
            this.register_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_confirmPassword.Location = new System.Drawing.Point(105, 358);
            this.register_confirmPassword.Name = "register_confirmPassword";
            this.register_confirmPassword.PasswordChar = '*';
            this.register_confirmPassword.Size = new System.Drawing.Size(223, 26);
            this.register_confirmPassword.TabIndex = 19;
            this.register_confirmPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Підтвердіть пароль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 557);
            this.Controls.Add(this.register_confirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_loginBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Button register_loginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox register_confirmPassword;
        private System.Windows.Forms.Label label1;
    }
}