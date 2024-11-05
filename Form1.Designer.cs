namespace AptekaProject
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
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login_registerBtn = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(392, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(105, 220);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(223, 26);
            this.login_username.TabIndex = 2;
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(105, 293);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(223, 26);
            this.login_password.TabIndex = 4;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(105, 345);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(223, 44);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Вхід";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Аптека";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login_registerBtn
            // 
            this.login_registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_registerBtn.FlatAppearance.BorderSize = 0;
            this.login_registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.login_registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(127)))));
            this.login_registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerBtn.ForeColor = System.Drawing.Color.White;
            this.login_registerBtn.Location = new System.Drawing.Point(160, 404);
            this.login_registerBtn.Name = "login_registerBtn";
            this.login_registerBtn.Size = new System.Drawing.Size(115, 33);
            this.login_registerBtn.TabIndex = 7;
            this.login_registerBtn.Text = "Реєстрація";
            this.login_registerBtn.UseVisualStyleBackColor = false;
            this.login_registerBtn.Click += new System.EventHandler(this.login_registerBtn_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Location = new System.Drawing.Point(307, 300);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(15, 14);
            this.login_showPass.TabIndex = 8;
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 557);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_registerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_registerBtn;
        private System.Windows.Forms.CheckBox login_showPass;
    }
}

